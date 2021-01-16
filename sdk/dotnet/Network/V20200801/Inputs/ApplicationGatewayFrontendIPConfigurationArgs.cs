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
    /// Frontend IP configuration of an application gateway.
    /// </summary>
    public sealed class ApplicationGatewayFrontendIPConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the frontend IP configuration that is unique within an Application Gateway.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// PrivateIPAddress of the network interface IP Configuration.
        /// </summary>
        [Input("privateIPAddress")]
        public Input<string>? PrivateIPAddress { get; set; }

        /// <summary>
        /// The private IP address allocation method.
        /// </summary>
        [Input("privateIPAllocationMethod")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20200801.IPAllocationMethod>? PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Reference to the application gateway private link configuration.
        /// </summary>
        [Input("privateLinkConfiguration")]
        public Input<Inputs.SubResourceArgs>? PrivateLinkConfiguration { get; set; }

        /// <summary>
        /// Reference to the PublicIP resource.
        /// </summary>
        [Input("publicIPAddress")]
        public Input<Inputs.SubResourceArgs>? PublicIPAddress { get; set; }

        /// <summary>
        /// Reference to the subnet resource.
        /// </summary>
        [Input("subnet")]
        public Input<Inputs.SubResourceArgs>? Subnet { get; set; }

        public ApplicationGatewayFrontendIPConfigurationArgs()
        {
        }
    }
}
