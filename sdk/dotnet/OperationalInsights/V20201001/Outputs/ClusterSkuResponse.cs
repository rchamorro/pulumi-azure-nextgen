// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.OperationalInsights.V20201001.Outputs
{

    [OutputType]
    public sealed class ClusterSkuResponse
    {
        /// <summary>
        /// The capacity value
        /// </summary>
        public readonly double? Capacity;
        /// <summary>
        /// The name of the SKU.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private ClusterSkuResponse(
            double? capacity,

            string? name)
        {
            Capacity = capacity;
            Name = name;
        }
    }
}
