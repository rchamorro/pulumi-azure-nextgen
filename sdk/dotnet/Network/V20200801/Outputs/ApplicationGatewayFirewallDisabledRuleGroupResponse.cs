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
    public sealed class ApplicationGatewayFirewallDisabledRuleGroupResponse
    {
        /// <summary>
        /// The name of the rule group that will be disabled.
        /// </summary>
        public readonly string RuleGroupName;
        /// <summary>
        /// The list of rules that will be disabled. If null, all rules of the rule group will be disabled.
        /// </summary>
        public readonly ImmutableArray<int> Rules;

        [OutputConstructor]
        private ApplicationGatewayFirewallDisabledRuleGroupResponse(
            string ruleGroupName,

            ImmutableArray<int> rules)
        {
            RuleGroupName = ruleGroupName;
            Rules = rules;
        }
    }
}
