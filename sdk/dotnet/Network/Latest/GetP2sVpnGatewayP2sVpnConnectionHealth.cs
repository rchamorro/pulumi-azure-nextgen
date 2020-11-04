// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest
{
    public static class GetP2sVpnGatewayP2sVpnConnectionHealth
    {
        public static Task<GetP2sVpnGatewayP2sVpnConnectionHealthResult> InvokeAsync(GetP2sVpnGatewayP2sVpnConnectionHealthArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetP2sVpnGatewayP2sVpnConnectionHealthResult>("azure-nextgen:network/latest:getP2sVpnGatewayP2sVpnConnectionHealth", args ?? new GetP2sVpnGatewayP2sVpnConnectionHealthArgs(), options.WithVersion());
    }


    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the P2SVpnGateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public string GatewayName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetP2sVpnGatewayP2sVpnConnectionHealthArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetP2sVpnGatewayP2sVpnConnectionHealthResult
    {
        /// <summary>
        /// List of all customer specified DNS servers IP addresses.
        /// </summary>
        public readonly ImmutableArray<string> CustomDnsServers;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Enable Routing Preference property for the Public IP Interface of the P2SVpnGateway.
        /// </summary>
        public readonly bool? IsRoutingPreferenceInternet;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of all p2s connection configurations of the gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.P2SConnectionConfigurationResponse> P2SConnectionConfigurations;
        /// <summary>
        /// The provisioning state of the P2S VPN gateway resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        public readonly Outputs.SubResourceResponse? VirtualHub;
        /// <summary>
        /// All P2S VPN clients' connection health status.
        /// </summary>
        public readonly Outputs.VpnClientConnectionHealthResponse VpnClientConnectionHealth;
        /// <summary>
        /// The scale unit for this p2s vpn gateway.
        /// </summary>
        public readonly int? VpnGatewayScaleUnit;
        /// <summary>
        /// The VpnServerConfiguration to which the p2sVpnGateway is attached to.
        /// </summary>
        public readonly Outputs.SubResourceResponse? VpnServerConfiguration;

        [OutputConstructor]
        private GetP2sVpnGatewayP2sVpnConnectionHealthResult(
            ImmutableArray<string> customDnsServers,

            string etag,

            bool? isRoutingPreferenceInternet,

            string location,

            string name,

            ImmutableArray<Outputs.P2SConnectionConfigurationResponse> p2SConnectionConfigurations,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.SubResourceResponse? virtualHub,

            Outputs.VpnClientConnectionHealthResponse vpnClientConnectionHealth,

            int? vpnGatewayScaleUnit,

            Outputs.SubResourceResponse? vpnServerConfiguration)
        {
            CustomDnsServers = customDnsServers;
            Etag = etag;
            IsRoutingPreferenceInternet = isRoutingPreferenceInternet;
            Location = location;
            Name = name;
            P2SConnectionConfigurations = p2SConnectionConfigurations;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            VirtualHub = virtualHub;
            VpnClientConnectionHealth = vpnClientConnectionHealth;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            VpnServerConfiguration = vpnServerConfiguration;
        }
    }
}
