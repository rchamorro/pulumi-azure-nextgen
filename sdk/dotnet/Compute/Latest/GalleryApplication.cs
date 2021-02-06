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
    /// Specifies information about the gallery Application Definition that you want to create or update.
    /// Latest API Version: 2020-09-30.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:compute/latest:GalleryApplication")]
    public partial class GalleryApplication : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable.
        /// </summary>
        [Output("endOfLifeDate")]
        public Output<string?> EndOfLifeDate { get; private set; } = null!;

        /// <summary>
        /// The Eula agreement for the gallery Application Definition.
        /// </summary>
        [Output("eula")]
        public Output<string?> Eula { get; private set; } = null!;

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
        /// The privacy statement uri.
        /// </summary>
        [Output("privacyStatementUri")]
        public Output<string?> PrivacyStatementUri { get; private set; } = null!;

        /// <summary>
        /// The release note uri.
        /// </summary>
        [Output("releaseNoteUri")]
        public Output<string?> ReleaseNoteUri { get; private set; } = null!;

        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**
        /// </summary>
        [Output("supportedOSType")]
        public Output<string> SupportedOSType { get; private set; } = null!;

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
        /// Create a GalleryApplication resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public GalleryApplication(string name, GalleryApplicationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/latest:GalleryApplication", name, args ?? new GalleryApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private GalleryApplication(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:compute/latest:GalleryApplication", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190301:GalleryApplication"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20190701:GalleryApplication"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20191201:GalleryApplication"},
                    new Pulumi.Alias { Type = "azure-nextgen:compute/v20200930:GalleryApplication"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing GalleryApplication resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static GalleryApplication Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new GalleryApplication(name, id, options);
        }
    }

    public sealed class GalleryApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable.
        /// </summary>
        [Input("endOfLifeDate")]
        public Input<string>? EndOfLifeDate { get; set; }

        /// <summary>
        /// The Eula agreement for the gallery Application Definition.
        /// </summary>
        [Input("eula")]
        public Input<string>? Eula { get; set; }

        /// <summary>
        /// The name of the gallery Application Definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters.
        /// </summary>
        [Input("galleryApplicationName", required: true)]
        public Input<string> GalleryApplicationName { get; set; } = null!;

        /// <summary>
        /// The name of the Shared Application Gallery in which the Application Definition is to be created.
        /// </summary>
        [Input("galleryName", required: true)]
        public Input<string> GalleryName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The privacy statement uri.
        /// </summary>
        [Input("privacyStatementUri")]
        public Input<string>? PrivacyStatementUri { get; set; }

        /// <summary>
        /// The release note uri.
        /// </summary>
        [Input("releaseNoteUri")]
        public Input<string>? ReleaseNoteUri { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**
        /// </summary>
        [Input("supportedOSType", required: true)]
        public Input<Pulumi.AzureNextGen.Compute.Latest.OperatingSystemTypes> SupportedOSType { get; set; } = null!;

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

        public GalleryApplicationArgs()
        {
        }
    }
}
