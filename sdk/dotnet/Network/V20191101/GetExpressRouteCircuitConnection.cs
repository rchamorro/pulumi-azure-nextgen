// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20191101
{
    public static class GetExpressRouteCircuitConnection
    {
        public static Task<GetExpressRouteCircuitConnectionResult> InvokeAsync(GetExpressRouteCircuitConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetExpressRouteCircuitConnectionResult>("azure-nextgen:network/v20191101:getExpressRouteCircuitConnection", args ?? new GetExpressRouteCircuitConnectionArgs(), options.WithVersion());
    }


    public sealed class GetExpressRouteCircuitConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the express route circuit.
        /// </summary>
        [Input("circuitName", required: true)]
        public string CircuitName { get; set; } = null!;

        /// <summary>
        /// The name of the express route circuit connection.
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

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

        public GetExpressRouteCircuitConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetExpressRouteCircuitConnectionResult
    {
        /// <summary>
        /// /29 IP address space to carve out Customer addresses for tunnels.
        /// </summary>
        public readonly string? AddressPrefix;
        /// <summary>
        /// The authorization key.
        /// </summary>
        public readonly string? AuthorizationKey;
        /// <summary>
        /// Express Route Circuit connection state.
        /// </summary>
        public readonly string? CircuitConnectionStatus;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the circuit initiating connection.
        /// </summary>
        public readonly Outputs.SubResourceResponse? ExpressRouteCircuitPeering;
        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Reference to Express Route Circuit Private Peering Resource of the peered circuit.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PeerExpressRouteCircuitPeering;
        /// <summary>
        /// The provisioning state of the express route circuit connection resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetExpressRouteCircuitConnectionResult(
            string? addressPrefix,

            string? authorizationKey,

            string? circuitConnectionStatus,

            string etag,

            Outputs.SubResourceResponse? expressRouteCircuitPeering,

            string? name,

            Outputs.SubResourceResponse? peerExpressRouteCircuitPeering,

            string provisioningState,

            string type)
        {
            AddressPrefix = addressPrefix;
            AuthorizationKey = authorizationKey;
            CircuitConnectionStatus = circuitConnectionStatus;
            Etag = etag;
            ExpressRouteCircuitPeering = expressRouteCircuitPeering;
            Name = name;
            PeerExpressRouteCircuitPeering = peerExpressRouteCircuitPeering;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}