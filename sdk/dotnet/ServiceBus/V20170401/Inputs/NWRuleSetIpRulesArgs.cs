// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20170401.Inputs
{

    /// <summary>
    /// Description of NetWorkRuleSet - IpRules resource.
    /// </summary>
    public sealed class NWRuleSetIpRulesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The IP Filter Action
        /// </summary>
        [Input("action")]
        public InputUnion<string, Pulumi.AzureNextGen.ServiceBus.V20170401.NetworkRuleIPAction>? Action { get; set; }

        /// <summary>
        /// IP Mask
        /// </summary>
        [Input("ipMask")]
        public Input<string>? IpMask { get; set; }

        public NWRuleSetIpRulesArgs()
        {
            Action = "Allow";
        }
    }
}
