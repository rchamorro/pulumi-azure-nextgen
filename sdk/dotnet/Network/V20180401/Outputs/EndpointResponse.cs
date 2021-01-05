// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180401.Outputs
{

    [OutputType]
    public sealed class EndpointResponse
    {
        /// <summary>
        /// List of custom headers.
        /// </summary>
        public readonly ImmutableArray<Outputs.EndpointPropertiesResponseCustomHeaders> CustomHeaders;
        /// <summary>
        /// Specifies the location of the external or nested endpoints when using the 'Performance' traffic routing method.
        /// </summary>
        public readonly string? EndpointLocation;
        /// <summary>
        /// The monitoring status of the endpoint.
        /// </summary>
        public readonly string? EndpointMonitorStatus;
        /// <summary>
        /// The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method.
        /// </summary>
        public readonly string? EndpointStatus;
        /// <summary>
        /// The list of countries/regions mapped to this endpoint when using the 'Geographic' traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values.
        /// </summary>
        public readonly ImmutableArray<string> GeoMapping;
        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/trafficManagerProfiles/{resourceName}
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.
        /// </summary>
        public readonly double? MinChildEndpoints;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The priority of this endpoint when using the 'Priority' traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value.
        /// </summary>
        public readonly double? Priority;
        /// <summary>
        /// The list of subnets, IP addresses, and/or address ranges mapped to this endpoint when using the 'Subnet' traffic routing method. An empty list will match all ranges not covered by other endpoints.
        /// </summary>
        public readonly ImmutableArray<Outputs.EndpointPropertiesResponseSubnets> Subnets;
        /// <summary>
        /// The fully-qualified DNS name or IP address of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint.
        /// </summary>
        public readonly string? Target;
        /// <summary>
        /// The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.
        /// </summary>
        public readonly string? TargetResourceId;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000.
        /// </summary>
        public readonly double? Weight;

        [OutputConstructor]
        private EndpointResponse(
            ImmutableArray<Outputs.EndpointPropertiesResponseCustomHeaders> customHeaders,

            string? endpointLocation,

            string? endpointMonitorStatus,

            string? endpointStatus,

            ImmutableArray<string> geoMapping,

            string? id,

            double? minChildEndpoints,

            string? name,

            double? priority,

            ImmutableArray<Outputs.EndpointPropertiesResponseSubnets> subnets,

            string? target,

            string? targetResourceId,

            string? type,

            double? weight)
        {
            CustomHeaders = customHeaders;
            EndpointLocation = endpointLocation;
            EndpointMonitorStatus = endpointMonitorStatus;
            EndpointStatus = endpointStatus;
            GeoMapping = geoMapping;
            Id = id;
            MinChildEndpoints = minChildEndpoints;
            Name = name;
            Priority = priority;
            Subnets = subnets;
            Target = target;
            TargetResourceId = targetResourceId;
            Type = type;
            Weight = weight;
        }
    }
}
