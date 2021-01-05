// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601.Outputs
{

    [OutputType]
    public sealed class BgpSettingsResponse
    {
        /// <summary>
        /// The BGP speaker's ASN.
        /// </summary>
        public readonly double? Asn;
        /// <summary>
        /// The BGP peering address and BGP identifier of this BGP speaker.
        /// </summary>
        public readonly string? BgpPeeringAddress;
        /// <summary>
        /// The weight added to routes learned from this BGP speaker.
        /// </summary>
        public readonly int? PeerWeight;

        [OutputConstructor]
        private BgpSettingsResponse(
            double? asn,

            string? bgpPeeringAddress,

            int? peerWeight)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
            PeerWeight = peerWeight;
        }
    }
}
