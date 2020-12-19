// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EventGrid.V20190601
{
    /// <summary>
    /// EventGrid Topic
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:eventgrid/v20190601:Topic")]
    public partial class Topic : Pulumi.CustomResource
    {
        /// <summary>
        /// Endpoint for the topic.
        /// </summary>
        [Output("endpoint")]
        public Output<string> Endpoint { get; private set; } = null!;

        /// <summary>
        /// Location of the resource.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Provisioning state of the topic.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Tags of the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Topic resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Topic(string name, TopicArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:eventgrid/v20190601:Topic", name, args ?? new TopicArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Topic(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:eventgrid/v20190601:Topic", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/latest:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20170615preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20170915preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20180101:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20180501preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20180915preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20190101:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20190201preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20200101preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20200401preview:Topic"},
                    new Pulumi.Alias { Type = "azure-nextgen:eventgrid/v20200601:Topic"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Topic resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Topic Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Topic(name, id, options);
        }
    }

    public sealed class TopicArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Location of the resource.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Tags of the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Name of the topic.
        /// </summary>
        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public TopicArgs()
        {
        }
    }
}
