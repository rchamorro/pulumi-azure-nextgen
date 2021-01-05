// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Inputs
{

    /// <summary>
    /// Contains stats associated with the peering.
    /// </summary>
    public sealed class ExpressRouteCircuitStatsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Primary BytesIn of the peering.
        /// </summary>
        [Input("primarybytesIn")]
        public Input<double>? PrimarybytesIn { get; set; }

        /// <summary>
        /// The primary BytesOut of the peering.
        /// </summary>
        [Input("primarybytesOut")]
        public Input<double>? PrimarybytesOut { get; set; }

        /// <summary>
        /// The secondary BytesIn of the peering.
        /// </summary>
        [Input("secondarybytesIn")]
        public Input<double>? SecondarybytesIn { get; set; }

        /// <summary>
        /// The secondary BytesOut of the peering.
        /// </summary>
        [Input("secondarybytesOut")]
        public Input<double>? SecondarybytesOut { get; set; }

        public ExpressRouteCircuitStatsArgs()
        {
        }
    }
}
