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
    /// </summary>
    public partial class ContentType : Pulumi.CustomResource
    {
        /// <summary>
        /// Content type description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Content type schema.
        /// </summary>
        [Output("schema")]
        public Output<object?> Schema { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Content type version.
        /// </summary>
        [Output("version")]
        public Output<string?> Version { get; private set; } = null!;


        /// <summary>
        /// Create a ContentType resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ContentType(string name, ContentTypeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ContentType", name, args ?? new ContentTypeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ContentType(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/latest:ContentType", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:ContentType"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ContentType resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ContentType Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ContentType(name, id, options);
        }
    }

    public sealed class ContentTypeArgs : Pulumi.ResourceArgs
    {
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

        public ContentTypeArgs()
        {
        }
    }
}
