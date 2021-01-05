// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Outputs
{

    [OutputType]
    public sealed class VpnClientConnectionHealthResponse
    {
        /// <summary>
        /// List of allocated ip addresses to the connected p2s vpn clients.
        /// </summary>
        public readonly ImmutableArray<string> AllocatedIpAddresses;
        /// <summary>
        /// Total of the Egress Bytes Transferred in this connection.
        /// </summary>
        public readonly double TotalEgressBytesTransferred;
        /// <summary>
        /// Total of the Ingress Bytes Transferred in this P2S Vpn connection.
        /// </summary>
        public readonly double TotalIngressBytesTransferred;
        /// <summary>
        /// The total of p2s vpn clients connected at this time to this P2SVpnGateway.
        /// </summary>
        public readonly int? VpnClientConnectionsCount;

        [OutputConstructor]
        private VpnClientConnectionHealthResponse(
            ImmutableArray<string> allocatedIpAddresses,

            double totalEgressBytesTransferred,

            double totalIngressBytesTransferred,

            int? vpnClientConnectionsCount)
        {
            AllocatedIpAddresses = allocatedIpAddresses;
            TotalEgressBytesTransferred = totalEgressBytesTransferred;
            TotalIngressBytesTransferred = totalIngressBytesTransferred;
            VpnClientConnectionsCount = vpnClientConnectionsCount;
        }
    }
}
