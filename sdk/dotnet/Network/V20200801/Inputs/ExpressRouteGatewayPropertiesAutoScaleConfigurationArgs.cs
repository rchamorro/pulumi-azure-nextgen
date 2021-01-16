// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// Configuration for auto scaling.
    /// </summary>
    public sealed class ExpressRouteGatewayPropertiesAutoScaleConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Minimum and maximum number of scale units to deploy.
        /// </summary>
        [Input("bounds")]
        public Input<Inputs.ExpressRouteGatewayPropertiesBoundsArgs>? Bounds { get; set; }

        public ExpressRouteGatewayPropertiesAutoScaleConfigurationArgs()
        {
        }
    }
}
