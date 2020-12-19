// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201
{
    /// <summary>
    /// Contract details.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/v20191201:ApiTagDescription")]
    public partial class ApiTagDescription : Pulumi.CustomResource
    {
        /// <summary>
        /// Description of the Tag.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Tag name.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Description of the external resources describing the tag.
        /// </summary>
        [Output("externalDocsDescription")]
        public Output<string?> ExternalDocsDescription { get; private set; } = null!;

        /// <summary>
        /// Absolute URL of external resources describing the tag.
        /// </summary>
        [Output("externalDocsUrl")]
        public Output<string?> ExternalDocsUrl { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Identifier of the tag in the form of /tags/{tagId}
        /// </summary>
        [Output("tagId")]
        public Output<string?> TagId { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ApiTagDescription resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiTagDescription(string name, ApiTagDescriptionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201:ApiTagDescription", name, args ?? new ApiTagDescriptionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiTagDescription(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20191201:ApiTagDescription", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201preview:ApiTagDescription"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:ApiTagDescription"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ApiTagDescription resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiTagDescription Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ApiTagDescription(name, id, options);
        }
    }

    public sealed class ApiTagDescriptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Description of the Tag.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Description of the external resources describing the tag.
        /// </summary>
        [Input("externalDocsDescription")]
        public Input<string>? ExternalDocsDescription { get; set; }

        /// <summary>
        /// Absolute URL of external resources describing the tag.
        /// </summary>
        [Input("externalDocsUrl")]
        public Input<string>? ExternalDocsUrl { get; set; }

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

        /// <summary>
        /// Tag description identifier. Used when creating tagDescription for API/Tag association. Based on API and Tag names.
        /// </summary>
        [Input("tagDescriptionId", required: true)]
        public Input<string> TagDescriptionId { get; set; } = null!;

        public ApiTagDescriptionArgs()
        {
        }
    }
}
