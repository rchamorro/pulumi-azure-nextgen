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
    public sealed class PrivateEndpointResponse
    {
        /// <summary>
        /// An array of custom dns configurations.
        /// </summary>
        public readonly ImmutableArray<Outputs.CustomDnsConfigPropertiesFormatResponse> CustomDnsConfigs;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The extended location of the load balancer.
        /// </summary>
        public readonly Outputs.ExtendedLocationResponse? ExtendedLocation;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateLinkServiceConnectionResponse> ManualPrivateLinkServiceConnections;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// An array of references to the network interfaces created for this private endpoint.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceResponse> NetworkInterfaces;
        /// <summary>
        /// A grouping of information about the connection to the remote resource.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateLinkServiceConnectionResponse> PrivateLinkServiceConnections;
        /// <summary>
        /// The provisioning state of the private endpoint resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The ID of the subnet from which the private IP will be allocated.
        /// </summary>
        public readonly Outputs.SubnetResponse? Subnet;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PrivateEndpointResponse(
            ImmutableArray<Outputs.CustomDnsConfigPropertiesFormatResponse> customDnsConfigs,

            string etag,

            Outputs.ExtendedLocationResponse? extendedLocation,

            string? id,

            string? location,

            ImmutableArray<Outputs.PrivateLinkServiceConnectionResponse> manualPrivateLinkServiceConnections,

            string name,

            ImmutableArray<Outputs.NetworkInterfaceResponse> networkInterfaces,

            ImmutableArray<Outputs.PrivateLinkServiceConnectionResponse> privateLinkServiceConnections,

            string provisioningState,

            Outputs.SubnetResponse? subnet,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CustomDnsConfigs = customDnsConfigs;
            Etag = etag;
            ExtendedLocation = extendedLocation;
            Id = id;
            Location = location;
            ManualPrivateLinkServiceConnections = manualPrivateLinkServiceConnections;
            Name = name;
            NetworkInterfaces = networkInterfaces;
            PrivateLinkServiceConnections = privateLinkServiceConnections;
            ProvisioningState = provisioningState;
            Subnet = subnet;
            Tags = tags;
            Type = type;
        }
    }
}
