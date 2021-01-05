// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20160330.Outputs
{

    [OutputType]
    public sealed class BgpSettingsResponse
    {
        /// <summary>
        /// Gets or sets this BGP speaker's ASN
        /// </summary>
        public readonly double? Asn;
        /// <summary>
        /// Gets or sets the BGP peering address and BGP identifier of this BGP speaker
        /// </summary>
        public readonly string? BgpPeeringAddress;
        /// <summary>
        /// Gets or sets the weight added to routes learned from this BGP speaker
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
