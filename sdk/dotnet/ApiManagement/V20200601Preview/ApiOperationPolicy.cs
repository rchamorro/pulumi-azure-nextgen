// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20200601Preview
{
    /// <summary>
    /// Policy Contract details.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/v20200601preview:ApiOperationPolicy")]
    public partial class ApiOperationPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Contents of the Policy as defined by the format.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a ApiOperationPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiOperationPolicy(string name, ApiOperationPolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20200601preview:ApiOperationPolicy", name, args ?? new ApiOperationPolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiOperationPolicy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20200601preview:ApiOperationPolicy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180101:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:ApiOperationPolicy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201preview:ApiOperationPolicy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ApiOperationPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiOperationPolicy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ApiOperationPolicy(name, id, options);
        }
    }

    public sealed class ApiOperationPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Input("format")]
        public InputUnion<string, Pulumi.AzureNextGen.ApiManagement.V20200601Preview.PolicyContentFormat>? Format { get; set; }

        /// <summary>
        /// Operation identifier within an API. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("operationId", required: true)]
        public Input<string> OperationId { get; set; } = null!;

        /// <summary>
        /// The identifier of the Policy.
        /// </summary>
        [Input("policyId", required: true)]
        public Input<string> PolicyId { get; set; } = null!;

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
        /// Contents of the Policy as defined by the format.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ApiOperationPolicyArgs()
        {
            Format = "xml";
        }
    }
}
