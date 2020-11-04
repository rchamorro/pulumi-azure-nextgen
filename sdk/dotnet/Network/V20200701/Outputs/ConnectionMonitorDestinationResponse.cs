// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class ConnectionMonitorDestinationResponse
    {
        /// <summary>
        /// Address of the connection monitor destination (IP or domain name).
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// The destination port used by connection monitor.
        /// </summary>
        public readonly int? Port;
        /// <summary>
        /// The ID of the resource used as the destination by connection monitor.
        /// </summary>
        public readonly string? ResourceId;

        [OutputConstructor]
        private ConnectionMonitorDestinationResponse(
            string? address,

            int? port,

            string? resourceId)
        {
            Address = address;
            Port = port;
            ResourceId = resourceId;
        }
    }
}
