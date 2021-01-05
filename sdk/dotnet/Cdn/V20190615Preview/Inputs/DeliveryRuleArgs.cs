// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20190615Preview.Inputs
{

    /// <summary>
    /// A rule that specifies a set of actions and conditions
    /// </summary>
    public sealed class DeliveryRuleArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<object>? _actions;

        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        public InputList<object> Actions
        {
            get => _actions ?? (_actions = new InputList<object>());
            set => _actions = value;
        }

        [Input("conditions")]
        private InputList<object>? _conditions;

        /// <summary>
        /// A list of conditions that must be matched for the actions to be executed
        /// </summary>
        public InputList<object> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<object>());
            set => _conditions = value;
        }

        /// <summary>
        /// Name of the rule
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
        /// </summary>
        [Input("order", required: true)]
        public Input<int> Order { get; set; } = null!;

        public DeliveryRuleArgs()
        {
        }
    }
}
