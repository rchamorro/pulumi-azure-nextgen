// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.Latest
{
    /// <summary>
    /// Specifies information about the gallery Application Version that you want to create or update.
    /// Latest API Version: 2020-09-30.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:compute/latest:GalleryApplicationVersion")]
    public partial class GalleryApplicationVersion : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The publishing profile of a gallery image version.
        /// </summary>
        [Output("publishingProfile")]
        public Output<Outputs.GalleryApplicationVersionPublishingProfileResponse> PublishingProfile { get; private set; } = null!;

        /// <summary>
        /// This is the replication status of the gallery image version.
        /// </summary>
        [Output("replicationStatus")]
        public Output<Outputs.ReplicationStatusResponse> ReplicationStatus { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a GalleryApplicationVersion resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GalleryApplicationVersion(string name, GalleryApplicationVersionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/latest:GalleryApplicationVersion", name, args ?? new GalleryApplicationVersionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GalleryApplicationVersion(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/latest:GalleryApplicationVersion", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190301:GalleryApplicationVersion"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190701:GalleryApplicationVersion"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20191201:GalleryApplicationVersion"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20200930:GalleryApplicationVersion"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing GalleryApplicationVersion resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GalleryApplicationVersion Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GalleryApplicationVersion(name, id, options);
        }
    }

    public sealed class GalleryApplicationVersionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the gallery Application Definition in which the Application Version is to be created.
        /// </summary>
        [Input("galleryApplicationName", required: true)]
        public Input<string> GalleryApplicationName { get; set; } = null!;

        /// <summary>
        /// The name of the gallery Application Version to be created. Needs to follow semantic version name pattern: The allowed characters are digit and period. Digits must be within the range of a 32-bit integer. Format: &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
        /// </summary>
        [Input("galleryApplicationVersionName", required: true)]
        public Input<string> GalleryApplicationVersionName { get; set; } = null!;

        /// <summary>
        /// The name of the Shared Application Gallery in which the Application Definition resides.
        /// </summary>
        [Input("galleryName", required: true)]
        public Input<string> GalleryName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The publishing profile of a gallery image version.
        /// </summary>
        [Input("publishingProfile", required: true)]
        public Input<Inputs.GalleryApplicationVersionPublishingProfileArgs> PublishingProfile { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

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

        public GalleryApplicationVersionArgs()
        {
        }
    }
}
