// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20201101.Outputs
{

    [OutputType]
    public sealed class ResourceLimitsResponse
    {
        /// <summary>
        /// The CPU limit of this container instance.
        /// </summary>
        public readonly double? Cpu;
        /// <summary>
        /// The GPU limit of this container instance.
        /// </summary>
        public readonly Outputs.GpuResourceResponse? Gpu;
        /// <summary>
        /// The memory limit in GB of this container instance.
        /// </summary>
        public readonly double? MemoryInGB;

        [OutputConstructor]
        private ResourceLimitsResponse(
            double? cpu,

            Outputs.GpuResourceResponse? gpu,

            double? memoryInGB)
        {
            Cpu = cpu;
            Gpu = gpu;
            MemoryInGB = memoryInGB;
        }
    }
}
