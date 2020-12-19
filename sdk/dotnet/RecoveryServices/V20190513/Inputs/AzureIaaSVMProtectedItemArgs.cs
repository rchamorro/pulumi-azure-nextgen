// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20190513.Inputs
{

    /// <summary>
    /// IaaS VM workload-specific backup item.
    /// </summary>
    public sealed class AzureIaaSVMProtectedItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of backup management for the backed up item.
        /// </summary>
        [Input("backupManagementType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20190513.BackupManagementType>? BackupManagementType { get; set; }

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
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20190513.CreateMode>? CreateMode { get; set; }

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
        public Input<Inputs.AzureIaaSVMProtectedItemExtendedInfoArgs>? ExtendedInfo { get; set; }

        /// <summary>
        /// Extended Properties for Azure IaasVM Backup.
        /// </summary>
        [Input("extendedProperties")]
        public Input<Inputs.ExtendedPropertiesArgs>? ExtendedProperties { get; set; }

        /// <summary>
        /// Friendly name of the VM represented by this backup item.
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Health status of protected item
        /// </summary>
        [Input("healthStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20190513.HealthStatus>? HealthStatus { get; set; }

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

        /// <summary>
        /// Last backup operation status.
        /// </summary>
        [Input("lastBackupStatus")]
        public Input<string>? LastBackupStatus { get; set; }

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
        /// ID of the backup policy with which this item is backed up.
        /// </summary>
        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        /// <summary>
        /// Data ID of the protected item.
        /// </summary>
        [Input("protectedItemDataId")]
        public Input<string>? ProtectedItemDataId { get; set; }

        /// <summary>
        /// backup item type.
        /// Expected value is 'AzureIaaSVMProtectedItem'.
        /// </summary>
        [Input("protectedItemType")]
        public Input<string>? ProtectedItemType { get; set; }

        /// <summary>
        /// Backup state of this backup item.
        /// </summary>
        [Input("protectionState")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20190513.ProtectionState>? ProtectionState { get; set; }

        /// <summary>
        /// Backup status of this backup item.
        /// </summary>
        [Input("protectionStatus")]
        public Input<string>? ProtectionStatus { get; set; }

        /// <summary>
        /// ARM ID of the resource to be backed up.
        /// </summary>
        [Input("sourceResourceId")]
        public Input<string>? SourceResourceId { get; set; }

        /// <summary>
        /// Fully qualified ARM ID of the virtual machine represented by this item.
        /// </summary>
        [Input("virtualMachineId")]
        public Input<string>? VirtualMachineId { get; set; }

        /// <summary>
        /// Type of workload this item represents.
        /// </summary>
        [Input("workloadType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20190513.DataSourceType>? WorkloadType { get; set; }

        public AzureIaaSVMProtectedItemArgs()
        {
        }
    }
}
