// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801.Outputs
{

    [OutputType]
    public sealed class VpnLinkBgpSettingsResponse
    {
        /// <summary>
        /// The BGP speaker's ASN.
        /// </summary>
        public readonly double? Asn;
        /// <summary>
        /// The BGP peering address and BGP identifier of this BGP speaker.
        /// </summary>
        public readonly string? BgpPeeringAddress;

        [OutputConstructor]
        private VpnLinkBgpSettingsResponse(
            double? asn,

            string? bgpPeeringAddress)
        {
            Asn = asn;
            BgpPeeringAddress = bgpPeeringAddress;
        }
    }
}
