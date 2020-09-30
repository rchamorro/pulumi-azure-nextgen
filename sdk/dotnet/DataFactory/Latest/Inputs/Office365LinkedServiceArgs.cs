// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// Office365 linked service.
    /// </summary>
    public sealed class Office365LinkedServiceArgs : Pulumi.ResourceArgs
    {
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
        /// Linked service description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("encryptedCredential")]
        public Input<object>? EncryptedCredential { get; set; }

        /// <summary>
        /// Azure tenant ID to which the Office 365 account belongs. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("office365TenantId", required: true)]
        public Input<object> Office365TenantId { get; set; } = null!;

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
        /// Specify the application's client ID. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("servicePrincipalId", required: true)]
        public Input<object> ServicePrincipalId { get; set; } = null!;

        /// <summary>
        /// Specify the application's key.
        /// </summary>
        [Input("servicePrincipalKey", required: true)]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs> ServicePrincipalKey { get; set; } = null!;

        /// <summary>
        /// Specify the tenant information under which your Azure AD web application resides. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("servicePrincipalTenantId", required: true)]
        public Input<object> ServicePrincipalTenantId { get; set; } = null!;

        /// <summary>
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public Office365LinkedServiceArgs()
        {
        }
    }
}
