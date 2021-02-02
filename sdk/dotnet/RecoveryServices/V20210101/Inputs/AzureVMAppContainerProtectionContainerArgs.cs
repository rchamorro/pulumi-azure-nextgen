// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20210101.Inputs
{

    /// <summary>
    /// Container for SQL workloads under Azure Virtual Machines.
    /// </summary>
    public sealed class AzureVMAppContainerProtectionContainerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Type of backup management for the container.
        /// </summary>
        [Input("backupManagementType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20210101.BackupManagementType>? BackupManagementType { get; set; }

        /// <summary>
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// Expected value is 'AzureWorkloadContainer'.
        /// </summary>
        [Input("containerType", required: true)]
        public Input<string> ContainerType { get; set; } = null!;

        /// <summary>
        /// Additional details of a workload container.
        /// </summary>
        [Input("extendedInfo")]
        public Input<Inputs.AzureWorkloadContainerExtendedInfoArgs>? ExtendedInfo { get; set; }

        /// <summary>
        /// Friendly name of the container.
        /// </summary>
        [Input("friendlyName")]
        public Input<string>? FriendlyName { get; set; }

        /// <summary>
        /// Status of health of the container.
        /// </summary>
        [Input("healthStatus")]
        public Input<string>? HealthStatus { get; set; }

        /// <summary>
        /// Time stamp when this container was updated.
        /// </summary>
        [Input("lastUpdatedTime")]
        public Input<string>? LastUpdatedTime { get; set; }

        /// <summary>
        /// Re-Do Operation
        /// </summary>
        [Input("operationType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20210101.OperationType>? OperationType { get; set; }

        /// <summary>
        /// Status of registration of the container with the Recovery Services Vault.
        /// </summary>
        [Input("registrationStatus")]
        public Input<string>? RegistrationStatus { get; set; }

        /// <summary>
        /// ARM ID of the virtual machine represented by this Azure Workload Container
        /// </summary>
        [Input("sourceResourceId")]
        public Input<string>? SourceResourceId { get; set; }

        /// <summary>
        /// Workload type for which registration was sent.
        /// </summary>
        [Input("workloadType")]
        public InputUnion<string, Pulumi.AzureNextGen.RecoveryServices.V20210101.WorkloadType>? WorkloadType { get; set; }

        public AzureVMAppContainerProtectionContainerArgs()
        {
        }
    }
}
