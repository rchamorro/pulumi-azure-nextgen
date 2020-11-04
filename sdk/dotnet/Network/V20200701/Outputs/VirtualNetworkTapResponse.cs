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
    public sealed class VirtualNetworkTapResponse
    {
        /// <summary>
        /// The reference to the private IP address on the internal Load Balancer that will receive the tap.
        /// </summary>
        public readonly Outputs.FrontendIPConfigurationResponse? DestinationLoadBalancerFrontEndIPConfiguration;
        /// <summary>
        /// The reference to the private IP Address of the collector nic that will receive the tap.
        /// </summary>
        public readonly Outputs.NetworkInterfaceIPConfigurationResponse? DestinationNetworkInterfaceIPConfiguration;
        /// <summary>
        /// The VXLAN destination port that will receive the tapped traffic.
        /// </summary>
        public readonly int? DestinationPort;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the list of resource IDs for the network interface IP configuration that needs to be tapped.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceTapConfigurationResponse> NetworkInterfaceTapConfigurations;
        /// <summary>
        /// The provisioning state of the virtual network tap resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource GUID property of the virtual network tap resource.
        /// </summary>
        public readonly string ResourceGuid;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private VirtualNetworkTapResponse(
            Outputs.FrontendIPConfigurationResponse? destinationLoadBalancerFrontEndIPConfiguration,

            Outputs.NetworkInterfaceIPConfigurationResponse? destinationNetworkInterfaceIPConfiguration,

            int? destinationPort,

            string etag,

            string? id,

            string? location,

            string name,

            ImmutableArray<Outputs.NetworkInterfaceTapConfigurationResponse> networkInterfaceTapConfigurations,

            string provisioningState,

            string resourceGuid,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            DestinationLoadBalancerFrontEndIPConfiguration = destinationLoadBalancerFrontEndIPConfiguration;
            DestinationNetworkInterfaceIPConfiguration = destinationNetworkInterfaceIPConfiguration;
            DestinationPort = destinationPort;
            Etag = etag;
            Id = id;
            Location = location;
            Name = name;
            NetworkInterfaceTapConfigurations = networkInterfaceTapConfigurations;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            Tags = tags;
            Type = type;
        }
    }
}
