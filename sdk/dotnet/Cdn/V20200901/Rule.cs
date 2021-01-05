// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200901
{
    /// <summary>
    /// Friendly Rules name mapping to the any Rules or secret related information.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:cdn/v20200901:Rule")]
    public partial class Rule : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<object>> Actions { get; private set; } = null!;

        /// <summary>
        /// A list of conditions that must be matched for the actions to be executed
        /// </summary>
        [Output("conditions")]
        public Output<ImmutableArray<object>> Conditions { get; private set; } = null!;

        [Output("deploymentStatus")]
        public Output<string> DeploymentStatus { get; private set; } = null!;

        /// <summary>
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.
        /// </summary>
        [Output("matchProcessingBehavior")]
        public Output<string?> MatchProcessingBehavior { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
        /// </summary>
        [Output("order")]
        public Output<int> Order { get; private set; } = null!;

        /// <summary>
        /// Provisioning status
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Read only system data
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Rule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Rule(string name, RuleArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:Rule", name, args ?? new RuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Rule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:cdn/v20200901:Rule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:cdn/latest:Rule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Rule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Rule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Rule(name, id, options);
        }
    }

    public sealed class RuleArgs : Pulumi.ResourceArgs
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
        /// If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.
        /// </summary>
        [Input("matchProcessingBehavior")]
        public InputUnion<string, Pulumi.AzureNextGen.Cdn.V20200901.MatchProcessingBehavior>? MatchProcessingBehavior { get; set; }

        /// <summary>
        /// The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
        /// </summary>
        [Input("order", required: true)]
        public Input<int> Order { get; set; } = null!;

        /// <summary>
        /// Name of the CDN profile which is unique within the resource group.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the delivery rule which is unique within the endpoint.
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        /// <summary>
        /// Name of the rule set under the profile.
        /// </summary>
        [Input("ruleSetName", required: true)]
        public Input<string> RuleSetName { get; set; } = null!;

        public RuleArgs()
        {
        }
    }
}
