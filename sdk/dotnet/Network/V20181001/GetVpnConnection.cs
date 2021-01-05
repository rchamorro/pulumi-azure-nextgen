// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181001
{
    public static class GetVpnConnection
    {
        public static Task<GetVpnConnectionResult> InvokeAsync(GetVpnConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpnConnectionResult>("azure-nextgen:network/v20181001:getVpnConnection", args ?? new GetVpnConnectionArgs(), options.WithVersion());
    }


    public sealed class GetVpnConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the vpn connection.
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the gateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public string GatewayName { get; set; } = null!;

        /// <summary>
        /// The resource group name of the VpnGateway.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetVpnConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVpnConnectionResult
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
        /// Egress bytes transferred.
        /// </summary>
        public readonly double EgressBytesTransferred;
        /// <summary>
        /// EnableBgp flag
        /// </summary>
        public readonly bool? EnableBgp;
        /// <summary>
        /// Enable internet security
        /// </summary>
        public readonly bool? EnableInternetSecurity;
        /// <summary>
        /// EnableBgp flag
        /// </summary>
        public readonly bool? EnableRateLimiting;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
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
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Id of the connected vpn site.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RemoteVpnSite;
        /// <summary>
        /// routing weight for vpn connection.
        /// </summary>
        public readonly int? RoutingWeight;
        /// <summary>
        /// SharedKey for the vpn connection.
        /// </summary>
        public readonly string? SharedKey;
        /// <summary>
        /// Connection protocol used for this connection
        /// </summary>
        public readonly string? VpnConnectionProtocolType;

        [OutputConstructor]
        private GetVpnConnectionResult(
            int? connectionBandwidth,

            string connectionStatus,

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

            int? routingWeight,

            string? sharedKey,

            string? vpnConnectionProtocolType)
        {
            ConnectionBandwidth = connectionBandwidth;
            ConnectionStatus = connectionStatus;
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
            RoutingWeight = routingWeight;
            SharedKey = sharedKey;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
        }
    }
}
