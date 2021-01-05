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
    public sealed class VMwareDetailsResponse
    {
        /// <summary>
        /// The number of source and target servers configured to talk to this CS.
        /// </summary>
        public readonly string? AgentCount;
        /// <summary>
        /// Agent expiry date.
        /// </summary>
        public readonly string? AgentExpiryDate;
        /// <summary>
        /// The agent Version.
        /// </summary>
        public readonly string? AgentVersion;
        /// <summary>
        /// The agent version details.
        /// </summary>
        public readonly Outputs.VersionDetailsResponse? AgentVersionDetails;
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
        /// The CS service status.
        /// </summary>
        public readonly string? CsServiceStatus;
        /// <summary>
        /// The database server load.
        /// </summary>
        public readonly string? DatabaseServerLoad;
        /// <summary>
        /// The database server load status.
        /// </summary>
        public readonly string? DatabaseServerLoadStatus;
        /// <summary>
        /// The host name.
        /// </summary>
        public readonly string? HostName;
        /// <summary>
        /// Gets the class type. Overridden in derived classes.
        /// Expected value is 'VMware'.
        /// </summary>
        public readonly string InstanceType;
        /// <summary>
        /// The IP address.
        /// </summary>
        public readonly string? IpAddress;
        /// <summary>
        /// The last heartbeat received from CS server.
        /// </summary>
        public readonly string? LastHeartbeat;
        /// <summary>
        /// The list of Master Target servers associated with the fabric.
        /// </summary>
        public readonly ImmutableArray<Outputs.MasterTargetServerResponse> MasterTargetServers;
        /// <summary>
        /// The memory usage status.
        /// </summary>
        public readonly string? MemoryUsageStatus;
        /// <summary>
        /// The number of process servers.
        /// </summary>
        public readonly string? ProcessServerCount;
        /// <summary>
        /// The list of Process Servers associated with the fabric.
        /// </summary>
        public readonly ImmutableArray<Outputs.ProcessServerResponse> ProcessServers;
        /// <summary>
        /// The number of protected servers.
        /// </summary>
        public readonly string? ProtectedServers;
        /// <summary>
        /// PS template version.
        /// </summary>
        public readonly string? PsTemplateVersion;
        /// <summary>
        /// The number of replication pairs configured in this CS.
        /// </summary>
        public readonly string? ReplicationPairCount;
        /// <summary>
        /// The list of run as accounts created on the server.
        /// </summary>
        public readonly ImmutableArray<Outputs.RunAsAccountResponse> RunAsAccounts;
        /// <summary>
        /// The space usage status.
        /// </summary>
        public readonly string? SpaceUsageStatus;
        /// <summary>
        /// CS SSL cert expiry date.
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
        /// <summary>
        /// The web load.
        /// </summary>
        public readonly string? WebLoad;
        /// <summary>
        /// The web load status.
        /// </summary>
        public readonly string? WebLoadStatus;

        [OutputConstructor]
        private VMwareDetailsResponse(
            string? agentCount,

            string? agentExpiryDate,

            string? agentVersion,

            Outputs.VersionDetailsResponse? agentVersionDetails,

            double? availableMemoryInBytes,

            double? availableSpaceInBytes,

            string? cpuLoad,

            string? cpuLoadStatus,

            string? csServiceStatus,

            string? databaseServerLoad,

            string? databaseServerLoadStatus,

            string? hostName,

            string instanceType,

            string? ipAddress,

            string? lastHeartbeat,

            ImmutableArray<Outputs.MasterTargetServerResponse> masterTargetServers,

            string? memoryUsageStatus,

            string? processServerCount,

            ImmutableArray<Outputs.ProcessServerResponse> processServers,

            string? protectedServers,

            string? psTemplateVersion,

            string? replicationPairCount,

            ImmutableArray<Outputs.RunAsAccountResponse> runAsAccounts,

            string? spaceUsageStatus,

            string? sslCertExpiryDate,

            int? sslCertExpiryRemainingDays,

            string? systemLoad,

            string? systemLoadStatus,

            double? totalMemoryInBytes,

            double? totalSpaceInBytes,

            string? versionStatus,

            string? webLoad,

            string? webLoadStatus)
        {
            AgentCount = agentCount;
            AgentExpiryDate = agentExpiryDate;
            AgentVersion = agentVersion;
            AgentVersionDetails = agentVersionDetails;
            AvailableMemoryInBytes = availableMemoryInBytes;
            AvailableSpaceInBytes = availableSpaceInBytes;
            CpuLoad = cpuLoad;
            CpuLoadStatus = cpuLoadStatus;
            CsServiceStatus = csServiceStatus;
            DatabaseServerLoad = databaseServerLoad;
            DatabaseServerLoadStatus = databaseServerLoadStatus;
            HostName = hostName;
            InstanceType = instanceType;
            IpAddress = ipAddress;
            LastHeartbeat = lastHeartbeat;
            MasterTargetServers = masterTargetServers;
            MemoryUsageStatus = memoryUsageStatus;
            ProcessServerCount = processServerCount;
            ProcessServers = processServers;
            ProtectedServers = protectedServers;
            PsTemplateVersion = psTemplateVersion;
            ReplicationPairCount = replicationPairCount;
            RunAsAccounts = runAsAccounts;
            SpaceUsageStatus = spaceUsageStatus;
            SslCertExpiryDate = sslCertExpiryDate;
            SslCertExpiryRemainingDays = sslCertExpiryRemainingDays;
            SystemLoad = systemLoad;
            SystemLoadStatus = systemLoadStatus;
            TotalMemoryInBytes = totalMemoryInBytes;
            TotalSpaceInBytes = totalSpaceInBytes;
            VersionStatus = versionStatus;
            WebLoad = webLoad;
            WebLoadStatus = webLoadStatus;
        }
    }
}
