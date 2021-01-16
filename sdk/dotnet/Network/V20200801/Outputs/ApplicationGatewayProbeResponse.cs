// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayProbeResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Host name to send the probe to.
        /// </summary>
        public readonly string? Host;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The probing interval in seconds. This is the time interval between two consecutive probes. Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        public readonly int? Interval;
        /// <summary>
        /// Criterion for classifying a healthy probe response.
        /// </summary>
        public readonly Outputs.ApplicationGatewayProbeHealthResponseMatchResponse? Match;
        /// <summary>
        /// Minimum number of servers that are always marked healthy. Default value is 0.
        /// </summary>
        public readonly int? MinServers;
        /// <summary>
        /// Name of the probe that is unique within an Application Gateway.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Relative path of probe. Valid path starts from '/'. Probe is sent to &lt;Protocol&gt;://&lt;host&gt;:&lt;port&gt;&lt;path&gt;.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// Whether the host header should be picked from the backend http settings. Default value is false.
        /// </summary>
        public readonly bool? PickHostNameFromBackendHttpSettings;
        /// <summary>
        /// Custom port which will be used for probing the backend servers. The valid value ranges from 1 to 65535. In case not set, port from http settings will be used. This property is valid for Standard_v2 and WAF_v2 only.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The protocol used for the probe.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// The provisioning state of the probe resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
        /// </summary>
        public readonly int? Timeout;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The probe retry count. Backend server is marked down after consecutive probe failure count reaches UnhealthyThreshold. Acceptable values are from 1 second to 20.
        /// </summary>
        public readonly int? UnhealthyThreshold;

        [OutputConstructor]
        private ApplicationGatewayProbeResponse(
            string etag,

            string? host,

            string? id,

            int? interval,

            Outputs.ApplicationGatewayProbeHealthResponseMatchResponse? match,

            int? minServers,

            string? name,

            string? path,

            bool? pickHostNameFromBackendHttpSettings,

            int? port,

            string? protocol,

            string provisioningState,

            int? timeout,

            string type,

            int? unhealthyThreshold)
        {
            Etag = etag;
            Host = host;
            Id = id;
            Interval = interval;
            Match = match;
            MinServers = minServers;
            Name = name;
            Path = path;
            PickHostNameFromBackendHttpSettings = pickHostNameFromBackendHttpSettings;
            Port = port;
            Protocol = protocol;
            ProvisioningState = provisioningState;
            Timeout = timeout;
            Type = type;
            UnhealthyThreshold = unhealthyThreshold;
        }
    }
}
