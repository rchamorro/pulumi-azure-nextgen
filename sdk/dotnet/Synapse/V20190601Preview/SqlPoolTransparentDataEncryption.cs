// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20190601Preview
{
    /// <summary>
    /// Represents a Sql pool transparent data encryption configuration.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:synapse/v20190601preview:SqlPoolTransparentDataEncryption")]
    public partial class SqlPoolTransparentDataEncryption : Pulumi.CustomResource
    {
        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The status of the database transparent data encryption.
        /// </summary>
        [Output("status")]
        public Output<string?> Status { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SqlPoolTransparentDataEncryption resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SqlPoolTransparentDataEncryption(string name, SqlPoolTransparentDataEncryptionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20190601preview:SqlPoolTransparentDataEncryption", name, args ?? new SqlPoolTransparentDataEncryptionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SqlPoolTransparentDataEncryption(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20190601preview:SqlPoolTransparentDataEncryption", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:synapse/v20201201:SqlPoolTransparentDataEncryption"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SqlPoolTransparentDataEncryption resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SqlPoolTransparentDataEncryption Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SqlPoolTransparentDataEncryption(name, id, options);
        }
    }

    public sealed class SqlPoolTransparentDataEncryptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// SQL pool name
        /// </summary>
        [Input("sqlPoolName", required: true)]
        public Input<string> SqlPoolName { get; set; } = null!;

        /// <summary>
        /// The status of the database transparent data encryption.
        /// </summary>
        [Input("status")]
        public InputUnion<string, Pulumi.AzureNextGen.Synapse.V20190601Preview.TransparentDataEncryptionStatus>? Status { get; set; }

        /// <summary>
        /// The name of the transparent data encryption configuration.
        /// </summary>
        [Input("transparentDataEncryptionName", required: true)]
        public Input<string> TransparentDataEncryptionName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public SqlPoolTransparentDataEncryptionArgs()
        {
        }
    }
}
