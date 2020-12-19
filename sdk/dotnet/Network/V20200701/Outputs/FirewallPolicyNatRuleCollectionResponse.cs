// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class FirewallPolicyNatRuleCollectionResponse
    {
        /// <summary>
        /// The action type of a Nat rule collection.
        /// </summary>
        public readonly Outputs.FirewallPolicyNatRuleCollectionActionResponse? Action;
        /// <summary>
        /// The name of the rule collection.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Priority of the Firewall Policy Rule Collection resource.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// The type of the rule collection.
        /// Expected value is 'FirewallPolicyNatRuleCollection'.
        /// </summary>
        public readonly string RuleCollectionType;
        /// <summary>
        /// List of rules included in a rule collection.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.ApplicationRuleResponse, Union<Outputs.NatRuleResponse, Outputs.NetworkRuleResponse>>> Rules;

        [OutputConstructor]
        private FirewallPolicyNatRuleCollectionResponse(
            Outputs.FirewallPolicyNatRuleCollectionActionResponse? action,

            string? name,

            int? priority,

            string ruleCollectionType,

            ImmutableArray<Union<Outputs.ApplicationRuleResponse, Union<Outputs.NatRuleResponse, Outputs.NetworkRuleResponse>>> rules)
        {
            Action = action;
            Name = name;
            Priority = priority;
            RuleCollectionType = ruleCollectionType;
            Rules = rules;
        }
    }
}
