// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest
{
    /// <summary>
    /// An Asset.
    /// Latest API Version: 2020-05-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:media/latest:Asset")]
    public partial class Asset : Pulumi.CustomResource
    {
        /// <summary>
        /// The alternate ID of the Asset.
        /// </summary>
        [Output("alternateId")]
        public Output<string?> AlternateId { get; private set; } = null!;

        /// <summary>
        /// The Asset ID.
        /// </summary>
        [Output("assetId")]
        public Output<string> AssetId { get; private set; } = null!;

        /// <summary>
        /// The name of the asset blob container.
        /// </summary>
        [Output("container")]
        public Output<string?> Container { get; private set; } = null!;

        /// <summary>
        /// The creation date of the Asset.
        /// </summary>
        [Output("created")]
        public Output<string> Created { get; private set; } = null!;

        /// <summary>
        /// The Asset description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The last modified date of the Asset.
        /// </summary>
        [Output("lastModified")]
        public Output<string> LastModified { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the storage account.
        /// </summary>
        [Output("storageAccountName")]
        public Output<string?> StorageAccountName { get; private set; } = null!;

        /// <summary>
        /// The Asset encryption format. One of None or MediaStorageEncryption.
        /// </summary>
        [Output("storageEncryptionFormat")]
        public Output<string> StorageEncryptionFormat { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Asset resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Asset(string name, AssetArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:media/latest:Asset", name, args ?? new AssetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Asset(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:media/latest:Asset", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180330preview:Asset"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180601preview:Asset"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20180701:Asset"},
                    new Pulumi.Alias { Type = "azure-nextgen:media/v20200501:Asset"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Asset resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Asset Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Asset(name, id, options);
        }
    }

    public sealed class AssetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// The alternate ID of the Asset.
        /// </summary>
        [Input("alternateId")]
        public Input<string>? AlternateId { get; set; }

        /// <summary>
        /// The Asset name.
        /// </summary>
        [Input("assetName", required: true)]
        public Input<string> AssetName { get; set; } = null!;

        /// <summary>
        /// The name of the asset blob container.
        /// </summary>
        [Input("container")]
        public Input<string>? Container { get; set; }

        /// <summary>
        /// The Asset description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the storage account.
        /// </summary>
        [Input("storageAccountName")]
        public Input<string>? StorageAccountName { get; set; }

        public AssetArgs()
        {
        }
    }
}
