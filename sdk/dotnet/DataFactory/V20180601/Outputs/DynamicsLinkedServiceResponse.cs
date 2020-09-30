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
    public sealed class DynamicsLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The authentication type to connect to Dynamics server. 'Office365' for online scenario, 'Ifd' for on-premises with Ifd scenario, 'AADServicePrincipal' for Server-To-Server authentication in online scenario. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly string AuthenticationType;
        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        public readonly Outputs.IntegrationRuntimeReferenceResponse? ConnectVia;
        /// <summary>
        /// The deployment type of the Dynamics instance. 'Online' for Dynamics Online and 'OnPremisesWithIfd' for Dynamics on-premises with Ifd. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly string DeploymentType;
        /// <summary>
        /// Linked service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncryptedCredential;
        /// <summary>
        /// The host name of the on-premises Dynamics server. The property is required for on-prem and not allowed for online. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? HostName;
        /// <summary>
        /// The organization name of the Dynamics instance. The property is required for on-prem and required for online when there are more than one Dynamics instances associated with the user. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? OrganizationName;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Password to access the Dynamics instance.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? Password;
        /// <summary>
        /// The port of on-premises Dynamics server. The property is required for on-prem and not allowed for online. Default is 443. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        public readonly object? Port;
        /// <summary>
        /// The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? ServicePrincipalCredential;
        /// <summary>
        /// The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly string? ServicePrincipalCredentialType;
        /// <summary>
        /// The client ID of the application in Azure Active Directory used for Server-To-Server authentication. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ServicePrincipalId;
        /// <summary>
        /// The URL to the Microsoft Dynamics server. The property is required for on-line and not allowed for on-prem. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ServiceUri;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// User name to access the Dynamics instance. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Username;

        [OutputConstructor]
        private DynamicsLinkedServiceResponse(
            ImmutableArray<object> annotations,

            string authenticationType,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string deploymentType,

            string? description,

            object? encryptedCredential,

            object? hostName,

            object? organizationName,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? password,

            object? port,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? servicePrincipalCredential,

            string? servicePrincipalCredentialType,

            object? servicePrincipalId,

            object? serviceUri,

            string type,

            object? username)
        {
            Annotations = annotations;
            AuthenticationType = authenticationType;
            ConnectVia = connectVia;
            DeploymentType = deploymentType;
            Description = description;
            EncryptedCredential = encryptedCredential;
            HostName = hostName;
            OrganizationName = organizationName;
            Parameters = parameters;
            Password = password;
            Port = port;
            ServicePrincipalCredential = servicePrincipalCredential;
            ServicePrincipalCredentialType = servicePrincipalCredentialType;
            ServicePrincipalId = servicePrincipalId;
            ServiceUri = serviceUri;
            Type = type;
            Username = username;
        }
    }
}
