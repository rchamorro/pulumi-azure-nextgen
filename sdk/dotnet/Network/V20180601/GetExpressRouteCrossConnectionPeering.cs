// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601
{
    public static class GetExpressRouteCrossConnectionPeering
    {
        public static Task<GetExpressRouteCrossConnectionPeeringResult> InvokeAsync(GetExpressRouteCrossConnectionPeeringArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetExpressRouteCrossConnectionPeeringResult>("azure-nextgen:network/v20180601:getExpressRouteCrossConnectionPeering", args ?? new GetExpressRouteCrossConnectionPeeringArgs(), options.WithVersion());
    }


    public sealed class GetExpressRouteCrossConnectionPeeringArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the ExpressRouteCrossConnection.
        /// </summary>
        [Input("crossConnectionName", required: true)]
        public string CrossConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the peering.
        /// </summary>
        [Input("peeringName", required: true)]
        public string PeeringName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetExpressRouteCrossConnectionPeeringArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetExpressRouteCrossConnectionPeeringResult
    {
        /// <summary>
        /// The Azure ASN.
        /// </summary>
        public readonly int AzureASN;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        public readonly string? GatewayManagerEtag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The IPv6 peering configuration.
        /// </summary>
        public readonly Outputs.Ipv6ExpressRouteCircuitPeeringConfigResponse? Ipv6PeeringConfig;
        /// <summary>
        /// Gets whether the provider or the customer last modified the peering.
        /// </summary>
        public readonly string? LastModifiedBy;
        /// <summary>
        /// The Microsoft peering configuration.
        /// </summary>
        public readonly Outputs.ExpressRouteCircuitPeeringConfigResponse? MicrosoftPeeringConfig;
        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The peer ASN.
        /// </summary>
        public readonly double? PeerASN;
        /// <summary>
        /// The peering type.
        /// </summary>
        public readonly string? PeeringType;
        /// <summary>
        /// The primary port.
        /// </summary>
        public readonly string PrimaryAzurePort;
        /// <summary>
        /// The primary address prefix.
        /// </summary>
        public readonly string? PrimaryPeerAddressPrefix;
        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The secondary port.
        /// </summary>
        public readonly string SecondaryAzurePort;
        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        public readonly string? SecondaryPeerAddressPrefix;
        /// <summary>
        /// The shared key.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// The peering state.
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// The VLAN ID.
        /// </summary>
        public readonly int? VlanId;

        [OutputConstructor]
        private GetExpressRouteCrossConnectionPeeringResult(
            int azureASN,

            string etag,

            string? gatewayManagerEtag,

            string? id,

            Outputs.Ipv6ExpressRouteCircuitPeeringConfigResponse? ipv6PeeringConfig,

            string? lastModifiedBy,

            Outputs.ExpressRouteCircuitPeeringConfigResponse? microsoftPeeringConfig,

            string? name,

            double? peerASN,

            string? peeringType,

            string primaryAzurePort,

            string? primaryPeerAddressPrefix,

            string provisioningState,

            string secondaryAzurePort,

            string? secondaryPeerAddressPrefix,

            string? sharedKey,

            string? state,

            int? vlanId)
        {
            AzureASN = azureASN;
            Etag = etag;
            GatewayManagerEtag = gatewayManagerEtag;
            Id = id;
            Ipv6PeeringConfig = ipv6PeeringConfig;
            LastModifiedBy = lastModifiedBy;
            MicrosoftPeeringConfig = microsoftPeeringConfig;
            Name = name;
            PeerASN = peerASN;
            PeeringType = peeringType;
            PrimaryAzurePort = primaryAzurePort;
            PrimaryPeerAddressPrefix = primaryPeerAddressPrefix;
            ProvisioningState = provisioningState;
            SecondaryAzurePort = secondaryAzurePort;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            SharedKey = sharedKey;
            State = state;
            VlanId = vlanId;
        }
    }
}
