// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DigitalTwins.V20201031
{
    /// <summary>
    /// The description of the DigitalTwins service.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:digitaltwins/v20201031:DigitalTwin")]
    public partial class DigitalTwin : Pulumi.CustomResource
    {
        /// <summary>
        /// Time when DigitalTwinsInstance was created.
        /// </summary>
        [Output("createdTime")]
        public Output<string> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// Api endpoint to work with DigitalTwinsInstance.
        /// </summary>
        [Output("hostName")]
        public Output<string> HostName { get; private set; } = null!;

        /// <summary>
        /// Time when DigitalTwinsInstance was updated.
        /// </summary>
        [Output("lastUpdatedTime")]
        public Output<string> LastUpdatedTime { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DigitalTwin resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DigitalTwin(string name, DigitalTwinArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:digitaltwins/v20201031:DigitalTwin", name, args ?? new DigitalTwinArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DigitalTwin(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:digitaltwins/v20201031:DigitalTwin", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:digitaltwins/latest:DigitalTwin"},
                    new Pulumi.Alias { Type = "azure-nextgen:digitaltwins/v20200301preview:DigitalTwin"},
                    new Pulumi.Alias { Type = "azure-nextgen:digitaltwins/v20201201:DigitalTwin"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DigitalTwin resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DigitalTwin Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DigitalTwin(name, id, options);
        }
    }

    public sealed class DigitalTwinArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group that contains the DigitalTwinsInstance.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the DigitalTwinsInstance.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public DigitalTwinArgs()
        {
        }
    }
}
