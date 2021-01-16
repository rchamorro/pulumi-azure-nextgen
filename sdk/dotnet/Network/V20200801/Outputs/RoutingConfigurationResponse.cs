// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class RoutingConfigurationResponse
    {
        /// <summary>
        /// The resource id RouteTable associated with this RoutingConfiguration.
        /// </summary>
        public readonly Outputs.SubResourceResponse? AssociatedRouteTable;
        /// <summary>
        /// The list of RouteTables to advertise the routes to.
        /// </summary>
        public readonly Outputs.PropagatedRouteTableResponse? PropagatedRouteTables;
        /// <summary>
        /// List of routes that control routing from VirtualHub into a virtual network connection.
        /// </summary>
        public readonly Outputs.VnetRouteResponse? VnetRoutes;

        [OutputConstructor]
        private RoutingConfigurationResponse(
            Outputs.SubResourceResponse? associatedRouteTable,

            Outputs.PropagatedRouteTableResponse? propagatedRouteTables,

            Outputs.VnetRouteResponse? vnetRoutes)
        {
            AssociatedRouteTable = associatedRouteTable;
            PropagatedRouteTables = propagatedRouteTables;
            VnetRoutes = vnetRoutes;
        }
    }
}
