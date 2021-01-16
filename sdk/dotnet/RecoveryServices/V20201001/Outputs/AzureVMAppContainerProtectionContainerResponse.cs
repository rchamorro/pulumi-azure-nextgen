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
    public sealed class AzureVMAppContainerProtectionContainerResponse
    {
        /// <summary>
        /// Type of backup management for the container.
        /// </summary>
        public readonly string? BackupManagementType;
        /// <summary>
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// Expected value is 'AzureWorkloadContainer'.
        /// </summary>
        public readonly string ContainerType;
        /// <summary>
        /// Additional details of a workload container.
        /// </summary>
        public readonly Outputs.AzureWorkloadContainerExtendedInfoResponse? ExtendedInfo;
        /// <summary>
        /// Friendly name of the container.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// Status of health of the container.
        /// </summary>
        public readonly string? HealthStatus;
        /// <summary>
        /// Time stamp when this container was updated.
        /// </summary>
        public readonly string? LastUpdatedTime;
        /// <summary>
        /// Re-Do Operation
        /// </summary>
        public readonly string? OperationType;
        /// <summary>
        /// Status of registration of the container with the Recovery Services Vault.
        /// </summary>
        public readonly string? RegistrationStatus;
        /// <summary>
        /// ARM ID of the virtual machine represented by this Azure Workload Container
        /// </summary>
        public readonly string? SourceResourceId;
        /// <summary>
        /// Workload type for which registration was sent.
        /// </summary>
        public readonly string? WorkloadType;

        [OutputConstructor]
        private AzureVMAppContainerProtectionContainerResponse(
            string? backupManagementType,

            string containerType,

            Outputs.AzureWorkloadContainerExtendedInfoResponse? extendedInfo,

            string? friendlyName,

            string? healthStatus,

            string? lastUpdatedTime,

            string? operationType,

            string? registrationStatus,

            string? sourceResourceId,

            string? workloadType)
        {
            BackupManagementType = backupManagementType;
            ContainerType = containerType;
            ExtendedInfo = extendedInfo;
            FriendlyName = friendlyName;
            HealthStatus = healthStatus;
            LastUpdatedTime = lastUpdatedTime;
            OperationType = operationType;
            RegistrationStatus = registrationStatus;
            SourceResourceId = sourceResourceId;
            WorkloadType = workloadType;
        }
    }
}
