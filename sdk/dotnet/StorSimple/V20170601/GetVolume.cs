// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorSimple.V20170601
{
    public static class GetVolume
    {
        public static Task<GetVolumeResult> InvokeAsync(GetVolumeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVolumeResult>("azure-nextgen:storsimple/v20170601:getVolume", args ?? new GetVolumeArgs(), options.WithVersion());
    }


    public sealed class GetVolumeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// The manager name
        /// </summary>
        [Input("managerName", required: true)]
        public string ManagerName { get; set; } = null!;

        /// <summary>
        /// The resource group name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The volume container name.
        /// </summary>
        [Input("volumeContainerName", required: true)]
        public string VolumeContainerName { get; set; } = null!;

        /// <summary>
        /// The volume name.
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
        /// The IDs of the access control records, associated with the volume.
        /// </summary>
        public readonly ImmutableArray<string> AccessControlRecordIds;
        /// <summary>
        /// The IDs of the backup policies, in which this volume is part of.
        /// </summary>
        public readonly ImmutableArray<string> BackupPolicyIds;
        /// <summary>
        /// The backup status of the volume.
        /// </summary>
        public readonly string BackupStatus;
        /// <summary>
        /// The path ID that uniquely identifies the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The Kind of the object. Currently only Series8000 is supported
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// The monitoring status of the volume.
        /// </summary>
        public readonly string MonitoringStatus;
        /// <summary>
        /// The name of the object.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The operation status on the volume.
        /// </summary>
        public readonly string OperationStatus;
        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        public readonly double SizeInBytes;
        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The ID of the volume container, in which this volume is created.
        /// </summary>
        public readonly string VolumeContainerId;
        /// <summary>
        /// The volume status.
        /// </summary>
        public readonly string VolumeStatus;
        /// <summary>
        /// The type of the volume.
        /// </summary>
        public readonly string VolumeType;

        [OutputConstructor]
        private GetVolumeResult(
            ImmutableArray<string> accessControlRecordIds,

            ImmutableArray<string> backupPolicyIds,

            string backupStatus,

            string id,

            string? kind,

            string monitoringStatus,

            string name,

            string operationStatus,

            double sizeInBytes,

            string type,

            string volumeContainerId,

            string volumeStatus,

            string volumeType)
        {
            AccessControlRecordIds = accessControlRecordIds;
            BackupPolicyIds = backupPolicyIds;
            BackupStatus = backupStatus;
            Id = id;
            Kind = kind;
            MonitoringStatus = monitoringStatus;
            Name = name;
            OperationStatus = operationStatus;
            SizeInBytes = sizeInBytes;
            Type = type;
            VolumeContainerId = volumeContainerId;
            VolumeStatus = volumeStatus;
            VolumeType = volumeType;
        }
    }
}
