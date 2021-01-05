// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200901.Outputs
{

    [OutputType]
    public sealed class StampCapacityResponse
    {
        /// <summary>
        /// Available capacity (# of machines, bytes of storage etc...).
        /// </summary>
        public readonly double? AvailableCapacity;
        /// <summary>
        /// Shared/dedicated workers.
        /// </summary>
        public readonly string? ComputeMode;
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, it includes basic apps.
        /// Basic apps are not used for capacity allocation.
        /// </summary>
        public readonly bool? ExcludeFromCapacityAllocation;
        /// <summary>
        /// &lt;code&gt;true&lt;/code&gt; if capacity is applicable for all apps; otherwise, &lt;code&gt;false&lt;/code&gt;.
        /// </summary>
        public readonly bool? IsApplicableForAllComputeModes;
        /// <summary>
        /// Is this a linux stamp capacity
        /// </summary>
        public readonly bool? IsLinux;
        /// <summary>
        /// Name of the stamp.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Shared or Dedicated.
        /// </summary>
        public readonly string? SiteMode;
        /// <summary>
        /// Total capacity (# of machines, bytes of storage etc...).
        /// </summary>
        public readonly double? TotalCapacity;
        /// <summary>
        /// Name of the unit.
        /// </summary>
        public readonly string? Unit;
        /// <summary>
        /// Size of the machines.
        /// </summary>
        public readonly string? WorkerSize;
        /// <summary>
        /// Size ID of machines: 
        /// 0 - Small
        /// 1 - Medium
        /// 2 - Large
        /// </summary>
        public readonly int? WorkerSizeId;

        [OutputConstructor]
        private StampCapacityResponse(
            double? availableCapacity,

            string? computeMode,

            bool? excludeFromCapacityAllocation,

            bool? isApplicableForAllComputeModes,

            bool? isLinux,

            string? name,

            string? siteMode,

            double? totalCapacity,

            string? unit,

            string? workerSize,

            int? workerSizeId)
        {
            AvailableCapacity = availableCapacity;
            ComputeMode = computeMode;
            ExcludeFromCapacityAllocation = excludeFromCapacityAllocation;
            IsApplicableForAllComputeModes = isApplicableForAllComputeModes;
            IsLinux = isLinux;
            Name = name;
            SiteMode = siteMode;
            TotalCapacity = totalCapacity;
            Unit = unit;
            WorkerSize = workerSize;
            WorkerSizeId = workerSizeId;
        }
    }
}
