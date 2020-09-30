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
    public sealed class AzureMLServiceLinkedServiceResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the linked service.
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
        /// Azure ML Service workspace name. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object MlWorkspaceName;
        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Azure ML Service workspace resource group name. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object ResourceGroupName;
        /// <summary>
        /// The ID of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ServicePrincipalId;
        /// <summary>
        /// The key of the service principal used to authenticate against the endpoint of a published Azure ML Service pipeline.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? ServicePrincipalKey;
        /// <summary>
        /// Azure ML Service workspace subscription ID. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object SubscriptionId;
        /// <summary>
        /// The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Tenant;
        /// <summary>
        /// Type of linked service.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureMLServiceLinkedServiceResponse(
            ImmutableArray<object> annotations,

            Outputs.IntegrationRuntimeReferenceResponse? connectVia,

            string? description,

            object? encryptedCredential,

            object mlWorkspaceName,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object resourceGroupName,

            object? servicePrincipalId,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse>? servicePrincipalKey,

            object subscriptionId,

            object? tenant,

            string type)
        {
            Annotations = annotations;
            ConnectVia = connectVia;
            Description = description;
            EncryptedCredential = encryptedCredential;
            MlWorkspaceName = mlWorkspaceName;
            Parameters = parameters;
            ResourceGroupName = resourceGroupName;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            SubscriptionId = subscriptionId;
            Tenant = tenant;
            Type = type;
        }
    }
}
