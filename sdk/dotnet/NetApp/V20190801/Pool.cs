// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20190801
{
    /// <summary>
    /// Capacity pool resource
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:netapp/v20190801:Pool")]
    public partial class Pool : Pulumi.CustomResource
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
        /// UUID v4 used to identify the Pool
        /// </summary>
        [Output("poolId")]
        public Output<string> PoolId { get; private set; } = null!;

        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The service level of the file system
        /// </summary>
        [Output("serviceLevel")]
        public Output<string> ServiceLevel { get; private set; } = null!;

        /// <summary>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB chunks (value must be multiply of 4398046511104).
        /// </summary>
        [Output("size")]
        public Output<double> Size { get; private set; } = null!;

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
        /// Create a Pool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Pool(string name, PoolArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190801:Pool", name, args ?? new PoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Pool(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:netapp/v20190801:Pool", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/latest:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20170815:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190501:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190601:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20190701:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191001:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20191101:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200201:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200301:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200501:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200601:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200701:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200801:Pool"},
                    new Pulumi.Alias { Type = "azure-nextgen:netapp/v20200901:Pool"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Pool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Pool Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Pool(name, id, options);
        }
    }

    public sealed class PoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public Input<string> PoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The service level of the file system
        /// </summary>
        [Input("serviceLevel", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.NetApp.V20190801.ServiceLevel> ServiceLevel { get; set; } = null!;

        /// <summary>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB chunks (value must be multiply of 4398046511104).
        /// </summary>
        [Input("size", required: true)]
        public Input<double> Size { get; set; } = null!;

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

        public PoolArgs()
        {
        }
    }
}
