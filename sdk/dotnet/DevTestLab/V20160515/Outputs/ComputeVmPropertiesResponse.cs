// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DevTestLab.V20160515.Outputs
{

    [OutputType]
    public sealed class ComputeVmPropertiesResponse
    {
        /// <summary>
        /// Gets data disks blob uri for the virtual machine.
        /// </summary>
        public readonly ImmutableArray<string> DataDiskIds;
        /// <summary>
        /// Gets all data disks attached to the virtual machine.
        /// </summary>
        public readonly ImmutableArray<Outputs.ComputeDataDiskResponse> DataDisks;
        /// <summary>
        /// Gets the network interface ID of the virtual machine.
        /// </summary>
        public readonly string? NetworkInterfaceId;
        /// <summary>
        /// Gets OS disk blob uri for the virtual machine.
        /// </summary>
        public readonly string? OsDiskId;
        /// <summary>
        /// Gets the OS type of the virtual machine.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// Gets the statuses of the virtual machine.
        /// </summary>
        public readonly ImmutableArray<Outputs.ComputeVmInstanceViewStatusResponse> Statuses;
        /// <summary>
        /// Gets the size of the virtual machine.
        /// </summary>
        public readonly string? VmSize;

        [OutputConstructor]
        private ComputeVmPropertiesResponse(
            ImmutableArray<string> dataDiskIds,

            ImmutableArray<Outputs.ComputeDataDiskResponse> dataDisks,

            string? networkInterfaceId,

            string? osDiskId,

            string? osType,

            ImmutableArray<Outputs.ComputeVmInstanceViewStatusResponse> statuses,

            string? vmSize)
        {
            DataDiskIds = dataDiskIds;
            DataDisks = dataDisks;
            NetworkInterfaceId = networkInterfaceId;
            OsDiskId = osDiskId;
            OsType = osType;
            Statuses = statuses;
            VmSize = vmSize;
        }
    }
}