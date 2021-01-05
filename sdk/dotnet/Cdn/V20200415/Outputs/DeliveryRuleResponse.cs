// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200415.Outputs
{

    [OutputType]
    public sealed class DeliveryRuleResponse
    {
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        public readonly ImmutableArray<object> Actions;
        /// <summary>
        /// A list of conditions that must be matched for the actions to be executed
        /// </summary>
        public readonly ImmutableArray<object> Conditions;
        /// <summary>
        /// Name of the rule
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
        /// </summary>
        public readonly int Order;

        [OutputConstructor]
        private DeliveryRuleResponse(
            ImmutableArray<object> actions,

            ImmutableArray<object> conditions,

            string? name,

            int order)
        {
            Actions = actions;
            Conditions = conditions;
            Name = name;
            Order = order;
        }
    }
}
