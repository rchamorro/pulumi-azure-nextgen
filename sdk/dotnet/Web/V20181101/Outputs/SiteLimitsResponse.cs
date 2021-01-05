// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20181101.Outputs
{

    [OutputType]
    public sealed class SiteLimitsResponse
    {
        /// <summary>
        /// Maximum allowed disk size usage in MB.
        /// </summary>
        public readonly double? MaxDiskSizeInMb;
        /// <summary>
        /// Maximum allowed memory usage in MB.
        /// </summary>
        public readonly double? MaxMemoryInMb;
        /// <summary>
        /// Maximum allowed CPU usage percentage.
        /// </summary>
        public readonly double? MaxPercentageCpu;

        [OutputConstructor]
        private SiteLimitsResponse(
            double? maxDiskSizeInMb,

            double? maxMemoryInMb,

            double? maxPercentageCpu)
        {
            MaxDiskSizeInMb = maxDiskSizeInMb;
            MaxMemoryInMb = maxMemoryInMb;
            MaxPercentageCpu = maxPercentageCpu;
        }
    }
}
