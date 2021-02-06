// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabricMesh.V20180701Preview
{
    /// <summary>
    /// This type describes a volume resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:servicefabricmesh/v20180701preview:Volume")]
    public partial class Volume : Pulumi.CustomResource
    {
        /// <summary>
        /// This type describes a volume provided by an Azure Files file share.
        /// </summary>
        [Output("azureFileParameters")]
        public Output<Outputs.VolumeProviderParametersAzureFileResponse?> AzureFileParameters { get; private set; } = null!;

        /// <summary>
        /// User readable description of the volume.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Provider of the volume.
        /// </summary>
        [Output("provider")]
        public Output<string> Provider { get; private set; } = null!;

        /// <summary>
        /// State of the resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Volume resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Volume(string name, VolumeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicefabricmesh/v20180701preview:Volume", name, args ?? new VolumeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Volume(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicefabricmesh/v20180701preview:Volume", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabricmesh/v20180901preview:Volume"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Volume resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Volume Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Volume(name, id, options);
        }
    }

    public sealed class VolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This type describes a volume provided by an Azure Files file share.
        /// </summary>
        [Input("azureFileParameters")]
        public Input<Inputs.VolumeProviderParametersAzureFileArgs>? AzureFileParameters { get; set; }

        /// <summary>
        /// User readable description of the volume.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Provider of the volume.
        /// </summary>
        [Input("provider", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.ServiceFabricMesh.V20180701Preview.VolumeProvider> Provider { get; set; } = null!;

        /// <summary>
        /// Azure resource group name
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
        /// The identity of the volume.
        /// </summary>
        [Input("volumeName", required: true)]
        public Input<string> VolumeName { get; set; } = null!;

        public VolumeArgs()
        {
        }
    }
}
