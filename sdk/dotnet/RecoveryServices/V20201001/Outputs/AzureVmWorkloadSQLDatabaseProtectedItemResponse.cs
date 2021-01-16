// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201001.Outputs
{

    [OutputType]
    public sealed class AzureVmWorkloadSQLDatabaseProtectedItemResponse
    {
        /// <summary>
        /// Type of backup management for the backed up item.
        /// </summary>
        public readonly string? BackupManagementType;
        /// <summary>
        /// Name of the backup set the backup item belongs to
        /// </summary>
        public readonly string? BackupSetName;
        /// <summary>
        /// Unique name of container
        /// </summary>
        public readonly string? ContainerName;
        /// <summary>
        /// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
        /// </summary>
        public readonly string? CreateMode;
        /// <summary>
        /// Time for deferred deletion in UTC
        /// </summary>
        public readonly string? DeferredDeleteTimeInUTC;
        /// <summary>
        /// Time remaining before the DS marked for deferred delete is permanently deleted
        /// </summary>
        public readonly string? DeferredDeleteTimeRemaining;
        /// <summary>
        /// Additional information for this backup item.
        /// </summary>
        public readonly Outputs.AzureVmWorkloadProtectedItemExtendedInfoResponse? ExtendedInfo;
        /// <summary>
        /// Friendly name of the DB represented by this backup item.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// Flag to identify whether the deferred deleted DS is to be purged soon
        /// </summary>
        public readonly bool? IsDeferredDeleteScheduleUpcoming;
        /// <summary>
        /// Flag to identify that deferred deleted DS is to be moved into Pause state
        /// </summary>
        public readonly bool? IsRehydrate;
        /// <summary>
        /// Flag to identify whether the DS is scheduled for deferred delete
        /// </summary>
        public readonly bool? IsScheduledForDeferredDelete;
        /// <summary>
        /// Health details of different KPIs
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.KPIResourceHealthDetailsResponse>? KpisHealths;
        /// <summary>
        /// Error details in last backup
        /// </summary>
        public readonly Outputs.ErrorDetailResponse? LastBackupErrorDetail;
        /// <summary>
        /// Last backup operation status. Possible values: Healthy, Unhealthy.
        /// </summary>
        public readonly string? LastBackupStatus;
        /// <summary>
        /// Timestamp of the last backup operation on this backup item.
        /// </summary>
        public readonly string? LastBackupTime;
        /// <summary>
        /// Timestamp when the last (latest) backup copy was created for this backup item.
        /// </summary>
        public readonly string? LastRecoveryPoint;
        /// <summary>
        /// Parent name of the DB such as Instance or Availability Group.
        /// </summary>
        public readonly string? ParentName;
        /// <summary>
        /// Parent type of protected item, example: for a DB, standalone server or distributed
        /// </summary>
        public readonly string? ParentType;
        /// <summary>
        /// ID of the backup policy with which this item is backed up.
        /// </summary>
        public readonly string? PolicyId;
        /// <summary>
        /// Data ID of the protected item.
        /// </summary>
        public readonly string? ProtectedItemDataSourceId;
        /// <summary>
        /// Health status of the backup item, evaluated based on last heartbeat received
        /// </summary>
        public readonly string? ProtectedItemHealthStatus;
        /// <summary>
        /// backup item type.
        /// Expected value is 'AzureVmWorkloadProtectedItem'.
        /// </summary>
        public readonly string ProtectedItemType;
        /// <summary>
        /// Backup state of this backup item.
        /// </summary>
        public readonly string? ProtectionState;
        /// <summary>
        /// Backup status of this backup item.
        /// </summary>
        public readonly string? ProtectionStatus;
        /// <summary>
        /// Host/Cluster Name for instance or AG
        /// </summary>
        public readonly string? ServerName;
        /// <summary>
        /// ARM ID of the resource to be backed up.
        /// </summary>
        public readonly string? SourceResourceId;
        /// <summary>
        /// Type of workload this item represents.
        /// </summary>
        public readonly string? WorkloadType;

        [OutputConstructor]
        private AzureVmWorkloadSQLDatabaseProtectedItemResponse(
            string? backupManagementType,

            string? backupSetName,

            string? containerName,

            string? createMode,

            string? deferredDeleteTimeInUTC,

            string? deferredDeleteTimeRemaining,

            Outputs.AzureVmWorkloadProtectedItemExtendedInfoResponse? extendedInfo,

            string? friendlyName,

            bool? isDeferredDeleteScheduleUpcoming,

            bool? isRehydrate,

            bool? isScheduledForDeferredDelete,

            ImmutableDictionary<string, Outputs.KPIResourceHealthDetailsResponse>? kpisHealths,

            Outputs.ErrorDetailResponse? lastBackupErrorDetail,

            string? lastBackupStatus,

            string? lastBackupTime,

            string? lastRecoveryPoint,

            string? parentName,

            string? parentType,

            string? policyId,

            string? protectedItemDataSourceId,

            string? protectedItemHealthStatus,

            string protectedItemType,

            string? protectionState,

            string? protectionStatus,

            string? serverName,

            string? sourceResourceId,

            string? workloadType)
        {
            BackupManagementType = backupManagementType;
            BackupSetName = backupSetName;
            ContainerName = containerName;
            CreateMode = createMode;
            DeferredDeleteTimeInUTC = deferredDeleteTimeInUTC;
            DeferredDeleteTimeRemaining = deferredDeleteTimeRemaining;
            ExtendedInfo = extendedInfo;
            FriendlyName = friendlyName;
            IsDeferredDeleteScheduleUpcoming = isDeferredDeleteScheduleUpcoming;
            IsRehydrate = isRehydrate;
            IsScheduledForDeferredDelete = isScheduledForDeferredDelete;
            KpisHealths = kpisHealths;
            LastBackupErrorDetail = lastBackupErrorDetail;
            LastBackupStatus = lastBackupStatus;
            LastBackupTime = lastBackupTime;
            LastRecoveryPoint = lastRecoveryPoint;
            ParentName = parentName;
            ParentType = parentType;
            PolicyId = policyId;
            ProtectedItemDataSourceId = protectedItemDataSourceId;
            ProtectedItemHealthStatus = protectedItemHealthStatus;
            ProtectedItemType = protectedItemType;
            ProtectionState = protectionState;
            ProtectionStatus = protectionStatus;
            ServerName = serverName;
            SourceResourceId = sourceResourceId;
            WorkloadType = workloadType;
        }
    }
}
