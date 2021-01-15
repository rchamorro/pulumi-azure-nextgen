// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20180101
{
    /// <summary>
    /// Policy Contract details.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:apimanagement/v20180101:Policy")]
    public partial class Policy : Pulumi.CustomResource
    {
        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Output("contentFormat")]
        public Output<string?> ContentFormat { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Json escaped Xml Encoded contents of the Policy.
        /// </summary>
        [Output("policyContent")]
        public Output<string> PolicyContent { get; private set; } = null!;

        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Policy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Policy(string name, PolicyArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20180101:Policy", name, args ?? new PolicyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Policy(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:apimanagement/v20180101:Policy", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/latest:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20170301:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20180601preview:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20190101:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20191201preview:Policy"},
                    new Pulumi.Alias { Type = "azure-nextgen:apimanagement/v20200601preview:Policy"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Policy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Policy Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Policy(name, id, options);
        }
    }

    public sealed class PolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Format of the policyContent.
        /// </summary>
        [Input("contentFormat")]
        public InputUnion<string, Pulumi.AzureNextGen.ApiManagement.V20180101.PolicyContentFormat>? ContentFormat { get; set; }

        /// <summary>
        /// Json escaped Xml Encoded contents of the Policy.
        /// </summary>
        [Input("policyContent", required: true)]
        public Input<string> PolicyContent { get; set; } = null!;

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

        public PolicyArgs()
        {
            ContentFormat = "xml";
        }
    }
}
