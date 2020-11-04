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
    public sealed class ConnectionMonitorEndpointResponse
    {
        /// <summary>
        /// Address of the connection monitor endpoint (IP or domain name).
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// Test coverage for the endpoint.
        /// </summary>
        public readonly string? CoverageLevel;
        /// <summary>
        /// Filter for sub-items within the endpoint.
        /// </summary>
        public readonly Outputs.ConnectionMonitorEndpointFilterResponse? Filter;
        /// <summary>
        /// The name of the connection monitor endpoint.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource ID of the connection monitor endpoint.
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// Endpoint scope.
        /// </summary>
        public readonly Outputs.ConnectionMonitorEndpointScopeResponse? Scope;
        /// <summary>
        /// The endpoint type.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ConnectionMonitorEndpointResponse(
            string? address,

            string? coverageLevel,

            Outputs.ConnectionMonitorEndpointFilterResponse? filter,

            string name,

            string? resourceId,

            Outputs.ConnectionMonitorEndpointScopeResponse? scope,

            string? type)
        {
            Address = address;
            CoverageLevel = coverageLevel;
            Filter = filter;
            Name = name;
            ResourceId = resourceId;
            Scope = scope;
            Type = type;
        }
    }
}
