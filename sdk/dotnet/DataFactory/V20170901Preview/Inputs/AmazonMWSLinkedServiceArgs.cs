// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Amazon Marketplace Web Service linked service.
    /// </summary>
    public sealed class AmazonMWSLinkedServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access key id used to access data.
        /// </summary>
        [Input("accessKeyId", required: true)]
        public Input<object> AccessKeyId { get; set; } = null!;

        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Dataset.
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
        /// The endpoint of the Amazon MWS server, (i.e. mws.amazonservices.com)
        /// </summary>
        [Input("endpoint", required: true)]
        public Input<object> Endpoint { get; set; } = null!;

        /// <summary>
        /// The Amazon Marketplace ID you want to retrieve data from. To retrieve data from multiple Marketplace IDs, separate them with a comma (,). (i.e. A2EUQ1WTGCTBG2)
        /// </summary>
        [Input("marketplaceID", required: true)]
        public Input<object> MarketplaceID { get; set; } = null!;

        /// <summary>
        /// The Amazon MWS authentication token.
        /// </summary>
        [Input("mwsAuthToken")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? MwsAuthToken { get; set; }

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
        /// The secret key used to access data.
        /// </summary>
        [Input("secretKey")]
        public InputUnion<Inputs.AzureKeyVaultSecretReferenceArgs, Inputs.SecureStringArgs>? SecretKey { get; set; }

        /// <summary>
        /// The Amazon seller ID.
        /// </summary>
        [Input("sellerID", required: true)]
        public Input<object> SellerID { get; set; } = null!;

        /// <summary>
        /// Type of linked service.
        /// Expected value is 'AmazonMWS'.
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

        public AmazonMWSLinkedServiceArgs()
        {
        }
    }
}
