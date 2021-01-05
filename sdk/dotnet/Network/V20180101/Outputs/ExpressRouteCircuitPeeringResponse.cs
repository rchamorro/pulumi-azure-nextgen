// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180101.Outputs
{

    [OutputType]
    public sealed class ExpressRouteCircuitPeeringResponse
    {
        /// <summary>
        /// The Azure ASN.
        /// </summary>
        public readonly int? AzureASN;
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
        /// The PeeringType. Possible values are: 'AzurePublicPeering', 'AzurePrivatePeering', and 'MicrosoftPeering'.
        /// </summary>
        public readonly string? PeeringType;
        /// <summary>
        /// The primary port.
        /// </summary>
        public readonly string? PrimaryAzurePort;
        /// <summary>
        /// The primary address prefix.
        /// </summary>
        public readonly string? PrimaryPeerAddressPrefix;
        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// The reference of the RouteFilter resource.
        /// </summary>
        public readonly Outputs.RouteFilterResponse? RouteFilter;
        /// <summary>
        /// The secondary port.
        /// </summary>
        public readonly string? SecondaryAzurePort;
        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        public readonly string? SecondaryPeerAddressPrefix;
        /// <summary>
        /// The shared key.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// The state of peering. Possible values are: 'Disabled' and 'Enabled'
        /// </summary>
        public readonly string? State;
        /// <summary>
        /// Gets peering stats.
        /// </summary>
        public readonly Outputs.ExpressRouteCircuitStatsResponse? Stats;
        /// <summary>
        /// The VLAN ID.
        /// </summary>
        public readonly int? VlanId;

        [OutputConstructor]
        private ExpressRouteCircuitPeeringResponse(
            int? azureASN,

            string etag,

            string? gatewayManagerEtag,

            string? id,

            Outputs.Ipv6ExpressRouteCircuitPeeringConfigResponse? ipv6PeeringConfig,

            string? lastModifiedBy,

            Outputs.ExpressRouteCircuitPeeringConfigResponse? microsoftPeeringConfig,

            string? name,

            double? peerASN,

            string? peeringType,

            string? primaryAzurePort,

            string? primaryPeerAddressPrefix,

            string? provisioningState,

            Outputs.RouteFilterResponse? routeFilter,

            string? secondaryAzurePort,

            string? secondaryPeerAddressPrefix,

            string? sharedKey,

            string? state,

            Outputs.ExpressRouteCircuitStatsResponse? stats,

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
            RouteFilter = routeFilter;
            SecondaryAzurePort = secondaryAzurePort;
            SecondaryPeerAddressPrefix = secondaryPeerAddressPrefix;
            SharedKey = sharedKey;
            State = state;
            Stats = stats;
            VlanId = vlanId;
        }
    }
}
