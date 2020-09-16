// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190201.Inputs
{

    /// <summary>
    /// Application Gateway autoscale configuration.
    /// </summary>
    public sealed class ApplicationGatewayAutoscaleConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Upper bound on number of Application Gateway capacity
        /// </summary>
        [Input("maxCapacity")]
        public Input<int>? MaxCapacity { get; set; }

        /// <summary>
        /// Lower bound on number of Application Gateway capacity
        /// </summary>
        [Input("minCapacity", required: true)]
        public Input<int> MinCapacity { get; set; } = null!;

        public ApplicationGatewayAutoscaleConfigurationArgs()
        {
        }
    }
}