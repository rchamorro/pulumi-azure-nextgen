// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class FileServerLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
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
        /// Host name of the server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Host;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Password to logon the server.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User ID to logon the server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? UserId;

        [OutputConstructor]
        private FileServerLinkedServiceResponse(
            ImmutableArray<object> annotations,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? encryptedCredential,

            object host,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            string type,

            object? userId)
        {
            Annotations = annotations;
            ConnectVia = connectVia;
            Description = description;
            EncryptedCredential = encryptedCredential;
            Host = host;
            Parameters = parameters;
            Password = password;
            Type = type;
            UserId = userId;
        }
    }
}
