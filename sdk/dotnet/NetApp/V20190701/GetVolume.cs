// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20190701
{
    public static class GetVolume
    {
        public static Task<GetVolumeResult> InvokeAsync(GetVolumeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVolumeResult>("azure-nextgen:netapp/v20190701:getVolume", args ?? new GetVolumeArgs(), options.WithVersion());
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
        /// Unique Baremetal Tenant Identifier.
        /// </summary>
        public readonly string BaremetalTenantId;
        /// <summary>
        /// A unique file path for the volume. Used when creating mount targets
        /// </summary>
        public readonly string CreationToken;
        /// <summary>
        /// Set of export policy rules
        /// </summary>
        public readonly Outputs.VolumePropertiesResponseExportPolicy? ExportPolicy;
        /// <summary>
        /// Unique FileSystem Identifier.
        /// </summary>
        public readonly string FileSystemId;
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
        /// The service level of the file system
        /// </summary>
        public readonly string? ServiceLevel;
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
        public readonly object? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. Minimum size is 100 GiB. Upper limit is 100TiB. Specified in bytes.
        /// </summary>
        public readonly int UsageThreshold;

        [OutputConstructor]
        private GetVolumeResult(
            string baremetalTenantId,

            string creationToken,

            Outputs.VolumePropertiesResponseExportPolicy? exportPolicy,

            string fileSystemId,

            string location,

            ImmutableArray<Outputs.MountTargetPropertiesResponse> mountTargets,

            string name,

            ImmutableArray<string> protocolTypes,

            string provisioningState,

            string? serviceLevel,

            string? snapshotId,

            string subnetId,

            object? tags,

            string type,

            int usageThreshold)
        {
            BaremetalTenantId = baremetalTenantId;
            CreationToken = creationToken;
            ExportPolicy = exportPolicy;
            FileSystemId = fileSystemId;
            Location = location;
            MountTargets = mountTargets;
            Name = name;
            ProtocolTypes = protocolTypes;
            ProvisioningState = provisioningState;
            ServiceLevel = serviceLevel;
            SnapshotId = snapshotId;
            SubnetId = subnetId;
            Tags = tags;
            Type = type;
            UsageThreshold = usageThreshold;
        }
    }
}
