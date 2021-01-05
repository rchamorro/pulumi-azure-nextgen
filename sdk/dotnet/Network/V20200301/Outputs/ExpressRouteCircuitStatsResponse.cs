// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200301.Outputs
{

    [OutputType]
    public sealed class ExpressRouteCircuitStatsResponse
    {
        /// <summary>
        /// The Primary BytesIn of the peering.
        /// </summary>
        public readonly double? PrimarybytesIn;
        /// <summary>
        /// The primary BytesOut of the peering.
        /// </summary>
        public readonly double? PrimarybytesOut;
        /// <summary>
        /// The secondary BytesIn of the peering.
        /// </summary>
        public readonly double? SecondarybytesIn;
        /// <summary>
        /// The secondary BytesOut of the peering.
        /// </summary>
        public readonly double? SecondarybytesOut;

        [OutputConstructor]
        private ExpressRouteCircuitStatsResponse(
            double? primarybytesIn,

            double? primarybytesOut,

            double? secondarybytesIn,

            double? secondarybytesOut)
        {
            PrimarybytesIn = primarybytesIn;
            PrimarybytesOut = primarybytesOut;
            SecondarybytesIn = secondarybytesIn;
            SecondarybytesOut = secondarybytesOut;
        }
    }
}
