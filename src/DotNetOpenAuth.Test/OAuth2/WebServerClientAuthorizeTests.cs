﻿//-----------------------------------------------------------------------
// <copyright file="WebServerClientAuthorizeTests.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.Test.OAuth2 {
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OAuth2;
	using DotNetOpenAuth.OAuth2.ChannelElements;
	using DotNetOpenAuth.OAuth2.Messages;
	using Moq;
	using NUnit.Framework;

	[TestFixture]
	public class WebServerClientAuthorizeTests : OAuth2TestBase {
		[Test]
		public void AuthorizationCodeGrant() {
			var coordinator = new OAuth2Coordinator<WebServerClient>(
				AuthorizationServerDescription,
				AuthorizationServerMock,
				new WebServerClient(AuthorizationServerDescription),
				client => {
					var authState = new AuthorizationState(TestScopes) {
						Callback = ClientCallback,
					};
					client.PrepareRequestUserAuthorization(authState).Respond();
					var result = client.ProcessUserAuthorization();
					Assert.That(result.AccessToken, Is.Not.Null.And.Not.Empty);
					Assert.That(result.RefreshToken, Is.Not.Null.And.Not.Empty);
				},
				server => {
					var request = server.ReadAuthorizationRequest();
					Assert.That(request, Is.Not.Null);
					server.ApproveAuthorizationRequest(request, ResourceOwnerUsername);
					server.HandleTokenRequest().Respond();
				});
			coordinator.Run();
		}

		[Test]
		public void ResourceOwnerPasswordCredentialGrant() {
			var coordinator = new OAuth2Coordinator<WebServerClient>(
				AuthorizationServerDescription,
				AuthorizationServerMock,
				new WebServerClient(AuthorizationServerDescription),
				client => {
					var authState = client.ExchangeUserCredentialForToken(ResourceOwnerUsername, ResourceOwnerPassword, TestScopes);
					Assert.That(authState.AccessToken, Is.Not.Null.And.Not.Empty);
					Assert.That(authState.RefreshToken, Is.Not.Null.And.Not.Empty);
				},
				server => {
					server.HandleTokenRequest().Respond();
				});
			coordinator.Run();
		}

		[Test]
		public void ClientCredentialGrant() {
			var authServer = CreateAuthorizationServerMock();
			authServer.Setup(
				a => a.IsAuthorizationValid(It.Is<IAuthorizationDescription>(d => d.User == null && d.ClientIdentifier == ClientId && MessagingUtilities.AreEquivalent(d.Scope, TestScopes))))
				.Returns(true);
			var coordinator = new OAuth2Coordinator<WebServerClient>(
				AuthorizationServerDescription,
				authServer.Object,
				new WebServerClient(AuthorizationServerDescription),
				client => {
					var authState = client.GetClientAccessToken(TestScopes);
					Assert.That(authState.AccessToken, Is.Not.Null.And.Not.Empty);
					Assert.That(authState.RefreshToken, Is.Null);
				},
				server => {
					server.HandleTokenRequest().Respond();
				});
			coordinator.Run();
		}
	}
}
