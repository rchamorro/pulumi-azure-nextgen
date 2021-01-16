// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201.Inputs
{

    /// <summary>
    /// Azure VM workload-specific protected item representing SAP HANA Database.
    /// </summary>
    public sealed class AzureVmWorkloadSAPHanaDatabaseProtectedItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of backup management for the backed up item.
        /// </summary>
        [Input("backupManagementType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.BackupManagementType>? BackupManagementType { get; set; }

        /// <summary>
        /// Name of the backup set the backup item belongs to
        /// </summary>
        [Input("backupSetName")]
        public Input<string>? BackupSetName { get; set; }

        /// <summary>
        /// Unique name of container
        /// </summary>
        [Input("containerName")]
        public Input<string>? ContainerName { get; set; }

        /// <summary>
        /// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
        /// </summary>
        [Input("createMode")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.CreateMode>? CreateMode { get; set; }

        /// <summary>
        /// Time for deferred deletion in UTC
        /// </summary>
        [Input("deferredDeleteTimeInUTC")]
        public Input<string>? DeferredDeleteTimeInUTC { get; set; }

        /// <summary>
        /// Time remaining before the DS marked for deferred delete is permanently deleted
        /// </summary>
        [Input("deferredDeleteTimeRemaining")]
        public Input<string>? DeferredDeleteTimeRemaining { get; set; }

        /// <summary>
        /// Additional information for this backup item.
        /// </summary>
        [Input("extendedInfo")]
        public Input<Inputs.AzureVmWorkloadProtectedItemExtendedInfoArgs>? ExtendedInfo { get; set; }

        /// <summary>
        /// Friendly name of the DB represented by this backup item.
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Flag to identify whether the deferred deleted DS is to be purged soon
        /// </summary>
        [Input("isDeferredDeleteScheduleUpcoming")]
        public Input<bool>? IsDeferredDeleteScheduleUpcoming { get; set; }

        /// <summary>
        /// Flag to identify that deferred deleted DS is to be moved into Pause state
        /// </summary>
        [Input("isRehydrate")]
        public Input<bool>? IsRehydrate { get; set; }

        /// <summary>
        /// Flag to identify whether the DS is scheduled for deferred delete
        /// </summary>
        [Input("isScheduledForDeferredDelete")]
        public Input<bool>? IsScheduledForDeferredDelete { get; set; }

        [Input("kpisHealths")]
        private InputMap<Inputs.KPIResourceHealthDetailsArgs>? _kpisHealths;

        /// <summary>
        /// Health details of different KPIs
        /// </summary>
        public InputMap<Inputs.KPIResourceHealthDetailsArgs> KpisHealths
        {
            get => _kpisHealths ?? (_kpisHealths = new InputMap<Inputs.KPIResourceHealthDetailsArgs>());
            set => _kpisHealths = value;
        }

        /// <summary>
        /// Last backup operation status. Possible values: Healthy, Unhealthy.
        /// </summary>
        [Input("lastBackupStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.LastBackupStatus>? LastBackupStatus { get; set; }

        /// <summary>
        /// Timestamp of the last backup operation on this backup item.
        /// </summary>
        [Input("lastBackupTime")]
        public Input<string>? LastBackupTime { get; set; }

        /// <summary>
        /// Timestamp when the last (latest) backup copy was created for this backup item.
        /// </summary>
        [Input("lastRecoveryPoint")]
        public Input<string>? LastRecoveryPoint { get; set; }

        /// <summary>
        /// Parent name of the DB such as Instance or Availability Group.
        /// </summary>
        [Input("parentName")]
        public Input<string>? ParentName { get; set; }

        /// <summary>
        /// Parent type of protected item, example: for a DB, standalone server or distributed
        /// </summary>
        [Input("parentType")]
        public Input<string>? ParentType { get; set; }

        /// <summary>
        /// ID of the backup policy with which this item is backed up.
        /// </summary>
        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        /// <summary>
        /// Data ID of the protected item.
        /// </summary>
        [Input("protectedItemDataSourceId")]
        public Input<string>? ProtectedItemDataSourceId { get; set; }

        /// <summary>
        /// Health status of the backup item, evaluated based on last heartbeat received
        /// </summary>
        [Input("protectedItemHealthStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.ProtectedItemHealthStatus>? ProtectedItemHealthStatus { get; set; }

        /// <summary>
        /// backup item type.
        /// Expected value is 'AzureVmWorkloadProtectedItem'.
        /// </summary>
        [Input("protectedItemType", required: true)]
        public Input<string> ProtectedItemType { get; set; } = null!;

        /// <summary>
        /// Backup state of this backup item.
        /// </summary>
        [Input("protectionState")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.ProtectionState>? ProtectionState { get; set; }

        /// <summary>
        /// Backup status of this backup item.
        /// </summary>
        [Input("protectionStatus")]
        public Input<string>? ProtectionStatus { get; set; }

        /// <summary>
        /// Host/Cluster Name for instance or AG
        /// </summary>
        [Input("serverName")]
        public Input<string>? ServerName { get; set; }

        /// <summary>
        /// ARM ID of the resource to be backed up.
        /// </summary>
        [Input("sourceResourceId")]
        public Input<string>? SourceResourceId { get; set; }

        /// <summary>
        /// Type of workload this item represents.
        /// </summary>
        [Input("workloadType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20201201.DataSourceType>? WorkloadType { get; set; }

        public AzureVmWorkloadSAPHanaDatabaseProtectedItemArgs()
        {
        }
    }
}
