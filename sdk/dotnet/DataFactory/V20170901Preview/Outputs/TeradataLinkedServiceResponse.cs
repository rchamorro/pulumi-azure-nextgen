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
    public sealed class TeradataLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// AuthenticationType to be used for connection.
        /// </summary>
        public readonly string? AuthenticationType;
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
        /// Password for authentication.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// Server name for connection. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Server;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Username for authentication. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Username;

        [OutputConstructor]
        private TeradataLinkedServiceResponse(
            ImmutableArray<object> annotations,

            string? authenticationType,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? encryptedCredential,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            object server,

            string type,

            object? username)
        {
            Annotations = annotations;
            AuthenticationType = authenticationType;
            ConnectVia = connectVia;
            Description = description;
            EncryptedCredential = encryptedCredential;
            Parameters = parameters;
            Password = password;
            Server = server;
            Type = type;
            Username = username;
        }
    }
}
