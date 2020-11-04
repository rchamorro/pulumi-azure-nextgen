// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest.Outputs
{

    [OutputType]
    public sealed class VirtualNetworkPeeringResponse
    {
        /// <summary>
        /// Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network.
        /// </summary>
        public readonly bool? AllowForwardedTraffic;
        /// <summary>
        /// If gateway links can be used in remote virtual networking to link to this virtual network.
        /// </summary>
        public readonly bool? AllowGatewayTransit;
        /// <summary>
        /// Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space.
        /// </summary>
        public readonly bool? AllowVirtualNetworkAccess;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The status of the virtual network peering.
        /// </summary>
        public readonly string? PeeringState;
        /// <summary>
        /// The peering sync status of the virtual network peering.
        /// </summary>
        public readonly string? PeeringSyncLevel;
        /// <summary>
        /// The provisioning state of the virtual network peering resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The reference to the address space peered with the remote virtual network.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? RemoteAddressSpace;
        /// <summary>
        /// The reference to the remote virtual network's Bgp Communities.
        /// </summary>
        public readonly Outputs.VirtualNetworkBgpCommunitiesResponse? RemoteBgpCommunities;
        /// <summary>
        /// The reference to the remote virtual network. The remote virtual network can be in the same or different region (preview). See here to register for the preview and learn more (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
        /// </summary>
        public readonly Outputs.SubResourceResponse? RemoteVirtualNetwork;
        /// <summary>
        /// The reference to the current address space of the remote virtual network.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? RemoteVirtualNetworkAddressSpace;
        /// <summary>
        /// Provided when user wants to sync the peering with address space on the remote virtual network after the address space is updated.
        /// </summary>
        public readonly bool? SyncRemoteAddressSpace;
        /// <summary>
        /// If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
        /// </summary>
        public readonly bool? UseRemoteGateways;

        [OutputConstructor]
        private VirtualNetworkPeeringResponse(
            bool? allowForwardedTraffic,

            bool? allowGatewayTransit,

            bool? allowVirtualNetworkAccess,

            string etag,

            string? id,

            string? name,

            string? peeringState,

            string? peeringSyncLevel,

            string provisioningState,

            Outputs.AddressSpaceResponse? remoteAddressSpace,

            Outputs.VirtualNetworkBgpCommunitiesResponse? remoteBgpCommunities,

            Outputs.SubResourceResponse? remoteVirtualNetwork,

            Outputs.AddressSpaceResponse? remoteVirtualNetworkAddressSpace,

            bool? syncRemoteAddressSpace,

            bool? useRemoteGateways)
        {
            AllowForwardedTraffic = allowForwardedTraffic;
            AllowGatewayTransit = allowGatewayTransit;
            AllowVirtualNetworkAccess = allowVirtualNetworkAccess;
            Etag = etag;
            Id = id;
            Name = name;
            PeeringState = peeringState;
            PeeringSyncLevel = peeringSyncLevel;
            ProvisioningState = provisioningState;
            RemoteAddressSpace = remoteAddressSpace;
            RemoteBgpCommunities = remoteBgpCommunities;
            RemoteVirtualNetwork = remoteVirtualNetwork;
            RemoteVirtualNetworkAddressSpace = remoteVirtualNetworkAddressSpace;
            SyncRemoteAddressSpace = syncRemoteAddressSpace;
            UseRemoteGateways = useRemoteGateways;
        }
    }
}
