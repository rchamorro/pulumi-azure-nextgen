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
    /// Shopify Service linked service.
    /// </summary>
    public sealed class ShopifyLinkedServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The API access token that can be used to access Shopify’s data. The token won't expire if it is offline mode.
        /// </summary>
        [Input("accessToken")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? AccessToken { get; set; }

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
        /// The endpoint of the Shopify server. (i.e. mystore.myshopify.com)
        /// </summary>
        [Input("host", required: true)]
        public Input<object> Host { get; set; } = null!;

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
        /// Type of linked service.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true.
        /// </summary>
        [Input("useEncryptedEndpoints")]
        public Input<object>? UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Specifies whether to require the host name in the server's certificate to match the host name of the server when connecting over SSL. The default value is true.
        /// </summary>
        [Input("useHostVerification")]
        public Input<object>? UseHostVerification { get; set; }

        /// <summary>
        /// Specifies whether to verify the identity of the server when connecting over SSL. The default value is true.
        /// </summary>
        [Input("usePeerVerification")]
        public Input<object>? UsePeerVerification { get; set; }

        public ShopifyLinkedServiceArgs()
        {
        }
    }
}
