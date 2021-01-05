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
    public sealed class VpnConnectionResponse
    {
        /// <summary>
        /// Expected bandwidth in MBPS.
        /// </summary>
        public readonly int? ConnectionBandwidth;
        /// <summary>
        /// The connection status.
        /// </summary>
        public readonly string ConnectionStatus;
        /// <summary>
        /// DPD timeout in seconds for vpn connection.
        /// </summary>
        public readonly int? DpdTimeoutSeconds;
        /// <summary>
        /// Egress bytes transferred.
        /// </summary>
        public readonly double EgressBytesTransferred;
        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        public readonly bool? EnableBgp;
        /// <summary>
        /// Enable internet security.
        /// </summary>
        public readonly bool? EnableInternetSecurity;
        /// <summary>
        /// EnableBgp flag.
        /// </summary>
        public readonly bool? EnableRateLimiting;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Ingress bytes transferred.
        /// </summary>
        public readonly double IngressBytesTransferred;
        /// <summary>
        /// The IPSec Policies to be considered by this connection.
        /// </summary>
        public readonly ImmutableArray<Outputs.IpsecPolicyResponse> IpsecPolicies;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The provisioning state of the VPN connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RemoteVpnSite;
        /// <summary>
        /// The Routing Configuration indicating the associated and propagated route tables on this connection.
        /// </summary>
        public readonly Outputs.RoutingConfigurationResponse? RoutingConfiguration;
        /// <summary>
        /// Routing weight for vpn connection.
        /// </summary>
        public readonly int? RoutingWeight;
        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Use local azure ip to initiate connection.
        /// </summary>
        public readonly bool? UseLocalAzureIpAddress;
        /// <summary>
        /// Enable policy-based traffic selectors.
        /// </summary>
        public readonly bool? UsePolicyBasedTrafficSelectors;
        /// <summary>
        /// Connection protocol used for this connection.
        /// </summary>
        public readonly string? VpnConnectionProtocolType;
        /// <summary>
        /// List of all vpn site link connections to the gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.VpnSiteLinkConnectionResponse> VpnLinkConnections;

        [OutputConstructor]
        private VpnConnectionResponse(
            int? connectionBandwidth,

            string connectionStatus,

            int? dpdTimeoutSeconds,

            double egressBytesTransferred,

            bool? enableBgp,

            bool? enableInternetSecurity,

            bool? enableRateLimiting,

            string etag,

            string? id,

            double ingressBytesTransferred,

            ImmutableArray<Outputs.IpsecPolicyResponse> ipsecPolicies,

            string? name,

            string provisioningState,

            Outputs.SubResourceResponse? remoteVpnSite,

            Outputs.RoutingConfigurationResponse? routingConfiguration,

            int? routingWeight,

            string? sharedKey,

            bool? useLocalAzureIpAddress,

            bool? usePolicyBasedTrafficSelectors,

            string? vpnConnectionProtocolType,

            ImmutableArray<Outputs.VpnSiteLinkConnectionResponse> vpnLinkConnections)
        {
            ConnectionBandwidth = connectionBandwidth;
            ConnectionStatus = connectionStatus;
            DpdTimeoutSeconds = dpdTimeoutSeconds;
            EgressBytesTransferred = egressBytesTransferred;
            EnableBgp = enableBgp;
            EnableInternetSecurity = enableInternetSecurity;
            EnableRateLimiting = enableRateLimiting;
            Etag = etag;
            Id = id;
            IngressBytesTransferred = ingressBytesTransferred;
            IpsecPolicies = ipsecPolicies;
            Name = name;
            ProvisioningState = provisioningState;
            RemoteVpnSite = remoteVpnSite;
            RoutingConfiguration = routingConfiguration;
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            VpnLinkConnections = vpnLinkConnections;
        }
    }
}
