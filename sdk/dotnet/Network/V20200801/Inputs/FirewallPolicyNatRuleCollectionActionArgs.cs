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
    /// Properties of the FirewallPolicyNatRuleCollectionAction.
    /// </summary>
    public sealed class FirewallPolicyNatRuleCollectionActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of action.
        /// </summary>
        [Input("type")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20200801.FirewallPolicyNatRuleCollectionActionType>? Type { get; set; }

        public FirewallPolicyNatRuleCollectionActionArgs()
        {
        }
    }
}
