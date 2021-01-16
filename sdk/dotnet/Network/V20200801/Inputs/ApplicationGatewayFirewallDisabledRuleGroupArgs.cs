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
    /// Allows to disable rules within a rule group or an entire rule group.
    /// </summary>
    public sealed class ApplicationGatewayFirewallDisabledRuleGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the rule group that will be disabled.
        /// </summary>
        [Input("ruleGroupName", required: true)]
        public Input<string> RuleGroupName { get; set; } = null!;

        [Input("rules")]
        private InputList<int>? _rules;

        /// <summary>
        /// The list of rules that will be disabled. If null, all rules of the rule group will be disabled.
        /// </summary>
        public InputList<int> Rules
        {
            get => _rules ?? (_rules = new InputList<int>());
            set => _rules = value;
        }

        public ApplicationGatewayFirewallDisabledRuleGroupArgs()
        {
        }
    }
}
