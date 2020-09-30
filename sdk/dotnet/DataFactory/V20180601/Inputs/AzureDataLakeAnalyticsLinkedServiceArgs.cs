// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Azure Data Lake Analytics linked service.
    /// </summary>
    public sealed class AzureDataLakeAnalyticsLinkedServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Azure Data Lake Analytics account name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("accountName", required: true)]
        public Input<object> AccountName { get; set; } = null!;

        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the linked service.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// The integration runtime reference.
        /// </summary>
        [Input("connectVia")]
        public Input<Inputs.IntegrationRuntimeReferenceArgs>? ConnectVia { get; set; }

        /// <summary>
        /// Azure Data Lake Analytics URI Type: string (or Expression with resultType string).
        /// </summary>
        [Input("dataLakeAnalyticsUri")]
        public Input<object>? DataLakeAnalyticsUri { get; set; }

        /// <summary>
        /// Linked service description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("encryptedCredential")]
        public Input<object>? EncryptedCredential { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for linked service.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// Data Lake Analytics account resource group name (if different from Data Factory account). Type: string (or Expression with resultType string).
        /// </summary>
        [Input("resourceGroupName")]
        public Input<object>? ResourceGroupName { get; set; }

        /// <summary>
        /// The ID of the application used to authenticate against the Azure Data Lake Analytics account. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("servicePrincipalId")]
        public Input<object>? ServicePrincipalId { get; set; }

        /// <summary>
        /// The Key of the application used to authenticate against the Azure Data Lake Analytics account.
        /// </summary>
        [Input("servicePrincipalKey")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? ServicePrincipalKey { get; set; }

        /// <summary>
        /// Data Lake Analytics account subscription ID (if different from Data Factory account). Type: string (or Expression with resultType string).
        /// </summary>
        [Input("subscriptionId")]
        public Input<object>? SubscriptionId { get; set; }

        /// <summary>
        /// The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("tenant", required: true)]
        public Input<object> Tenant { get; set; } = null!;

        /// <summary>
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureDataLakeAnalyticsLinkedServiceArgs()
        {
        }
    }
}
