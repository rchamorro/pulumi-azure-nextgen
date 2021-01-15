// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20190301
{
    /// <summary>
    /// Compute role.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:databoxedge/v20190301:Role")]
    public partial class Role : Pulumi.CustomResource
    {
        /// <summary>
        /// Role type.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// The object name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Role resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Role(string name, RoleArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20190301:Role", name, args ?? new RoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Role(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:databoxedge/v20190301:Role", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/latest:Role"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190701:Role"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20190801:Role"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200501preview:Role"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200901:Role"},
                    new Pulumi.Alias { Type = "azure-nextgen:databoxedge/v20200901preview:Role"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Role resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Role Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Role(name, id, options);
        }
    }

    public sealed class RoleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// Role type.
        /// </summary>
        [Input("kind", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.DataBoxEdge.V20190301.RoleTypes> Kind { get; set; } = null!;

        /// <summary>
        /// The role name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public RoleArgs()
        {
        }
    }
}
