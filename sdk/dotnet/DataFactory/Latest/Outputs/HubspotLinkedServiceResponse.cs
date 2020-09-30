// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class HubspotLinkedServiceResponse
    {
        /// <summary>
        /// The access token obtained when initially authenticating your OAuth integration.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? AccessToken;
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The client ID associated with your Hubspot application.
        /// </summary>
        public readonly object ClientId;
        /// <summary>
        /// The client secret associated with your Hubspot application.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? ClientSecret;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// The refresh token obtained when initially authenticating your OAuth integration.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? RefreshToken;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true.
        /// </summary>
        public readonly object? UseEncryptedEndpoints;
        /// <summary>
        /// Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true.
        /// </summary>
        public readonly object? UseHostVerification;
        /// <summary>
        /// Specifies whether to verify the identity of the server when connecting over SSL. The default value is true.
        /// </summary>
        public readonly object? UsePeerVerification;

        [OutputConstructor]
        private HubspotLinkedServiceResponse(
            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? accessToken,

            ImmutableArray<object> annotations,

            object clientId,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? clientSecret,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? encryptedCredential,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? refreshToken,

            string type,

            object? useEncryptedEndpoints,

            object? useHostVerification,

            object? usePeerVerification)
        {
            AccessToken = accessToken;
            Annotations = annotations;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ConnectVia = connectVia;
            Description = description;
            EncryptedCredential = encryptedCredential;
            Parameters = parameters;
            RefreshToken = refreshToken;
            Type = type;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
        }
    }
}
