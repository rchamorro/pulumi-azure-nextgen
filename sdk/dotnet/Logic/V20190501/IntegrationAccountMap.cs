// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20190501
{
    /// <summary>
    /// The integration account map.
    /// </summary>
    public partial class IntegrationAccountMap : Pulumi.CustomResource
    {
        /// <summary>
        /// The changed time.
        /// </summary>
        [Output("changedTime")]
        public Output<string> ChangedTime { get; private set; } = null!;

        /// <summary>
        /// The content.
        /// </summary>
        [Output("content")]
        public Output<string?> Content { get; private set; } = null!;

        /// <summary>
        /// The content link.
        /// </summary>
        [Output("contentLink")]
        public Output<Outputs.ContentLinkResponse> ContentLink { get; private set; } = null!;

        /// <summary>
        /// The content type.
        /// </summary>
        [Output("contentType")]
        public Output<string?> ContentType { get; private set; } = null!;

        /// <summary>
        /// The created time.
        /// </summary>
        [Output("createdTime")]
        public Output<string> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The map type.
        /// </summary>
        [Output("mapType")]
        public Output<string> MapType { get; private set; } = null!;

        /// <summary>
        /// The metadata.
        /// </summary>
        [Output("metadata")]
        public Output<object?> Metadata { get; private set; } = null!;

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The parameters schema of integration account map.
        /// </summary>
        [Output("parametersSchema")]
        public Output<Outputs.IntegrationAccountMapPropertiesResponseParametersSchema?> ParametersSchema { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IntegrationAccountMap resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IntegrationAccountMap(string name, IntegrationAccountMapArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20190501:IntegrationAccountMap", name, args ?? new IntegrationAccountMapArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IntegrationAccountMap(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20190501:IntegrationAccountMap", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:logic/latest:IntegrationAccountMap"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20150801preview:IntegrationAccountMap"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20160601:IntegrationAccountMap"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20180701preview:IntegrationAccountMap"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IntegrationAccountMap resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IntegrationAccountMap Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IntegrationAccountMap(name, id, options);
        }
    }

    public sealed class IntegrationAccountMapArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The content.
        /// </summary>
        [Input("content")]
        public Input<string>? Content { get; set; }

        /// <summary>
        /// The content type.
        /// </summary>
        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        /// <summary>
        /// The integration account name.
        /// </summary>
        [Input("integrationAccountName", required: true)]
        public Input<string> IntegrationAccountName { get; set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The integration account map name.
        /// </summary>
        [Input("mapName", required: true)]
        public Input<string> MapName { get; set; } = null!;

        /// <summary>
        /// The map type.
        /// </summary>
        [Input("mapType", required: true)]
        public Input<string> MapType { get; set; } = null!;

        /// <summary>
        /// The metadata.
        /// </summary>
        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The parameters schema of integration account map.
        /// </summary>
        [Input("parametersSchema")]
        public Input<Inputs.IntegrationAccountMapPropertiesParametersSchemaArgs>? ParametersSchema { get; set; }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

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

        public IntegrationAccountMapArgs()
        {
        }
    }
}
