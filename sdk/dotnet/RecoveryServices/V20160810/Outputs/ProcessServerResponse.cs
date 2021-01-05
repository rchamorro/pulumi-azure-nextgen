// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20160810.Outputs
{

    [OutputType]
    public sealed class ProcessServerResponse
    {
        /// <summary>
        /// The version of the scout component on the server.
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// The available memory.
        /// </summary>
        public readonly double? AvailableMemoryInBytes;
        /// <summary>
        /// The available space.
        /// </summary>
        public readonly double? AvailableSpaceInBytes;
        /// <summary>
        /// The percentage of the CPU load.
        /// </summary>
        public readonly string? CpuLoad;
        /// <summary>
        /// The CPU load status.
        /// </summary>
        public readonly string? CpuLoadStatus;
        /// <summary>
        /// The Process Server's friendly name.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// The agent generated Id.
        /// </summary>
        public readonly string? HostId;
        /// <summary>
        /// The Process Server Id.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The IP address of the server.
        /// </summary>
        public readonly string? IpAddress;
        /// <summary>
        /// The last heartbeat received from the server.
        /// </summary>
        public readonly string? LastHeartbeat;
        /// <summary>
        /// The servers configured with this PS.
        /// </summary>
        public readonly string? MachineCount;
        /// <summary>
        /// The memory usage status.
        /// </summary>
        public readonly string? MemoryUsageStatus;
        /// <summary>
        /// The list of the mobility service updates available on the Process Server.
        /// </summary>
        public readonly ImmutableArray<Outputs.MobilityServiceUpdateResponse> MobilityServiceUpdates;
        /// <summary>
        /// The OS type of the server.
        /// </summary>
        public readonly string? OsType;
        /// <summary>
        /// OS Version of the process server. Note: This will get populated if user has CS version greater than 9.12.0.0.
        /// </summary>
        public readonly string? OsVersion;
        /// <summary>
        /// The PS service status.
        /// </summary>
        public readonly string? PsServiceStatus;
        /// <summary>
        /// The number of replication pairs configured in this PS.
        /// </summary>
        public readonly string? ReplicationPairCount;
        /// <summary>
        /// The space usage status.
        /// </summary>
        public readonly string? SpaceUsageStatus;
        /// <summary>
        /// The PS SSL cert expiry date.
        /// </summary>
        public readonly string? SslCertExpiryDate;
        /// <summary>
        /// CS SSL cert expiry date.
        /// </summary>
        public readonly int? SslCertExpiryRemainingDays;
        /// <summary>
        /// The percentage of the system load.
        /// </summary>
        public readonly string? SystemLoad;
        /// <summary>
        /// The system load status.
        /// </summary>
        public readonly string? SystemLoadStatus;
        /// <summary>
        /// The total memory.
        /// </summary>
        public readonly double? TotalMemoryInBytes;
        /// <summary>
        /// The total space.
        /// </summary>
        public readonly double? TotalSpaceInBytes;
        /// <summary>
        /// Version status
        /// </summary>
        public readonly string? VersionStatus;

        [OutputConstructor]
        private ProcessServerResponse(
            string? agentVersion,

            double? availableMemoryInBytes,

            double? availableSpaceInBytes,

            string? cpuLoad,

            string? cpuLoadStatus,

            string? friendlyName,

            string? hostId,

            string? id,

            string? ipAddress,

            string? lastHeartbeat,

            string? machineCount,

            string? memoryUsageStatus,

            ImmutableArray<Outputs.MobilityServiceUpdateResponse> mobilityServiceUpdates,

            string? osType,

            string? osVersion,

            string? psServiceStatus,

            string? replicationPairCount,

            string? spaceUsageStatus,

            string? sslCertExpiryDate,

            int? sslCertExpiryRemainingDays,

            string? systemLoad,

            string? systemLoadStatus,

            double? totalMemoryInBytes,

            double? totalSpaceInBytes,

            string? versionStatus)
        {
            AgentVersion = agentVersion;
            AvailableMemoryInBytes = availableMemoryInBytes;
            AvailableSpaceInBytes = availableSpaceInBytes;
            CpuLoad = cpuLoad;
            CpuLoadStatus = cpuLoadStatus;
            FriendlyName = friendlyName;
            HostId = hostId;
            Id = id;
            IpAddress = ipAddress;
            LastHeartbeat = lastHeartbeat;
            MachineCount = machineCount;
            MemoryUsageStatus = memoryUsageStatus;
            MobilityServiceUpdates = mobilityServiceUpdates;
            OsType = osType;
            OsVersion = osVersion;
            PsServiceStatus = psServiceStatus;
            ReplicationPairCount = replicationPairCount;
            SpaceUsageStatus = spaceUsageStatus;
            SslCertExpiryDate = sslCertExpiryDate;
            SslCertExpiryRemainingDays = sslCertExpiryRemainingDays;
            SystemLoad = systemLoad;
            SystemLoadStatus = systemLoadStatus;
            TotalMemoryInBytes = totalMemoryInBytes;
            TotalSpaceInBytes = totalSpaceInBytes;
            VersionStatus = versionStatus;
        }
    }
}
