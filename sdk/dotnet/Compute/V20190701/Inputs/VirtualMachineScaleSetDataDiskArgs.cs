// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20190701.Inputs
{

    /// <summary>
    /// Describes a virtual machine scale set data disk.
    /// </summary>
    public sealed class VirtualMachineScaleSetDataDiskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        [Input("caching")]
        public Input<Pulumi.AzureNextGen.Compute.V20190701.CachingTypes>? Caching { get; set; }

        /// <summary>
        /// The create option.
        /// </summary>
        [Input("createOption", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.Compute.V20190701.DiskCreateOptionTypes> CreateOption { get; set; } = null!;

        /// <summary>
        /// Specifies the Read-Write IOPS for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
        /// </summary>
        [Input("diskIOPSReadWrite")]
        public Input<double>? DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// Specifies the bandwidth in MB per second for the managed disk. Should be used only when StorageAccountType is UltraSSD_LRS. If not specified, a default value would be assigned based on diskSizeGB.
        /// </summary>
        [Input("diskMBpsReadWrite")]
        public Input<double>? DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// Specifies the size of an empty data disk in gigabytes. This element can be used to overwrite the size of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        [Input("diskSizeGB")]
        public Input<int>? DiskSizeGB { get; set; }

        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [Input("lun", required: true)]
        public Input<int> Lun { get; set; } = null!;

        /// <summary>
        /// The managed disk parameters.
        /// </summary>
        [Input("managedDisk")]
        public Input<Inputs.VirtualMachineScaleSetManagedDiskParametersArgs>? ManagedDisk { get; set; }

        /// <summary>
        /// The disk name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies whether writeAccelerator should be enabled or disabled on the disk.
        /// </summary>
        [Input("writeAcceleratorEnabled")]
        public Input<bool>? WriteAcceleratorEnabled { get; set; }

        public VirtualMachineScaleSetDataDiskArgs()
        {
        }
    }
}
