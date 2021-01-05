// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190601.Inputs
{

    /// <summary>
    /// BGP settings details for a link.
    /// </summary>
    public sealed class VpnLinkBgpSettingsArgs : Pulumi.ResourceArgs
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

        public VpnLinkBgpSettingsArgs()
        {
        }
    }
}
