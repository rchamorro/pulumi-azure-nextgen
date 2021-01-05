// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190901.Inputs
{

    /// <summary>
    /// BGP settings details.
    /// </summary>
    public sealed class BgpSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The BGP speaker's ASN.
        /// </summary>
        [Input("asn")]
        public Input<double>? Asn { get; set; }

        /// <summary>
        /// The BGP peering address and BGP identifier of this BGP speaker.
        /// </summary>
        [Input("bgpPeeringAddress")]
        public Input<string>? BgpPeeringAddress { get; set; }

        /// <summary>
        /// The weight added to routes learned from this BGP speaker.
        /// </summary>
        [Input("peerWeight")]
        public Input<int>? PeerWeight { get; set; }

        public BgpSettingsArgs()
        {
        }
    }
}
