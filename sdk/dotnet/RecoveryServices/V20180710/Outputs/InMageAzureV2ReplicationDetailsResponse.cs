// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Outputs
{

    [OutputType]
    public sealed class InMageAzureV2ReplicationDetailsResponse
    {
        /// <summary>
        /// Agent expiry date.
        /// </summary>
        public readonly string? AgentExpiryDate;
        /// <summary>
        /// The agent version.
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// Azure VM Disk details.
        /// </summary>
        public readonly ImmutableArray<Outputs.AzureVmDiskDetailsResponse> AzureVMDiskDetails;
        /// <summary>
        /// The compressed data change rate in MB.
        /// </summary>
        public readonly double? CompressedDataRateInMB;
        /// <summary>
        /// The data stores of the on-premise machine. Value can be list of strings that contain data store names.
        /// </summary>
        public readonly ImmutableArray<string> Datastores;
        /// <summary>
        /// A value indicating the discovery type of the machine. Value can be vCenter or physical.
        /// </summary>
        public readonly string? DiscoveryType;
        /// <summary>
        /// A value indicating whether any disk is resized for this VM.
        /// </summary>
        public readonly string? DiskResized;
        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of {SrsDataContract.EnableRDPOnTargetOption} enum.
        /// </summary>
        public readonly string? EnableRdpOnTargetOption;
        /// <summary>
        /// The infrastructure VM Id.
        /// </summary>
        public readonly string? InfrastructureVmId;
        /// <summary>
        /// Gets the Instance type.
        /// Expected value is 'InMageAzureV2'.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The source IP address.
        /// </summary>
        public readonly string? IpAddress;
        /// <summary>
        /// A value indicating whether installed agent needs to be updated.
        /// </summary>
        public readonly string? IsAgentUpdateRequired;
        /// <summary>
        /// A value indicating whether the source server requires a restart after update.
        /// </summary>
        public readonly string? IsRebootAfterUpdateRequired;
        /// <summary>
        /// The last heartbeat received from the source server.
        /// </summary>
        public readonly string? LastHeartbeat;
        /// <summary>
        /// The last RPO calculated time.
        /// </summary>
        public readonly string? LastRpoCalculatedTime;
        /// <summary>
        /// The last update time received from on-prem components.
        /// </summary>
        public readonly string? LastUpdateReceivedTime;
        /// <summary>
        /// License Type of the VM to be used.
        /// </summary>
        public readonly string? LicenseType;
        /// <summary>
        /// The master target Id.
        /// </summary>
        public readonly string? MasterTargetId;
        /// <summary>
        /// The multi vm group Id.
        /// </summary>
        public readonly string? MultiVmGroupId;
        /// <summary>
        /// The multi vm group name.
        /// </summary>
        public readonly string? MultiVmGroupName;
        /// <summary>
        /// A value indicating whether multi vm sync is enabled or disabled.
        /// </summary>
        public readonly string? MultiVmSyncStatus;
        /// <summary>
        /// The id of the disk containing the OS.
        /// </summary>
        public readonly string? OsDiskId;
        /// <summary>
        /// The type of the OS on the VM.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// The OS Version of the protected item.
        /// </summary>
        public readonly string? OsVersion;
        /// <summary>
        /// The process server Id.
        /// </summary>
        public readonly string? ProcessServerId;
        /// <summary>
        /// The process server name.
        /// </summary>
        public readonly string ProcessServerName;
        /// <summary>
        /// The list of protected disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.InMageAzureV2ProtectedDiskDetailsResponse> ProtectedDisks;
        /// <summary>
        /// The list of protected managed disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.InMageAzureV2ManagedDiskDetailsResponse> ProtectedManagedDisks;
        /// <summary>
        /// The protection stage.
        /// </summary>
        public readonly string? ProtectionStage;
        /// <summary>
        /// The recovery availability set Id.
        /// </summary>
        public readonly string? RecoveryAvailabilitySetId;
        /// <summary>
        /// The ARM id of the log storage account used for replication. This will be set to null if no log storage account was provided during enable protection.
        /// </summary>
        public readonly string? RecoveryAzureLogStorageAccountId;
        /// <summary>
        /// The target resource group Id.
        /// </summary>
        public readonly string? RecoveryAzureResourceGroupId;
        /// <summary>
        /// The recovery Azure storage account.
        /// </summary>
        public readonly string? RecoveryAzureStorageAccount;
        /// <summary>
        /// Recovery Azure given name.
        /// </summary>
        public readonly string? RecoveryAzureVMName;
        /// <summary>
        /// The Recovery Azure VM size.
        /// </summary>
        public readonly string? RecoveryAzureVMSize;
        /// <summary>
        /// The replica id of the protected item.
        /// </summary>
        public readonly string? ReplicaId;
        /// <summary>
        /// The resync progress percentage.
        /// </summary>
        public readonly int? ResyncProgressPercentage;
        /// <summary>
        /// The RPO in seconds.
        /// </summary>
        public readonly int? RpoInSeconds;
        /// <summary>
        /// The selected recovery azure network Id.
        /// </summary>
        public readonly string? SelectedRecoveryAzureNetworkId;
        /// <summary>
        /// The selected source nic Id which will be used as the primary nic during failover.
        /// </summary>
        public readonly string? SelectedSourceNicId;
        /// <summary>
        /// The test failover virtual network.
        /// </summary>
        public readonly string? SelectedTfoAzureNetworkId;
        /// <summary>
        /// The CPU count of the VM on the primary side.
        /// </summary>
        public readonly int? SourceVmCpuCount;
        /// <summary>
        /// The RAM size of the VM on the primary side.
        /// </summary>
        public readonly int? SourceVmRamSizeInMB;
        /// <summary>
        /// The target availability zone.
        /// </summary>
        public readonly string? TargetAvailabilityZone;
        /// <summary>
        /// The target proximity placement group Id.
        /// </summary>
        public readonly string? TargetProximityPlacementGroupId;
        /// <summary>
        /// The ARM Id of the target Azure VM. This value will be null until the VM is failed over. Only after failure it will be populated with the ARM Id of the Azure VM.
        /// </summary>
        public readonly string? TargetVmId;
        /// <summary>
        /// The uncompressed data change rate in MB.
        /// </summary>
        public readonly double? UncompressedDataRateInMB;
        /// <summary>
        /// A value indicating whether managed disks should be used during failover.
        /// </summary>
        public readonly string? UseManagedDisks;
        /// <summary>
        /// The vCenter infrastructure Id.
        /// </summary>
        public readonly string? VCenterInfrastructureId;
        /// <summary>
        /// The validation errors of the on-premise machine Value can be list of validation errors.
        /// </summary>
        public readonly ImmutableArray<Outputs.HealthErrorResponse> ValidationErrors;
        /// <summary>
        /// The OS disk VHD name.
        /// </summary>
        public readonly string? VhdName;
        /// <summary>
        /// The virtual machine Id.
        /// </summary>
        public readonly string? VmId;
        /// <summary>
        /// The PE Network details.
        /// </summary>
        public readonly ImmutableArray<Outputs.VMNicDetailsResponse> VmNics;
        /// <summary>
        /// The protection state for the vm.
        /// </summary>
        public readonly string? VmProtectionState;
        /// <summary>
        /// The protection state description for the vm.
        /// </summary>
        public readonly string? VmProtectionStateDescription;

        [OutputConstructor]
        private InMageAzureV2ReplicationDetailsResponse(
            string? agentExpiryDate,

            string? agentVersion,

            ImmutableArray<Outputs.AzureVmDiskDetailsResponse> azureVMDiskDetails,

            double? compressedDataRateInMB,

            ImmutableArray<string> datastores,

            string? discoveryType,

            string? diskResized,

            string? enableRdpOnTargetOption,

            string? infrastructureVmId,

            string instanceType,

            string? ipAddress,

            string? isAgentUpdateRequired,

            string? isRebootAfterUpdateRequired,

            string? lastHeartbeat,

            string? lastRpoCalculatedTime,

            string? lastUpdateReceivedTime,

            string? licenseType,

            string? masterTargetId,

            string? multiVmGroupId,

            string? multiVmGroupName,

            string? multiVmSyncStatus,

            string? osDiskId,

            string? osType,

            string? osVersion,

            string? processServerId,

            string processServerName,

            ImmutableArray<Outputs.InMageAzureV2ProtectedDiskDetailsResponse> protectedDisks,

            ImmutableArray<Outputs.InMageAzureV2ManagedDiskDetailsResponse> protectedManagedDisks,

            string? protectionStage,

            string? recoveryAvailabilitySetId,

            string? recoveryAzureLogStorageAccountId,

            string? recoveryAzureResourceGroupId,

            string? recoveryAzureStorageAccount,

            string? recoveryAzureVMName,

            string? recoveryAzureVMSize,

            string? replicaId,

            int? resyncProgressPercentage,

            int? rpoInSeconds,

            string? selectedRecoveryAzureNetworkId,

            string? selectedSourceNicId,

            string? selectedTfoAzureNetworkId,

            int? sourceVmCpuCount,

            int? sourceVmRamSizeInMB,

            string? targetAvailabilityZone,

            string? targetProximityPlacementGroupId,

            string? targetVmId,

            double? uncompressedDataRateInMB,

            string? useManagedDisks,

            string? vCenterInfrastructureId,

            ImmutableArray<Outputs.HealthErrorResponse> validationErrors,

            string? vhdName,

            string? vmId,

            ImmutableArray<Outputs.VMNicDetailsResponse> vmNics,

            string? vmProtectionState,

            string? vmProtectionStateDescription)
        {
            AgentExpiryDate = agentExpiryDate;
            AgentVersion = agentVersion;
            AzureVMDiskDetails = azureVMDiskDetails;
            CompressedDataRateInMB = compressedDataRateInMB;
            Datastores = datastores;
            DiscoveryType = discoveryType;
            DiskResized = diskResized;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            InfrastructureVmId = infrastructureVmId;
            InstanceType = instanceType;
            IpAddress = ipAddress;
            IsAgentUpdateRequired = isAgentUpdateRequired;
            IsRebootAfterUpdateRequired = isRebootAfterUpdateRequired;
            LastHeartbeat = lastHeartbeat;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LastUpdateReceivedTime = lastUpdateReceivedTime;
            LicenseType = licenseType;
            MasterTargetId = masterTargetId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            OsDiskId = osDiskId;
            OsType = osType;
            OsVersion = osVersion;
            ProcessServerId = processServerId;
            ProcessServerName = processServerName;
            ProtectedDisks = protectedDisks;
            ProtectedManagedDisks = protectedManagedDisks;
            ProtectionStage = protectionStage;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureVMName = recoveryAzureVMName;
            RecoveryAzureVMSize = recoveryAzureVMSize;
            ReplicaId = replicaId;
            ResyncProgressPercentage = resyncProgressPercentage;
            RpoInSeconds = rpoInSeconds;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedSourceNicId = selectedSourceNicId;
            SelectedTfoAzureNetworkId = selectedTfoAzureNetworkId;
            SourceVmCpuCount = sourceVmCpuCount;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            TargetVmId = targetVmId;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            UseManagedDisks = useManagedDisks;
            VCenterInfrastructureId = vCenterInfrastructureId;
            ValidationErrors = validationErrors;
            VhdName = vhdName;
            VmId = vmId;
            VmNics = vmNics;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
        }
    }
}
