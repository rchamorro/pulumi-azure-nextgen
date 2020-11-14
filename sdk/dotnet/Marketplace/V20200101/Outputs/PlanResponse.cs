// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Marketplace.V20200101.Outputs
{

    [OutputType]
    public sealed class PlanResponse
    {
        /// <summary>
        /// Plan accessibility
        /// </summary>
        public readonly string? Accessibility;
        /// <summary>
        /// Alternative stack type
        /// </summary>
        public readonly string AltStackReference;
        /// <summary>
        /// Friendly name for the plan for display in the marketplace
        /// </summary>
        public readonly string PlanDisplayName;
        /// <summary>
        /// Text identifier for this plan
        /// </summary>
        public readonly string PlanId;
        /// <summary>
        /// Identifier for this plan
        /// </summary>
        public readonly string SkuId;
        /// <summary>
        /// Stack type (classic or arm)
        /// </summary>
        public readonly string StackType;

        [OutputConstructor]
        private PlanResponse(
            string? accessibility,

            string altStackReference,

            string planDisplayName,

            string planId,

            string skuId,

            string stackType)
        {
            Accessibility = accessibility;
            AltStackReference = altStackReference;
            PlanDisplayName = planDisplayName;
            PlanId = planId;
            SkuId = skuId;
            StackType = stackType;
        }
    }
}
