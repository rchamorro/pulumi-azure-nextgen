// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class QuickBooksLinkedServiceResponse
    {
        /// <summary>
        /// The access token for OAuth 1.0 authentication.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? AccessToken;
        /// <summary>
        /// The access token secret for OAuth 1.0 authentication.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? AccessTokenSecret;
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The company ID of the QuickBooks company to authorize.
        /// </summary>
        public readonly object? CompanyId;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// Properties used to connect to QuickBooks. It is mutually exclusive with any other properties in the linked service. Type: object.
        /// </summary>
        public readonly object? ConnectionProperties;
        /// <summary>
        /// The consumer key for OAuth 1.0 authentication.
        /// </summary>
        public readonly object? ConsumerKey;
        /// <summary>
        /// The consumer secret for OAuth 1.0 authentication.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? ConsumerSecret;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com)
        /// </summary>
        public readonly object? Endpoint;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true.
        /// </summary>
        public readonly object? UseEncryptedEndpoints;

        [OutputConstructor]
        private QuickBooksLinkedServiceResponse(
            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? accessToken,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? accessTokenSecret,

            ImmutableArray<object> annotations,

            object? companyId,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            object? connectionProperties,

            object? consumerKey,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? consumerSecret,

            string? description,

            object? encryptedCredential,

            object? endpoint,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            string type,

            object? useEncryptedEndpoints)
        {
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
            Annotations = annotations;
            CompanyId = companyId;
            ConnectVia = connectVia;
            ConnectionProperties = connectionProperties;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            Description = description;
            EncryptedCredential = encryptedCredential;
            Endpoint = endpoint;
            Parameters = parameters;
            Type = type;
            UseEncryptedEndpoints = useEncryptedEndpoints;
        }
    }
}
