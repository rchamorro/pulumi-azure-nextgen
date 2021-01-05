// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170501.Outputs
{

    [OutputType]
    public sealed class MonitorConfigResponse
    {
        /// <summary>
        /// The monitor interval for endpoints in this profile. This is the interval at which Traffic Manager will check the health of each endpoint in this profile.
        /// </summary>
        public readonly double? IntervalInSeconds;
        /// <summary>
        /// The path relative to the endpoint domain name used to probe for endpoint health.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The TCP port used to probe for endpoint health.
        /// </summary>
        public readonly double? Port;
        /// <summary>
        /// The profile-level monitoring status of the Traffic Manager profile.
        /// </summary>
        public readonly string? ProfileMonitorStatus;
        /// <summary>
        /// The protocol (HTTP, HTTPS or TCP) used to probe for endpoint health.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// The monitor timeout for endpoints in this profile. This is the time that Traffic Manager allows endpoints in this profile to response to the health check.
        /// </summary>
        public readonly double? TimeoutInSeconds;
        /// <summary>
        /// The number of consecutive failed health check that Traffic Manager tolerates before declaring an endpoint in this profile Degraded after the next failed health check.
        /// </summary>
        public readonly double? ToleratedNumberOfFailures;

        [OutputConstructor]
        private MonitorConfigResponse(
            double? intervalInSeconds,

            string? path,

            double? port,

            string? profileMonitorStatus,

            string? protocol,

            double? timeoutInSeconds,

            double? toleratedNumberOfFailures)
        {
            IntervalInSeconds = intervalInSeconds;
            Path = path;
            Port = port;
            ProfileMonitorStatus = profileMonitorStatus;
            Protocol = protocol;
            TimeoutInSeconds = timeoutInSeconds;
            ToleratedNumberOfFailures = toleratedNumberOfFailures;
        }
    }
}
