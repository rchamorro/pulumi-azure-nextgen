// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200801
{
    public static class GetVolume
    {
        public static Task<GetVolumeResult> InvokeAsync(GetVolumeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVolumeResult>("azure-nextgen:netapp/v20200801:getVolume", args ?? new GetVolumeArgs(), options.WithVersion());
    }


    public sealed class GetVolumeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public string PoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the volume
        /// </summary>
        [Input("volumeName", required: true)]
        public string VolumeName { get; set; } = null!;

        public GetVolumeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVolumeResult
    {
        /// <summary>
        /// UUID v4 or resource identifier used to identify the Backup.
        /// </summary>
        public readonly string? BackupId;
        /// <summary>
        /// Unique Baremetal Tenant Identifier.
        /// </summary>
        public readonly string BaremetalTenantId;
        /// <summary>
        /// A unique file path for the volume. Used when creating mount targets
        /// </summary>
        public readonly string CreationToken;
        /// <summary>
        /// DataProtection type volumes include an object containing details of the replication
        /// </summary>
        public readonly Outputs.VolumePropertiesResponseDataProtection? DataProtection;
        /// <summary>
        /// Set of export policy rules
        /// </summary>
        public readonly Outputs.VolumePropertiesResponseExportPolicy? ExportPolicy;
        /// <summary>
        /// Unique FileSystem Identifier.
        /// </summary>
        public readonly string FileSystemId;
        /// <summary>
        /// Restoring
        /// </summary>
        public readonly bool? IsRestoring;
        /// <summary>
        /// Describe if a volume is KerberosEnabled. To be use with swagger version 2020-05-01 or later
        /// </summary>
        public readonly bool? KerberosEnabled;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// List of mount targets
        /// </summary>
        public readonly ImmutableArray<Outputs.MountTargetPropertiesResponse> MountTargets;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Set of protocol types
        /// </summary>
        public readonly ImmutableArray<string> ProtocolTypes;
        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The security style of volume
        /// </summary>
        public readonly string? SecurityStyle;
        /// <summary>
        /// The service level of the file system
        /// </summary>
        public readonly string? ServiceLevel;
        /// <summary>
        /// If enabled (true) the volume will contain a read-only .snapshot directory which provides access to each of the volume's snapshots (default to true).
        /// </summary>
        public readonly bool? SnapshotDirectoryVisible;
        /// <summary>
        /// UUID v4 or resource identifier used to identify the Snapshot.
        /// </summary>
        public readonly string? SnapshotId;
        /// <summary>
        /// The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        public readonly double? ThroughputMibps;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        /// </summary>
        public readonly int UsageThreshold;
        /// <summary>
        /// What type of volume is this
        /// </summary>
        public readonly string? VolumeType;

        [OutputConstructor]
        private GetVolumeResult(
            string? backupId,

            string baremetalTenantId,

            string creationToken,

            Outputs.VolumePropertiesResponseDataProtection? dataProtection,

            Outputs.VolumePropertiesResponseExportPolicy? exportPolicy,

            string fileSystemId,

            bool? isRestoring,

            bool? kerberosEnabled,

            string location,

            ImmutableArray<Outputs.MountTargetPropertiesResponse> mountTargets,

            string name,

            ImmutableArray<string> protocolTypes,

            string provisioningState,

            string? securityStyle,

            string? serviceLevel,

            bool? snapshotDirectoryVisible,

            string? snapshotId,

            string subnetId,

            ImmutableDictionary<string, string>? tags,

            double? throughputMibps,

            string type,

            int usageThreshold,

            string? volumeType)
        {
            BackupId = backupId;
            BaremetalTenantId = baremetalTenantId;
            CreationToken = creationToken;
            DataProtection = dataProtection;
            ExportPolicy = exportPolicy;
            FileSystemId = fileSystemId;
            IsRestoring = isRestoring;
            KerberosEnabled = kerberosEnabled;
            Location = location;
            MountTargets = mountTargets;
            Name = name;
            ProtocolTypes = protocolTypes;
            ProvisioningState = provisioningState;
            SecurityStyle = securityStyle;
            ServiceLevel = serviceLevel;
            SnapshotDirectoryVisible = snapshotDirectoryVisible;
            SnapshotId = snapshotId;
            SubnetId = subnetId;
            Tags = tags;
            ThroughputMibps = throughputMibps;
            Type = type;
            UsageThreshold = usageThreshold;
            VolumeType = volumeType;
        }
    }
}