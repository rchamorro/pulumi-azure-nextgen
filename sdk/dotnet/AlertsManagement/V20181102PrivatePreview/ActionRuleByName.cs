// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.V20181102PrivatePreview
{
    /// <summary>
    /// Action rule object containing target scope, conditions and suppression logic
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:alertsmanagement/v20181102privatepreview:ActionRuleByName")]
    public partial class ActionRuleByName : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Azure resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Action rule properties defining scope, conditions, suppression logic for action rule
        /// </summary>
        [Output("properties")]
        public Output<Outputs.ActionRulePropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Azure resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ActionRuleByName resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ActionRuleByName(string name, ActionRuleByNameArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:alertsmanagement/v20181102privatepreview:ActionRuleByName", name, args ?? new ActionRuleByNameArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ActionRuleByName(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:alertsmanagement/v20181102privatepreview:ActionRuleByName", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:alertsmanagement/v20190505preview:ActionRuleByName"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ActionRuleByName resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ActionRuleByName Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ActionRuleByName(name, id, options);
        }
    }

    public sealed class ActionRuleByNameArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of action rule that needs to be created/updated
        /// </summary>
        [Input("actionRuleName", required: true)]
        public Input<string> ActionRuleName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Action rule properties defining scope, conditions, suppression logic for action rule
        /// </summary>
        [Input("properties")]
        public Input<Inputs.ActionRulePropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// Resource group name where the resource is created.
        /// </summary>
        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ActionRuleByNameArgs()
        {
        }
    }
}
