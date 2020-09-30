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
    public sealed class SapTableLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// Client ID of the client on the SAP system where the table is located. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ClientId;
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
        /// Language of the SAP system where the table is located. The default value is EN. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Language;
        /// <summary>
        /// The Logon Group for the SAP System. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? LogonGroup;
        /// <summary>
        /// The hostname of the SAP Message Server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? MessageServer;
        /// <summary>
        /// The service name or port number of the Message Server. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? MessageServerService;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Password to access the SAP server where the table is located.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// Host name of the SAP instance where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Server;
        /// <summary>
        /// External security product's library to access the SAP server where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SncLibraryPath;
        /// <summary>
        /// SNC activation indicator to access the SAP server where the table is located. Must be either 0 (off) or 1 (on). Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SncMode;
        /// <summary>
        /// Initiator's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SncMyName;
        /// <summary>
        /// Communication partner's SNC name to access the SAP server where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SncPartnerName;
        /// <summary>
        /// SNC Quality of Protection. Allowed value include: 1, 2, 3, 8, 9. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SncQop;
        /// <summary>
        /// SystemID of the SAP system where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SystemId;
        /// <summary>
        /// System number of the SAP system where the table is located. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? SystemNumber;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Username to access the SAP server where the table is located. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? UserName;

        [OutputConstructor]
        private SapTableLinkedServiceResponse(
            ImmutableArray<object> annotations,

            object? clientId,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? encryptedCredential,

            object? language,

            object? logonGroup,

            object? messageServer,

            object? messageServerService,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            object? server,

            object? sncLibraryPath,

            object? sncMode,

            object? sncMyName,

            object? sncPartnerName,

            object? sncQop,

            object? systemId,

            object? systemNumber,

            string type,

            object? userName)
        {
            Annotations = annotations;
            ClientId = clientId;
            ConnectVia = connectVia;
            Description = description;
            EncryptedCredential = encryptedCredential;
            Language = language;
            LogonGroup = logonGroup;
            MessageServer = messageServer;
            MessageServerService = messageServerService;
            Parameters = parameters;
            Password = password;
            Server = server;
            SncLibraryPath = sncLibraryPath;
            SncMode = sncMode;
            SncMyName = sncMyName;
            SncPartnerName = sncPartnerName;
            SncQop = sncQop;
            SystemId = systemId;
            SystemNumber = systemNumber;
            Type = type;
            UserName = userName;
        }
    }
}
