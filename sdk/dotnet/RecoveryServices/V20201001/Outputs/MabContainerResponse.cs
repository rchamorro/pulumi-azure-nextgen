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
    public sealed class MabContainerResponse
    {
        /// <summary>
        /// Agent version of this container.
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// Type of backup management for the container.
        /// </summary>
        public readonly string? BackupManagementType;
        /// <summary>
        /// Can the container be registered one more time.
        /// </summary>
        public readonly bool? CanReRegister;
        /// <summary>
        /// Health state of mab container.
        /// </summary>
        public readonly string? ContainerHealthState;
        /// <summary>
        /// ContainerID represents the container.
        /// </summary>
        public readonly double? ContainerId;
        /// <summary>
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// Expected value is 'Windows'.
        /// </summary>
        public readonly string ContainerType;
        /// <summary>
        /// Additional information for this container
        /// </summary>
        public readonly Outputs.MabContainerExtendedInfoResponse? ExtendedInfo;
        /// <summary>
        /// Friendly name of the container.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// Status of health of the container.
        /// </summary>
        public readonly string? HealthStatus;
        /// <summary>
        /// Health details on this mab container.
        /// </summary>
        public readonly ImmutableArray<Outputs.MABContainerHealthDetailsResponse> MabContainerHealthDetails;
        /// <summary>
        /// Number of items backed up in this container.
        /// </summary>
        public readonly double? ProtectedItemCount;
        /// <summary>
        /// Status of registration of the container with the Recovery Services Vault.
        /// </summary>
        public readonly string? RegistrationStatus;

        [OutputConstructor]
        private MabContainerResponse(
            string? agentVersion,

            string? backupManagementType,

            bool? canReRegister,

            string? containerHealthState,

            double? containerId,

            string containerType,

            Outputs.MabContainerExtendedInfoResponse? extendedInfo,

            string? friendlyName,

            string? healthStatus,

            ImmutableArray<Outputs.MABContainerHealthDetailsResponse> mabContainerHealthDetails,

            double? protectedItemCount,

            string? registrationStatus)
        {
            AgentVersion = agentVersion;
            BackupManagementType = backupManagementType;
            CanReRegister = canReRegister;
            ContainerHealthState = containerHealthState;
            ContainerId = containerId;
            ContainerType = containerType;
            ExtendedInfo = extendedInfo;
            FriendlyName = friendlyName;
            HealthStatus = healthStatus;
            MabContainerHealthDetails = mabContainerHealthDetails;
            ProtectedItemCount = protectedItemCount;
            RegistrationStatus = registrationStatus;
        }
    }
}
