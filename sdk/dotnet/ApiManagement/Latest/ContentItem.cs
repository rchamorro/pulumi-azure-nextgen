// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.Latest
{
    /// <summary>
    /// Content type contract details.
    /// Latest API Version: 2019-12-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/latest:ContentItem")]
    public partial class ContentItem : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Properties of the content item.
        /// </summary>
        [Output("properties")]
        public Output<object> Properties { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ContentItem resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContentItem(string name, ContentItemArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ContentItem", name, args ?? new ContentItemArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContentItem(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ContentItem", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:ContentItem"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:ContentItem"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ContentItem resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContentItem Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ContentItem(name, id, options);
        }
    }

    public sealed class ContentItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Content item identifier.
        /// </summary>
        [Input("contentItemId", required: true)]
        public Input<string> ContentItemId { get; set; } = null!;

        /// <summary>
        /// Content type identifier.
        /// </summary>
        [Input("contentTypeId", required: true)]
        public Input<string> ContentTypeId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ContentItemArgs()
        {
        }
    }
}
