// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.Latest
{
    /// <summary>
    /// The alert rule information
    /// </summary>
    public partial class SmartDetectorAlertRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The alert rule actions.
        /// </summary>
        [Output("actionGroups")]
        public Output<Outputs.ActionGroupsInformationResponse> ActionGroups { get; private set; } = null!;

        /// <summary>
        /// The alert rule description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The alert rule's detector.
        /// </summary>
        [Output("detector")]
        public Output<Outputs.DetectorResponse> Detector { get; private set; } = null!;

        /// <summary>
        /// The alert rule frequency in ISO8601 format. The time granularity must be in minutes and minimum value is 5 minutes.
        /// </summary>
        [Output("frequency")]
        public Output<string> Frequency { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The alert rule resources scope.
        /// </summary>
        [Output("scope")]
        public Output<ImmutableArray<string>> Scope { get; private set; } = null!;

        /// <summary>
        /// The alert rule severity.
        /// </summary>
        [Output("severity")]
        public Output<string> Severity { get; private set; } = null!;

        /// <summary>
        /// The alert rule state.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<object?> Tags { get; private set; } = null!;

        /// <summary>
        /// The alert rule throttling information.
        /// </summary>
        [Output("throttling")]
        public Output<Outputs.ThrottlingInformationResponse?> Throttling { get; private set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SmartDetectorAlertRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SmartDetectorAlertRule(string name, SmartDetectorAlertRuleArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:alertsmanagement/latest:SmartDetectorAlertRule", name, args ?? new SmartDetectorAlertRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SmartDetectorAlertRule(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:alertsmanagement/latest:SmartDetectorAlertRule", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:alertsmanagement/v20190301:SmartDetectorAlertRule"},
                    new Pulumi.Alias { Type = "azure-nextgen:alertsmanagement/v20190601:SmartDetectorAlertRule"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SmartDetectorAlertRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SmartDetectorAlertRule Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SmartDetectorAlertRule(name, id, options);
        }
    }

    public sealed class SmartDetectorAlertRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The alert rule actions.
        /// </summary>
        [Input("actionGroups", required: true)]
        public Input<Inputs.ActionGroupsInformationArgs> ActionGroups { get; set; } = null!;

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [Input("alertRuleName", required: true)]
        public Input<string> AlertRuleName { get; set; } = null!;

        /// <summary>
        /// The alert rule description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The alert rule's detector.
        /// </summary>
        [Input("detector", required: true)]
        public Input<Inputs.DetectorArgs> Detector { get; set; } = null!;

        /// <summary>
        /// The alert rule frequency in ISO8601 format. The time granularity must be in minutes and minimum value is 5 minutes.
        /// </summary>
        [Input("frequency", required: true)]
        public Input<string> Frequency { get; set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("scope", required: true)]
        private InputList<string>? _scope;

        /// <summary>
        /// The alert rule resources scope.
        /// </summary>
        public InputList<string> Scope
        {
            get => _scope ?? (_scope = new InputList<string>());
            set => _scope = value;
        }

        /// <summary>
        /// The alert rule severity.
        /// </summary>
        [Input("severity", required: true)]
        public Input<string> Severity { get; set; } = null!;

        /// <summary>
        /// The alert rule state.
        /// </summary>
        [Input("state", required: true)]
        public Input<string> State { get; set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Input("tags")]
        public Input<object>? Tags { get; set; }

        /// <summary>
        /// The alert rule throttling information.
        /// </summary>
        [Input("throttling")]
        public Input<Inputs.ThrottlingInformationArgs>? Throttling { get; set; }

        public SmartDetectorAlertRuleArgs()
        {
        }
    }
}
