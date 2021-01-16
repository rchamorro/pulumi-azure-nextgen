// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831Preview.Inputs
{

    /// <summary>
    /// IP Rule to be applied as part of Network Rule Set
    /// </summary>
    public sealed class NetworkRuleSetIpRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// IP Filter Action
        /// </summary>
        [Input("action")]
        public InputUnion<string, Pulumi.AzureNextGen.Devices.V20200831Preview.NetworkRuleIPAction>? Action { get; set; }

        /// <summary>
        /// Name of the IP filter rule.
        /// </summary>
        [Input("filterName", required: true)]
        public Input<string> FilterName { get; set; } = null!;

        /// <summary>
        /// A string that contains the IP address range in CIDR notation for the rule.
        /// </summary>
        [Input("ipMask", required: true)]
        public Input<string> IpMask { get; set; } = null!;

        public NetworkRuleSetIpRuleArgs()
        {
            Action = "Allow";
        }
    }
}
