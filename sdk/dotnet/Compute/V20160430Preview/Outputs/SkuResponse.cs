// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20160430Preview.Outputs
{

    [OutputType]
    public sealed class SkuResponse
    {
        /// <summary>
        /// Specifies the number of virtual machines in the scale set.
        /// </summary>
        public readonly double? Capacity;
        /// <summary>
        /// The sku name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Specifies the tier of virtual machines in a scale set.&lt;br /&gt;&lt;br /&gt; Possible Values:&lt;br /&gt;&lt;br /&gt; **Standard**&lt;br /&gt;&lt;br /&gt; **Basic**
        /// </summary>
        public readonly string? Tier;

        [OutputConstructor]
        private SkuResponse(
            double? capacity,

            string? name,

            string? tier)
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }
    }
}
