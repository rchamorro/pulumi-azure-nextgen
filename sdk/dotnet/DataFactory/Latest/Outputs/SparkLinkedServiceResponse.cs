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
    public sealed class SparkLinkedServiceResponse
    {
        /// <summary>
        /// Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false.
        /// </summary>
        public readonly object? AllowHostNameCNMismatch;
        /// <summary>
        /// Specifies whether to allow self-signed certificates from the server. The default value is false.
        /// </summary>
        public readonly object? AllowSelfSignedServerCert;
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The authentication method used to access the Spark server.
        /// </summary>
        public readonly string AuthenticationType;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Specifies whether the connections to the server are encrypted using SSL. The default value is false.
        /// </summary>
        public readonly object? EnableSsl;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// IP address or host name of the Spark server
        /// </summary>
        public readonly object Host;
        /// <summary>
        /// The partial URL corresponding to the Spark server.
        /// </summary>
        public readonly object? HttpPath;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// The password corresponding to the user name that you provided in the Username field
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// The TCP port that the Spark server uses to listen for client connections.
        /// </summary>
        public readonly object Port;
        /// <summary>
        /// The type of Spark server.
        /// </summary>
        public readonly string? ServerType;
        /// <summary>
        /// The transport protocol to use in the Thrift layer.
        /// </summary>
        public readonly string? ThriftTransportProtocol;
        /// <summary>
        /// The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR.
        /// </summary>
        public readonly object? TrustedCertPath;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false.
        /// </summary>
        public readonly object? UseSystemTrustStore;
        /// <summary>
        /// The user name that you use to access Spark Server.
        /// </summary>
        public readonly object? Username;

        [OutputConstructor]
        private SparkLinkedServiceResponse(
            object? allowHostNameCNMismatch,

            object? allowSelfSignedServerCert,

            ImmutableArray<object> annotations,

            string authenticationType,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? enableSsl,

            object? encryptedCredential,

            object host,

            object? httpPath,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            object port,

            string? serverType,

            string? thriftTransportProtocol,

            object? trustedCertPath,

            string type,

            object? useSystemTrustStore,

            object? username)
        {
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            Annotations = annotations;
            AuthenticationType = authenticationType;
            ConnectVia = connectVia;
            Description = description;
            EnableSsl = enableSsl;
            EncryptedCredential = encryptedCredential;
            Host = host;
            HttpPath = httpPath;
            Parameters = parameters;
            Password = password;
            Port = port;
            ServerType = serverType;
            ThriftTransportProtocol = thriftTransportProtocol;
            TrustedCertPath = trustedCertPath;
            Type = type;
            UseSystemTrustStore = useSystemTrustStore;
            Username = username;
        }
    }
}
