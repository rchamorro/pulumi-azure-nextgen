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
    public sealed class AzureFileStorageLinkedServiceResponse
    {
        /// <summary>
        /// The Azure key vault secret reference of accountKey in connection string.
        /// </summary>
        public readonly Outputs.AzureKeyVaultSecretReferenceResponse? AccountKey;
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        public readonly object? ConnectionString;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// The azure file share name. It is required when auth with accountKey/sasToken. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileShare;
        /// <summary>
        /// Host name of the server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Host;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Password to logon the server.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// The Azure key vault secret reference of sasToken in sas uri.
        /// </summary>
        public readonly Outputs.AzureKeyVaultSecretReferenceResponse? SasToken;
        /// <summary>
        /// SAS URI of the Azure File resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        public readonly object? SasUri;
        /// <summary>
        /// The azure file share snapshot version. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Snapshot;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User ID to logon the server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? UserId;

        [OutputConstructor]
        private AzureFileStorageLinkedServiceResponse(
            Outputs.AzureKeyVaultSecretReferenceResponse? accountKey,

            ImmutableArray<object> annotations,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            object? connectionString,

            string? description,

            object? encryptedCredential,

            object? fileShare,

            object? host,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            Outputs.AzureKeyVaultSecretReferenceResponse? sasToken,

            object? sasUri,

            object? snapshot,

            string type,

            object? userId)
        {
            AccountKey = accountKey;
            Annotations = annotations;
            ConnectVia = connectVia;
            ConnectionString = connectionString;
            Description = description;
            EncryptedCredential = encryptedCredential;
            FileShare = fileShare;
            Host = host;
            Parameters = parameters;
            Password = password;
            SasToken = sasToken;
            SasUri = sasUri;
            Snapshot = snapshot;
            Type = type;
            UserId = userId;
        }
    }
}
