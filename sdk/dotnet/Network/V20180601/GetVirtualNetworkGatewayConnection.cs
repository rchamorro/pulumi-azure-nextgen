// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601
{
    public static class GetVirtualNetworkGatewayConnection
    {
        public static Task<GetVirtualNetworkGatewayConnectionResult> InvokeAsync(GetVirtualNetworkGatewayConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualNetworkGatewayConnectionResult>("azure-nextgen:network/v20180601:getVirtualNetworkGatewayConnection", args ?? new GetVirtualNetworkGatewayConnectionArgs(), options.WithVersion());
    }


    public sealed class GetVirtualNetworkGatewayConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the virtual network gateway connection.
        /// </summary>
        [Input("virtualNetworkGatewayConnectionName", required: true)]
        public string VirtualNetworkGatewayConnectionName { get; set; } = null!;

        public GetVirtualNetworkGatewayConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualNetworkGatewayConnectionResult
    {
        /// <summary>
        /// The authorizationKey.
        /// </summary>
        public readonly string? AuthorizationKey;
        /// <summary>
        /// Virtual network Gateway connection status. Possible values are 'Unknown', 'Connecting', 'Connected' and 'NotConnected'.
        /// </summary>
        public readonly string ConnectionStatus;
        /// <summary>
        /// Gateway connection type. Possible values are: 'IPsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
        /// </summary>
        public readonly string ConnectionType;
        /// <summary>
        /// The egress bytes transferred in this connection.
        /// </summary>
        public readonly double EgressBytesTransferred;
        /// <summary>
        /// EnableBgp flag
        /// </summary>
        public readonly bool? EnableBgp;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The ingress bytes transferred in this connection.
        /// </summary>
        public readonly double IngressBytesTransferred;
        /// <summary>
        /// The IPSec Policies to be considered by this connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.IpsecPolicyResponse> IpsecPolicies;
        /// <summary>
        /// The reference to local network gateway resource.
        /// </summary>
        public readonly Outputs.LocalNetworkGatewayResponse? LocalNetworkGateway2;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The reference to peerings resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Peer;
        /// <summary>
        /// The provisioning state of the VirtualNetworkGatewayConnection resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource GUID property of the VirtualNetworkGatewayConnection resource.
        /// </summary>
        public readonly string? ResourceGuid;
        /// <summary>
        /// The routing weight.
        /// </summary>
        public readonly int? RoutingWeight;
        /// <summary>
        /// The IPSec shared key.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Collection of all tunnels' connection health status.
        /// </summary>
        public readonly ImmutableArray<Outputs.TunnelConnectionHealthResponse> TunnelConnectionStatus;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        public readonly bool? UsePolicyBasedTrafficSelectors;
        /// <summary>
        /// The reference to virtual network gateway resource.
        /// </summary>
        public readonly Outputs.VirtualNetworkGatewayResponse VirtualNetworkGateway1;
        /// <summary>
        /// The reference to virtual network gateway resource.
        /// </summary>
        public readonly Outputs.VirtualNetworkGatewayResponse? VirtualNetworkGateway2;

        [OutputConstructor]
        private GetVirtualNetworkGatewayConnectionResult(
            string? authorizationKey,

            string connectionStatus,

            string connectionType,

            double egressBytesTransferred,

            bool? enableBgp,

            string? etag,

            string? id,

            double ingressBytesTransferred,

            ImmutableArray<Outputs.IpsecPolicyResponse> ipsecPolicies,

            Outputs.LocalNetworkGatewayResponse? localNetworkGateway2,

            string? location,

            string name,

            Outputs.SubResourceResponse? peer,

            string provisioningState,

            string? resourceGuid,

            int? routingWeight,

            string? sharedKey,

            ImmutableDictionary<string, string>? tags,

            ImmutableArray<Outputs.TunnelConnectionHealthResponse> tunnelConnectionStatus,

            string type,

            bool? usePolicyBasedTrafficSelectors,

            Outputs.VirtualNetworkGatewayResponse virtualNetworkGateway1,

            Outputs.VirtualNetworkGatewayResponse? virtualNetworkGateway2)
        {
            AuthorizationKey = authorizationKey;
            ConnectionStatus = connectionStatus;
            ConnectionType = connectionType;
            EgressBytesTransferred = egressBytesTransferred;
            EnableBgp = enableBgp;
            Etag = etag;
            Id = id;
            IngressBytesTransferred = ingressBytesTransferred;
            IpsecPolicies = ipsecPolicies;
            LocalNetworkGateway2 = localNetworkGateway2;
            Location = location;
            Name = name;
            Peer = peer;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            Tags = tags;
            TunnelConnectionStatus = tunnelConnectionStatus;
            Type = type;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            VirtualNetworkGateway1 = virtualNetworkGateway1;
            VirtualNetworkGateway2 = virtualNetworkGateway2;
        }
    }
}
