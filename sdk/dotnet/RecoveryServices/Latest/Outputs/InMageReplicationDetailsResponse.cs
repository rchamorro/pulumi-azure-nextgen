// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.Latest.Outputs
{

    [OutputType]
    public sealed class InMageReplicationDetailsResponse
    {
        /// <summary>
        /// The active location of the VM. If the VM is being protected from Azure, this field will take values from { Azure, OnPrem }. If the VM is being protected between two data-centers, this field will be OnPrem always.
        /// </summary>
        public readonly string? ActiveSiteType;
        /// <summary>
        /// The agent details.
        /// </summary>
        public readonly Outputs.InMageAgentDetailsResponse? AgentDetails;
        /// <summary>
        /// A value indicating the underlying Azure storage account. If the VM is not running in Azure, this value shall be set to null.
        /// </summary>
        public readonly string? AzureStorageAccountId;
        /// <summary>
        /// The compressed data change rate in MB.
        /// </summary>
        public readonly double? CompressedDataRateInMB;
        /// <summary>
        /// The collection of Consistency points.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? ConsistencyPoints;
        /// <summary>
        /// The data stores of the on-premise machine Value can be list of strings that contain data store names
        /// </summary>
        public readonly ImmutableArray<string> Datastores;
        /// <summary>
        /// A value indicating the discovery type of the machine.
        /// </summary>
        public readonly string? DiscoveryType;
        /// <summary>
        /// A value indicating whether any disk is resized for this VM.
        /// </summary>
        public readonly string? DiskResized;
        /// <summary>
        /// The infrastructure VM Id.
        /// </summary>
        public readonly string? InfrastructureVmId;
        /// <summary>
        /// Gets the Instance type.
        /// Expected value is 'InMage'.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The source IP address.
        /// </summary>
        public readonly string? IpAddress;
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
        /// The master target Id.
        /// </summary>
        public readonly string? MasterTargetId;
        /// <summary>
        /// The multi vm group Id, if any.
        /// </summary>
        public readonly string? MultiVmGroupId;
        /// <summary>
        /// The multi vm group name, if any.
        /// </summary>
        public readonly string? MultiVmGroupName;
        /// <summary>
        /// A value indicating whether the multi vm sync is enabled or disabled.
        /// </summary>
        public readonly string? MultiVmSyncStatus;
        /// <summary>
        /// The OS details.
        /// </summary>
        public readonly Outputs.OSDiskDetailsResponse? OsDetails;
        /// <summary>
        /// The OS Version of the protected item.
        /// </summary>
        public readonly string? OsVersion;
        /// <summary>
        /// The process server Id.
        /// </summary>
        public readonly string? ProcessServerId;
        /// <summary>
        /// The list of protected disks.
        /// </summary>
        public readonly ImmutableArray<Outputs.InMageProtectedDiskDetailsResponse> ProtectedDisks;
        /// <summary>
        /// The protection stage.
        /// </summary>
        public readonly string? ProtectionStage;
        /// <summary>
        /// A value indicating whether the source server requires a restart after update.
        /// </summary>
        public readonly string? RebootAfterUpdateStatus;
        /// <summary>
        /// The replica id of the protected item.
        /// </summary>
        public readonly string? ReplicaId;
        /// <summary>
        /// The resync details of the machine
        /// </summary>
        public readonly Outputs.InitialReplicationDetailsResponse? ResyncDetails;
        /// <summary>
        /// The retention window end time.
        /// </summary>
        public readonly string? RetentionWindowEnd;
        /// <summary>
        /// The retention window start time.
        /// </summary>
        public readonly string? RetentionWindowStart;
        /// <summary>
        /// The RPO in seconds.
        /// </summary>
        public readonly double? RpoInSeconds;
        /// <summary>
        /// The CPU count of the VM on the primary side.
        /// </summary>
        public readonly int? SourceVmCpuCount;
        /// <summary>
        /// The RAM size of the VM on the primary side.
        /// </summary>
        public readonly int? SourceVmRamSizeInMB;
        /// <summary>
        /// The uncompressed data change rate in MB.
        /// </summary>
        public readonly double? UncompressedDataRateInMB;
        /// <summary>
        /// The vCenter infrastructure Id.
        /// </summary>
        public readonly string? VCenterInfrastructureId;
        /// <summary>
        /// The validation errors of the on-premise machine Value can be list of validation errors
        /// </summary>
        public readonly ImmutableArray<Outputs.HealthErrorResponse> ValidationErrors;
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
        private InMageReplicationDetailsResponse(
            string? activeSiteType,

            Outputs.InMageAgentDetailsResponse? agentDetails,

            string? azureStorageAccountId,

            double? compressedDataRateInMB,

            ImmutableDictionary<string, string>? consistencyPoints,

            ImmutableArray<string> datastores,

            string? discoveryType,

            string? diskResized,

            string? infrastructureVmId,

            string instanceType,

            string? ipAddress,

            string? lastHeartbeat,

            string? lastRpoCalculatedTime,

            string? lastUpdateReceivedTime,

            string? masterTargetId,

            string? multiVmGroupId,

            string? multiVmGroupName,

            string? multiVmSyncStatus,

            Outputs.OSDiskDetailsResponse? osDetails,

            string? osVersion,

            string? processServerId,

            ImmutableArray<Outputs.InMageProtectedDiskDetailsResponse> protectedDisks,

            string? protectionStage,

            string? rebootAfterUpdateStatus,

            string? replicaId,

            Outputs.InitialReplicationDetailsResponse? resyncDetails,

            string? retentionWindowEnd,

            string? retentionWindowStart,

            double? rpoInSeconds,

            int? sourceVmCpuCount,

            int? sourceVmRamSizeInMB,

            double? uncompressedDataRateInMB,

            string? vCenterInfrastructureId,

            ImmutableArray<Outputs.HealthErrorResponse> validationErrors,

            string? vmId,

            ImmutableArray<Outputs.VMNicDetailsResponse> vmNics,

            string? vmProtectionState,

            string? vmProtectionStateDescription)
        {
            ActiveSiteType = activeSiteType;
            AgentDetails = agentDetails;
            AzureStorageAccountId = azureStorageAccountId;
            CompressedDataRateInMB = compressedDataRateInMB;
            ConsistencyPoints = consistencyPoints;
            Datastores = datastores;
            DiscoveryType = discoveryType;
            DiskResized = diskResized;
            InfrastructureVmId = infrastructureVmId;
            InstanceType = instanceType;
            IpAddress = ipAddress;
            LastHeartbeat = lastHeartbeat;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LastUpdateReceivedTime = lastUpdateReceivedTime;
            MasterTargetId = masterTargetId;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            OsDetails = osDetails;
            OsVersion = osVersion;
            ProcessServerId = processServerId;
            ProtectedDisks = protectedDisks;
            ProtectionStage = protectionStage;
            RebootAfterUpdateStatus = rebootAfterUpdateStatus;
            ReplicaId = replicaId;
            ResyncDetails = resyncDetails;
            RetentionWindowEnd = retentionWindowEnd;
            RetentionWindowStart = retentionWindowStart;
            RpoInSeconds = rpoInSeconds;
            SourceVmCpuCount = sourceVmCpuCount;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            VCenterInfrastructureId = vCenterInfrastructureId;
            ValidationErrors = validationErrors;
            VmId = vmId;
            VmNics = vmNics;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
        }
    }
}
