// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Portal.Latest
{
    /// <summary>
    /// Response to get user settings
    /// Latest API Version: 2018-10-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:portal/latest:UserSettingsWithLocation")]
    public partial class UserSettingsWithLocation : Pulumi.CustomResource
    {
        /// <summary>
        /// The cloud shell user settings properties.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.UserPropertiesResponse> Properties { get; private set; } = null!;


        /// <summary>
        /// Create a UserSettingsWithLocation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserSettingsWithLocation(string name, UserSettingsWithLocationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:portal/latest:UserSettingsWithLocation", name, args ?? new UserSettingsWithLocationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserSettingsWithLocation(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:portal/latest:UserSettingsWithLocation", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:portal/v20181001:UserSettingsWithLocation"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing UserSettingsWithLocation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserSettingsWithLocation Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new UserSettingsWithLocation(name, id, options);
        }
    }

    public sealed class UserSettingsWithLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The provider location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The cloud shell user settings properties.
        /// </summary>
        [Input("properties", required: true)]
        public Input<Inputs.UserPropertiesArgs> Properties { get; set; } = null!;

        /// <summary>
        /// The name of the user settings
        /// </summary>
        [Input("userSettingsName", required: true)]
        public Input<string> UserSettingsName { get; set; } = null!;

        public UserSettingsWithLocationArgs()
        {
        }
    }
}
