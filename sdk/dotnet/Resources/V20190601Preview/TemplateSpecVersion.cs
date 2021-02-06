// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20190601Preview
{
    /// <summary>
    /// Template Spec Version object.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:resources/v20190601preview:TemplateSpecVersion")]
    public partial class TemplateSpecVersion : Pulumi.CustomResource
    {
        /// <summary>
        /// An array of Template Spec artifacts.
        /// </summary>
        [Output("artifacts")]
        public Output<ImmutableArray<Outputs.TemplateSpecTemplateArtifactResponse>> Artifacts { get; private set; } = null!;

        /// <summary>
        /// Template Spec version description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The location of the Template Spec Version. It must match the location of the parent Template Spec.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Name of this resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The Azure Resource Manager template content.
        /// </summary>
        [Output("template")]
        public Output<object?> Template { get; private set; } = null!;

        /// <summary>
        /// Type of this resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a TemplateSpecVersion resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TemplateSpecVersion(string name, TemplateSpecVersionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:resources/v20190601preview:TemplateSpecVersion", name, args ?? new TemplateSpecVersionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TemplateSpecVersion(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:resources/v20190601preview:TemplateSpecVersion", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TemplateSpecVersion resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TemplateSpecVersion Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TemplateSpecVersion(name, id, options);
        }
    }

    public sealed class TemplateSpecVersionArgs : Pulumi.ResourceArgs
    {
        [Input("artifacts")]
        private InputList<Inputs.TemplateSpecTemplateArtifactArgs>? _artifacts;

        /// <summary>
        /// An array of Template Spec artifacts.
        /// </summary>
        public InputList<Inputs.TemplateSpecTemplateArtifactArgs> Artifacts
        {
            get => _artifacts ?? (_artifacts = new InputList<Inputs.TemplateSpecTemplateArtifactArgs>());
            set => _artifacts = value;
        }

        /// <summary>
        /// Template Spec version description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The location of the Template Spec Version. It must match the location of the parent Template Spec.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The Azure Resource Manager template content.
        /// </summary>
        [Input("template")]
        public Input<object>? Template { get; set; }

        /// <summary>
        /// Name of the Template Spec.
        /// </summary>
        [Input("templateSpecName", required: true)]
        public Input<string> TemplateSpecName { get; set; } = null!;

        /// <summary>
        /// The version of the Template Spec.
        /// </summary>
        [Input("templateSpecVersion", required: true)]
        public Input<string> TemplateSpecVersion { get; set; } = null!;

        public TemplateSpecVersionArgs()
        {
        }
    }
}
