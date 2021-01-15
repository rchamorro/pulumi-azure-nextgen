// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20180930Preview.Inputs
{

    /// <summary>
    /// Represents the OpenShift networking configuration
    /// </summary>
    public sealed class NetworkProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// CIDR of the Vnet to peer.
        /// </summary>
        [Input("peerVnetId")]
        public Input<string>? PeerVnetId { get; set; }

        /// <summary>
        /// CIDR for the OpenShift Vnet.
        /// </summary>
        [Input("vnetCidr")]
        public Input<string>? VnetCidr { get; set; }

        public NetworkProfileArgs()
        {
            VnetCidr = "10.0.0.0/8";
        }
    }
}
