// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20190601.Inputs
{

    /// <summary>
    /// Virtual Network rule.
    /// </summary>
    public sealed class VirtualNetworkRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The action of virtual network rule.
        /// </summary>
        [Input("action")]
        public Input<Pulumi.AzureNextGen.Storage.V20190601.Action>? Action { get; set; }

        /// <summary>
        /// Gets the state of virtual network rule.
        /// </summary>
        [Input("state")]
        public Input<Pulumi.AzureNextGen.Storage.V20190601.State>? State { get; set; }

        /// <summary>
        /// Resource ID of a subnet, for example: /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
        /// </summary>
        [Input("virtualNetworkResourceId", required: true)]
        public Input<string> VirtualNetworkResourceId { get; set; } = null!;

        public VirtualNetworkRuleArgs()
        {
            Action = Pulumi.AzureNextGen.Storage.V20190601.Action.Allow;
        }
    }
}
