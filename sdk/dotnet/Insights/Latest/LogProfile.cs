// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.Latest
{
    /// <summary>
    /// The log profile resource.
    /// Latest API Version: 2016-03-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:insights/latest:LogProfile")]
    public partial class LogProfile : Pulumi.CustomResource
    {
        /// <summary>
        /// the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'
        /// </summary>
        [Output("categories")]
        public Output<ImmutableArray<string>> Categories { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location.
        /// </summary>
        [Output("locations")]
        public Output<ImmutableArray<string>> Locations { get; private set; } = null!;

        /// <summary>
        /// Azure resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// the retention policy for the events in the log.
        /// </summary>
        [Output("retentionPolicy")]
        public Output<Outputs.RetentionPolicyResponse> RetentionPolicy { get; private set; } = null!;

        /// <summary>
        /// The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [Output("serviceBusRuleId")]
        public Output<string?> ServiceBusRuleId { get; private set; } = null!;

        /// <summary>
        /// the resource id of the storage account to which you would like to send the Activity Log.
        /// </summary>
        [Output("storageAccountId")]
        public Output<string?> StorageAccountId { get; private set; } = null!;

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
        /// Create a LogProfile resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogProfile(string name, LogProfileArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/latest:LogProfile", name, args ?? new LogProfileArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogProfile(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:insights/latest:LogProfile", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:insights/v20160301:LogProfile"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LogProfile resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogProfile Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LogProfile(name, id, options);
        }
    }

    public sealed class LogProfileArgs : Pulumi.ResourceArgs
    {
        [Input("categories", required: true)]
        private InputList<string>? _categories;

        /// <summary>
        /// the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'
        /// </summary>
        public InputList<string> Categories
        {
            get => _categories ?? (_categories = new InputList<string>());
            set => _categories = value;
        }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        [Input("locations", required: true)]
        private InputList<string>? _locations;

        /// <summary>
        /// List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location.
        /// </summary>
        public InputList<string> Locations
        {
            get => _locations ?? (_locations = new InputList<string>());
            set => _locations = value;
        }

        /// <summary>
        /// The name of the log profile.
        /// </summary>
        [Input("logProfileName", required: true)]
        public Input<string> LogProfileName { get; set; } = null!;

        /// <summary>
        /// the retention policy for the events in the log.
        /// </summary>
        [Input("retentionPolicy", required: true)]
        public Input<Inputs.RetentionPolicyArgs> RetentionPolicy { get; set; } = null!;

        /// <summary>
        /// The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [Input("serviceBusRuleId")]
        public Input<string>? ServiceBusRuleId { get; set; }

        /// <summary>
        /// the resource id of the storage account to which you would like to send the Activity Log.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

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

        public LogProfileArgs()
        {
        }
    }
}
