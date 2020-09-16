// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20190301.Outputs
{

    [OutputType]
    public sealed class ImageDataDiskResponse
    {
        /// <summary>
        /// The Virtual Hard Disk.
        /// </summary>
        public readonly string? BlobUri;
        /// <summary>
        /// Specifies the caching requirements. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt; **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard storage. ReadOnly for Premium storage**
        /// </summary>
        public readonly string? Caching;
        /// <summary>
        /// Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value cannot be larger than 1023 GB
        /// </summary>
        public readonly int? DiskSizeGB;
        /// <summary>
        /// Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and therefore must be unique for each data disk attached to a VM.
        /// </summary>
        public readonly int Lun;
        /// <summary>
        /// The managedDisk.
        /// </summary>
        public readonly Outputs.SubResourceResponse? ManagedDisk;
        /// <summary>
        /// The snapshot.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Snapshot;
        /// <summary>
        /// Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk.
        /// </summary>
        public readonly string? StorageAccountType;

        [OutputConstructor]
        private ImageDataDiskResponse(
            string? blobUri,

            string? caching,

            int? diskSizeGB,

            int lun,

            Outputs.SubResourceResponse? managedDisk,

            Outputs.SubResourceResponse? snapshot,

            string? storageAccountType)
        {
            BlobUri = blobUri;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            Lun = lun;
            ManagedDisk = managedDisk;
            Snapshot = snapshot;
            StorageAccountType = storageAccountType;
        }
    }
}