// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190901
{
    public static class GetExpressRouteGateway
    {
        public static Task<GetExpressRouteGatewayResult> InvokeAsync(GetExpressRouteGatewayArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetExpressRouteGatewayResult>("azure-nextgen:network/v20190901:getExpressRouteGateway", args ?? new GetExpressRouteGatewayArgs(), options.WithVersion());
    }


    public sealed class GetExpressRouteGatewayArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the ExpressRoute gateway.
        /// </summary>
        [Input("expressRouteGatewayName", required: true)]
        public string ExpressRouteGatewayName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetExpressRouteGatewayArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetExpressRouteGatewayResult
    {
        /// <summary>
        /// Configuration for auto scaling.
        /// </summary>
        public readonly Outputs.ExpressRouteGatewayPropertiesResponseAutoScaleConfiguration? AutoScaleConfiguration;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// List of ExpressRoute connections to the ExpressRoute gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.ExpressRouteConnectionResponse> ExpressRouteConnections;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the express route gateway resource.
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
        /// The Virtual Hub where the ExpressRoute gateway is or will be deployed.
        /// </summary>
        public readonly Outputs.VirtualHubIdResponse VirtualHub;

        [OutputConstructor]
        private GetExpressRouteGatewayResult(
            Outputs.ExpressRouteGatewayPropertiesResponseAutoScaleConfiguration? autoScaleConfiguration,

            string etag,

            ImmutableArray<Outputs.ExpressRouteConnectionResponse> expressRouteConnections,

            string? location,

            string name,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.VirtualHubIdResponse virtualHub)
        {
            AutoScaleConfiguration = autoScaleConfiguration;
            Etag = etag;
            ExpressRouteConnections = expressRouteConnections;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
            VirtualHub = virtualHub;
        }
    }
}