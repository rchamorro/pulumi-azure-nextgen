// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AnalysisServices.V20160516.Inputs
{

    /// <summary>
    /// Represents the SKU name and Azure pricing tier for Analysis Services resource.
    /// </summary>
    public sealed class ResourceSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of instances in the read only query pool.
        /// </summary>
        [Input("capacity")]
        public Input<int>? Capacity { get; set; }

        /// <summary>
        /// Name of the SKU level.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Azure pricing tier to which the SKU applies.
        /// </summary>
        [Input("tier")]
        public InputUnion<string, Pulumi.AzureNextGen.AnalysisServices.V20160516.SkuTier>? Tier { get; set; }

        public ResourceSkuArgs()
        {
            Capacity = 1;
        }
    }
}
