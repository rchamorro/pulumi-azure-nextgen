// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// SSL profile of an application gateway.
    /// </summary>
    public sealed class ApplicationGatewaySslProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Client authentication configuration of the application gateway resource.
        /// </summary>
        [Input("clientAuthConfiguration")]
        public Input<Inputs.ApplicationGatewayClientAuthConfigurationArgs>? ClientAuthConfiguration { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the SSL profile that is unique within an Application Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// SSL policy of the application gateway resource.
        /// </summary>
        [Input("sslPolicy")]
        public Input<Inputs.ApplicationGatewaySslPolicyArgs>? SslPolicy { get; set; }

        [Input("trustedClientCertificates")]
        private InputList<Inputs.SubResourceArgs>? _trustedClientCertificates;

        /// <summary>
        /// Array of references to application gateway trusted client certificates.
        /// </summary>
        public InputList<Inputs.SubResourceArgs> TrustedClientCertificates
        {
            get => _trustedClientCertificates ?? (_trustedClientCertificates = new InputList<Inputs.SubResourceArgs>());
            set => _trustedClientCertificates = value;
        }

        public ApplicationGatewaySslProfileArgs()
        {
        }
    }
}
