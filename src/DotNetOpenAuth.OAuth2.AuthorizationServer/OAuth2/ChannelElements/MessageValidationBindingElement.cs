﻿//-----------------------------------------------------------------------
// <copyright file="MessageValidationBindingElement.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2.ChannelElements {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.OAuth2.Messages;
	using Messaging;

	/// <summary>
	/// A guard for all messages to or from an Authorization Server to ensure that they are well formed,
	/// have valid secrets, callback URIs, etc.
	/// </summary>
	/// <remarks>
	/// This binding element also ensures that the code/token coming in is issued to
	/// the same client that is sending the code/token and that the authorization has
	/// not been revoked and that an access token has not expired.
	/// </remarks>
	internal class MessageValidationBindingElement : AuthServerBindingElementBase {
		/// <summary>
		/// Gets the protection commonly offered (if any) by this binding element.
		/// </summary>
		/// <remarks>
		/// This value is used to assist in sorting binding elements in the channel stack.
		/// </remarks>
		public override MessageProtections Protection {
			get { return MessageProtections.None; }
		}

		/// <summary>
		/// Prepares a message for sending based on the rules of this channel binding element.
		/// </summary>
		/// <param name="message">The message to prepare for sending.</param>
		/// <returns>
		/// The protections (if any) that this binding element applied to the message.
		/// Null if this binding element did not even apply to this binding element.
		/// </returns>
		/// <remarks>
		/// Implementations that provide message protection must honor the
		/// <see cref="MessagePartAttribute.RequiredProtection"/> properties where applicable.
		/// </remarks>
		public override MessageProtections? ProcessOutgoingMessage(IProtocolMessage message) {
			var accessTokenResponse = message as AccessTokenSuccessResponse;
			if (accessTokenResponse != null) {
				var directResponseMessage = (IDirectResponseProtocolMessage)accessTokenResponse;
				var accessTokenRequest = (AccessTokenRequestBase)directResponseMessage.OriginatingRequest;
				ErrorUtilities.VerifyProtocol(accessTokenRequest.GrantType != GrantType.ClientCredentials || accessTokenResponse.RefreshToken == null, OAuthStrings.NoGrantNoRefreshToken);
			}

			return null;
		}

		/// <summary>
		/// Performs any transformation on an incoming message that may be necessary and/or
		/// validates an incoming message based on the rules of this channel binding element.
		/// </summary>
		/// <param name="message">The incoming message to process.</param>
		/// <returns>
		/// The protections (if any) that this binding element applied to the message.
		/// Null if this binding element did not even apply to this binding element.
		/// </returns>
		/// <exception cref="ProtocolException">
		/// Thrown when the binding element rules indicate that this message is invalid and should
		/// NOT be processed.
		/// </exception>
		/// <remarks>
		/// Implementations that provide message protection must honor the
		/// <see cref="MessagePartAttribute.RequiredProtection"/> properties where applicable.
		/// </remarks>
		public override MessageProtections? ProcessIncomingMessage(IProtocolMessage message) {
			bool applied = false;

			// Check that the client secret is correct for client authenticated messages.
			var clientCredentialOnly = message as AccessTokenClientCredentialsRequest;
			var authenticatedClientRequest = message as AuthenticatedClientRequestBase;
			if (authenticatedClientRequest != null) {
				var client = this.AuthorizationServer.GetClientOrThrow(authenticatedClientRequest.ClientIdentifier);
				AuthServerUtilities.TokenEndpointVerify(client.HasNonEmptySecret, Protocol.AccessTokenRequestErrorCodes.UnauthorizedClient); // an empty secret is not allowed for client authenticated calls.
				AuthServerUtilities.TokenEndpointVerify(client.IsValidClientSecret(authenticatedClientRequest.ClientSecret), Protocol.AccessTokenRequestErrorCodes.InvalidClient, AuthServerStrings.ClientSecretMismatch);

				if (clientCredentialOnly != null) {
					clientCredentialOnly.CredentialsValidated = true;
				}

				applied = true;
			}

			// Check that any resource owner password credential is correct.
			var resourceOwnerPasswordCarrier = message as AccessTokenResourceOwnerPasswordCredentialsRequest;
			if (resourceOwnerPasswordCarrier != null) {
				try {
					if (this.AuthorizationServer.IsResourceOwnerCredentialValid(resourceOwnerPasswordCarrier.UserName, resourceOwnerPasswordCarrier.Password)) {
						resourceOwnerPasswordCarrier.CredentialsValidated = true;
					} else {
						Logger.OAuth.ErrorFormat(
							"Resource owner password credential for user \"{0}\" rejected by authorization server host.",
							resourceOwnerPasswordCarrier.UserName);
						throw new TokenEndpointProtocolException(Protocol.AccessTokenRequestErrorCodes.InvalidGrant, AuthServerStrings.InvalidResourceOwnerPasswordCredential);
					}
				} catch (NotSupportedException) {
					throw new TokenEndpointProtocolException(Protocol.AccessTokenRequestErrorCodes.UnsupportedGrantType);
				} catch (NotImplementedException) {
					throw new TokenEndpointProtocolException(Protocol.AccessTokenRequestErrorCodes.UnsupportedGrantType);
				}
			}

			// Check that authorization requests come with an acceptable callback URI.
			var authorizationRequest = message as EndUserAuthorizationRequest;
			if (authorizationRequest != null) {
				var client = this.AuthorizationServer.GetClientOrThrow(authorizationRequest.ClientIdentifier);
				ErrorUtilities.VerifyProtocol(authorizationRequest.Callback == null || client.IsCallbackAllowed(authorizationRequest.Callback), AuthServerStrings.ClientCallbackDisallowed, authorizationRequest.Callback);
				ErrorUtilities.VerifyProtocol(authorizationRequest.Callback != null || client.DefaultCallback != null, AuthServerStrings.NoCallback);
				applied = true;
			}

			// Check that the callback URI in a direct message from the client matches the one in the indirect message received earlier.
			var request = message as AccessTokenAuthorizationCodeRequestAS;
			if (request != null) {
				IAuthorizationCodeCarryingRequest tokenRequest = request;
				tokenRequest.AuthorizationDescription.VerifyCallback(request.Callback);
				applied = true;
			}

			var authCarrier = message as IAuthorizationCarryingRequest;
			if (authCarrier != null) {
				var accessRequest = authCarrier as AccessTokenRequestBase;
				if (accessRequest != null) {
					// Make sure the client sending us this token is the client we issued the token to.
					AuthServerUtilities.TokenEndpointVerify(string.Equals(accessRequest.ClientIdentifier, authCarrier.AuthorizationDescription.ClientIdentifier, StringComparison.Ordinal), Protocol.AccessTokenRequestErrorCodes.InvalidClient);

					var scopedAccessRequest = accessRequest as ScopedAccessTokenRequest;
					if (scopedAccessRequest != null) {
						// Make sure the scope the client is requesting does not exceed the scope in the grant.
						if (!scopedAccessRequest.Scope.IsSubsetOf(authCarrier.AuthorizationDescription.Scope)) {
							Logger.OAuth.ErrorFormat("The requested access scope (\"{0}\") exceeds the grant scope (\"{1}\").", scopedAccessRequest.Scope, authCarrier.AuthorizationDescription.Scope);
							throw new TokenEndpointProtocolException(Protocol.AccessTokenRequestErrorCodes.InvalidScope, AuthServerStrings.AccessScopeExceedsGrantScope);
						}
					}
				}

				// Make sure the authorization this token represents hasn't already been revoked.
				if (!this.AuthorizationServer.IsAuthorizationValid(authCarrier.AuthorizationDescription)) {
					Logger.OAuth.Error("Rejecting access token request because the IAuthorizationServer.IsAuthorizationValid method returned false.");
					throw new TokenEndpointProtocolException(Protocol.AccessTokenRequestErrorCodes.InvalidGrant);
				}

				applied = true;
			}

			return applied ? (MessageProtections?)MessageProtections.None : null;
		}
	}
}
