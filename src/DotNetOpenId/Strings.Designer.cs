﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenId {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenId.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An attribute with type URI &apos;{0}&apos; has already been added..
        /// </summary>
        internal static string AttributeAlreadyAdded {
            get {
                return ResourceManager.GetString("AttributeAlreadyAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only {0} values for attribute &apos;{1}&apos; were requested, but {2} were supplied..
        /// </summary>
        internal static string AttributeTooManyValues {
            get {
                return ResourceManager.GetString("AttributeTooManyValues", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The private data supplied does not meet the requirements of any known Association type.  Its length may be too short, or it may have been corrupted..
        /// </summary>
        internal static string BadAssociationPrivateData {
            get {
                return ResourceManager.GetString("BadAssociationPrivateData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ClaimedIdentifier property must be set first..
        /// </summary>
        internal static string ClaimedIdentifierMustBeSetFirst {
            get {
                return ResourceManager.GetString("ClaimedIdentifierMustBeSetFirst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An authentication request has already been created using CreateRequest()..
        /// </summary>
        internal static string CreateRequestAlreadyCalled {
            get {
                return ResourceManager.GetString("CreateRequestAlreadyCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HttpContext.Current is null.  There must be an ASP.NET request in process for this operation to succeed..
        /// </summary>
        internal static string CurrentHttpContextRequired {
            get {
                return ResourceManager.GetString("CurrentHttpContextRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An encrypted session using either HTTPS or Diffie-Hellman is required when establishing associations between relying parties and providers..
        /// </summary>
        internal static string EncryptionRequired {
            get {
                return ResourceManager.GetString("EncryptionRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; was expected to be base64 encoded but is not..
        /// </summary>
        internal static string ExpectedBase64OpenIdQueryParameter {
            get {
                return ResourceManager.GetString("ExpectedBase64OpenIdQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nonce has expired..
        /// </summary>
        internal static string ExpiredNonce {
            get {
                return ResourceManager.GetString("ExpiredNonce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An extension sharing namespace &apos;{0}&apos; has already been added.  Only one extension per namespace is allowed in a given request..
        /// </summary>
        internal static string ExtensionAlreadyAddedWithSameTypeURI {
            get {
                return ResourceManager.GetString("ExtensionAlreadyAddedWithSameTypeURI", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Extension parameter key &apos;{0}&apos; encountered, but extension parameter keys should not include their prefix..
        /// </summary>
        internal static string ExtensionParameterKeysWithoutPrefixExpected {
            get {
                return ResourceManager.GetString("ExtensionParameterKeysWithoutPrefixExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenID parameter &apos;{0}&apos; must be signed by the OpenID Provider, but was not..
        /// </summary>
        internal static string FieldMustBeSigned {
            get {
                return ResourceManager.GetString("FieldMustBeSigned", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fragment segments do not apply to XRI identifiers..
        /// </summary>
        internal static string FragmentNotAllowedOnXRIs {
            get {
                return ResourceManager.GetString("FragmentNotAllowedOnXRIs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current ASP.NET HttpContext was detected.  Use an overload that does not require one..
        /// </summary>
        internal static string HttpContextRequiredForThisOverload {
            get {
                return ResourceManager.GetString("HttpContextRequiredForThisOverload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No current HttpContext was detected, so an IAssociationStore must be explicitly provided. Call the Server constructor overload that takes an IAssociationStore..
        /// </summary>
        internal static string IAssociationStoreRequiredWhenNoHttpContextAvailable {
            get {
                return ResourceManager.GetString("IAssociationStoreRequiredWhenNoHttpContextAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is only allowed when IsIdentifierSelect is true..
        /// </summary>
        internal static string IdentifierSelectModeOnly {
            get {
                return ResourceManager.GetString("IdentifierSelectModeOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClaimedIdentifier and LocalIdentifier must be the same when IsIdentifierSelect is true..
        /// </summary>
        internal static string IdentifierSelectRequiresMatchingIdentifiers {
            get {
                return ResourceManager.GetString("IdentifierSelectRequiresMatchingIdentifiers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot encode &apos;{0}&apos; because it contains an illegal character for Key-Value Form encoding.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidCharacterInKeyValueFormInput {
            get {
                return ResourceManager.GetString("InvalidCharacterInKeyValueFormInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot decode Key-Value Form because a line was found without a &apos;{0}&apos; character.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidKeyValueFormCharacterMissing {
            get {
                return ResourceManager.GetString("InvalidKeyValueFormCharacterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nonce was not in the expected format..
        /// </summary>
        internal static string InvalidNonce {
            get {
                return ResourceManager.GetString("InvalidNonce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID extension {0} parameter {1} had unexpected value &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidOpenIdExtensionParameterValue {
            get {
                return ResourceManager.GetString("InvalidOpenIdExtensionParameterValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; had unexpected value &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidOpenIdQueryParameterValue {
            get {
                return ResourceManager.GetString("InvalidOpenIdQueryParameterValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; with value &apos;{1}&apos; failed to base64 decode..
        /// </summary>
        internal static string InvalidOpenIdQueryParameterValueBadBase64 {
            get {
                return ResourceManager.GetString("InvalidOpenIdQueryParameterValueBadBase64", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scheme must be http or https but was &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidScheme {
            get {
                return ResourceManager.GetString("InvalidScheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The signature verification failed..
        /// </summary>
        internal static string InvalidSignature {
            get {
                return ResourceManager.GetString("InvalidSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid URI..
        /// </summary>
        internal static string InvalidUri {
            get {
                return ResourceManager.GetString("InvalidUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failure parsing XRDS document..
        /// </summary>
        internal static string InvalidXRDSDocument {
            get {
                return ResourceManager.GetString("InvalidXRDSDocument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not a recognized XRI format: &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidXri {
            get {
                return ResourceManager.GetString("InvalidXri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenId Provider issued an assertion for an Identifier whose discovery information did not match..
        /// </summary>
        internal static string IssuedAssertionFailsIdentifierDiscovery {
            get {
                return ResourceManager.GetString("IssuedAssertionFailsIdentifierDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given key &apos;{0}&apos; already exists..
        /// </summary>
        internal static string KeyAlreadyExists {
            get {
                return ResourceManager.GetString("KeyAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list of keys do not match the provided dictionary..
        /// </summary>
        internal static string KeysListAndDictionaryDoNotMatch {
            get {
                return ResourceManager.GetString("KeysListAndDictionaryDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; and &apos;{1}&apos; parameters must both be or not be &apos;{2}&apos;..
        /// </summary>
        internal static string MatchingArgumentsExpected {
            get {
                return ResourceManager.GetString("MatchingArgumentsExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The XRDS document for XRI {0} is missing the required CanonicalID element..
        /// </summary>
        internal static string MissingCanonicalIDElement {
            get {
                return ResourceManager.GetString("MissingCanonicalIDElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query parameter &apos;{0}&apos; was missing from the query..
        /// </summary>
        internal static string MissingInternalQueryParameter {
            get {
                return ResourceManager.GetString("MissingInternalQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenID parameter &apos;{0}&apos; was missing from the query..
        /// </summary>
        internal static string MissingOpenIdQueryParameter {
            get {
                return ResourceManager.GetString("MissingOpenIdQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query parameter &apos;{0}&apos; was expected in the return_to query &apos;{1}&apos;..
        /// </summary>
        internal static string MissingReturnToQueryParameter {
            get {
                return ResourceManager.GetString("MissingReturnToQueryParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No XRDS document containing OpenId relying party endpoint information could be found at {0}..
        /// </summary>
        internal static string NoRelyingPartyEndpointDiscovered {
            get {
                return ResourceManager.GetString("NoRelyingPartyEndpointDiscovered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OpenId endpoint found..
        /// </summary>
        internal static string OpenIdEndpointNotFound {
            get {
                return ResourceManager.GetString("OpenIdEndpointNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OpenId url is provided..
        /// </summary>
        internal static string OpenIdTextBoxEmpty {
            get {
                return ResourceManager.GetString("OpenIdTextBoxEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Prefix should not begin or end with a period..
        /// </summary>
        internal static string PrefixWithoutPeriodsExpected {
            get {
                return ResourceManager.GetString("PrefixWithoutPeriodsExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to determine provider&apos;s OpenID version..
        /// </summary>
        internal static string ProviderOpenIdVersionUnknown {
            get {
                return ResourceManager.GetString("ProviderOpenIdVersionUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenId Provider responded with an error: &apos;{0}&apos;..
        /// </summary>
        internal static string ProviderRespondedWithError {
            get {
                return ResourceManager.GetString("ProviderRespondedWithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OpenId Provider responded with unrecognized HTTP status code {0}..
        /// </summary>
        internal static string ProviderRespondedWithUnrecognizedHTTPStatusCode {
            get {
                return ResourceManager.GetString("ProviderRespondedWithUnrecognizedHTTPStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An HTTP request to the realm URL ({0}) resulted in a redirect, which is not allowed during relying party discovery..
        /// </summary>
        internal static string RealmCausedRedirectUponDiscovery {
            get {
                return ResourceManager.GetString("RealmCausedRedirectUponDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The nonce has already been used..
        /// </summary>
        internal static string ReplayAttackDetected {
            get {
                return ResourceManager.GetString("ReplayAttackDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OpenId provider&apos;s response is not ready.  Use IsResponseReady to check, and fill in the required properties first..
        /// </summary>
        internal static string ResponseNotReady {
            get {
                return ResourceManager.GetString("ResponseNotReady", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter does not have the same value for return_to (&apos;{1}&apos;) and the regular query (&apos;{2}&apos;)..
        /// </summary>
        internal static string ReturnToArgDifferentFromQueryArg {
            get {
                return ResourceManager.GetString("ReturnToArgDifferentFromQueryArg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to return_to &apos;{0}&apos; not under realm &apos;{1}&apos;..
        /// </summary>
        internal static string ReturnToNotUnderRealm {
            get {
                return ResourceManager.GetString("ReturnToNotUnderRealm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} parameter does not match the actual URL the request was made with..
        /// </summary>
        internal static string ReturnToParamDoesNotMatchRequestUrl {
            get {
                return ResourceManager.GetString("ReturnToParamDoesNotMatchRequestUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; parameter was expected to have the value &apos;{1}&apos; but had &apos;{2}&apos; instead..
        /// </summary>
        internal static string TamperingDetected {
            get {
                return ResourceManager.GetString("TamperingDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type must implement {0}..
        /// </summary>
        internal static string TypeMustImplementX {
            get {
                return ResourceManager.GetString("TypeMustImplementX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The URL &apos;{0}&apos; is rated unsafe and cannot be requested this way..
        /// </summary>
        internal static string UnsafeWebRequestDetected {
            get {
                return ResourceManager.GetString("UnsafeWebRequestDetected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Providing a DateTime whose Kind is Unspecified is not allowed..
        /// </summary>
        internal static string UnspecifiedDateTimeKindNotAllowed {
            get {
                return ResourceManager.GetString("UnspecifiedDateTimeKindNotAllowed", resourceCulture);
            }
        }
    }
}
