// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerRegistry.V20170301
{
    /// <summary>
    /// An object that represents a container registry.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:containerregistry/v20170301:Registry")]
    public partial class Registry : Pulumi.CustomResource
    {
        /// <summary>
        /// The value that indicates whether the admin user is enabled.
        /// </summary>
        [Output("adminUserEnabled")]
        public Output<bool?> AdminUserEnabled { get; private set; } = null!;

        /// <summary>
        /// The creation date of the container registry in ISO8601 format.
        /// </summary>
        [Output("creationDate")]
        public Output<string> CreationDate { get; private set; } = null!;

        /// <summary>
        /// The location of the resource. This cannot be changed after the resource is created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The URL that can be used to log into the container registry.
        /// </summary>
        [Output("loginServer")]
        public Output<string> LoginServer { get; private set; } = null!;

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the container registry at the time the operation was called.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The SKU of the container registry.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse> Sku { get; private set; } = null!;

        /// <summary>
        /// The properties of the storage account for the container registry.
        /// </summary>
        [Output("storageAccount")]
        public Output<Outputs.StorageAccountPropertiesResponse?> StorageAccount { get; private set; } = null!;

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Registry resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Registry(string name, RegistryArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:containerregistry/v20170301:Registry", name, args ?? new RegistryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Registry(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:containerregistry/v20170301:Registry", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/latest:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20160627preview:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20170601preview:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20171001:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20190501:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20191201preview:Registry"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerregistry/v20201101preview:Registry"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Registry resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Registry Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Registry(name, id, options);
        }
    }

    public sealed class RegistryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The value that indicates whether the admin user is enabled.
        /// </summary>
        [Input("adminUserEnabled")]
        public Input<bool>? AdminUserEnabled { get; set; }

        /// <summary>
        /// The location of the container registry. This cannot be changed after the resource is created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the container registry.
        /// </summary>
        [Input("registryName", required: true)]
        public Input<string> RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the container registry.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.SkuArgs> Sku { get; set; } = null!;

        /// <summary>
        /// The parameters of a storage account for the container registry. If specified, the storage account must be in the same physical location as the container registry.
        /// </summary>
        [Input("storageAccount", required: true)]
        public Input<Inputs.StorageAccountParametersArgs> StorageAccount { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The tags for the container registry.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public RegistryArgs()
        {
            AdminUserEnabled = false;
        }
    }
}
