// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20210101.Outputs
{

    [OutputType]
    public sealed class GenericContainerResponse
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
        /// Expected value is 'GenericContainer'.
        /// </summary>
        public readonly string ContainerType;
        /// <summary>
        /// Extended information (not returned in List container API calls)
        /// </summary>
        public readonly Outputs.GenericContainerExtendedInfoResponse? ExtendedInformation;
        /// <summary>
        /// Name of the container's fabric
        /// </summary>
        public readonly string? FabricName;
        /// <summary>
        /// Friendly name of the container.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// Status of health of the container.
        /// </summary>
        public readonly string? HealthStatus;
        /// <summary>
        /// Status of registration of the container with the Recovery Services Vault.
        /// </summary>
        public readonly string? RegistrationStatus;

        [OutputConstructor]
        private GenericContainerResponse(
            string? backupManagementType,

            string containerType,

            Outputs.GenericContainerExtendedInfoResponse? extendedInformation,

            string? fabricName,

            string? friendlyName,

            string? healthStatus,

            string? registrationStatus)
        {
            BackupManagementType = backupManagementType;
            ContainerType = containerType;
            ExtendedInformation = extendedInformation;
            FabricName = fabricName;
            FriendlyName = friendlyName;
            HealthStatus = healthStatus;
            RegistrationStatus = registrationStatus;
        }
    }
}
