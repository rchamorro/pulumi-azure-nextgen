// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20200401Preview
{
    /// <summary>
    /// A sql database resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:synapse/v20200401preview:SqlDatabase")]
    public partial class SqlDatabase : Pulumi.CustomResource
    {
        /// <summary>
        /// The collation of the database.
        /// </summary>
        [Output("collation")]
        public Output<string?> Collation { get; private set; } = null!;

        /// <summary>
        /// The Guid of the database.
        /// </summary>
        [Output("databaseGuid")]
        public Output<string> DatabaseGuid { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The max size of the database expressed in bytes.
        /// </summary>
        [Output("maxSizeBytes")]
        public Output<int?> MaxSizeBytes { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Status of the database.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// SystemData of SqlDatabase.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SqlDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SqlDatabase(string name, SqlDatabaseArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20200401preview:SqlDatabase", name, args ?? new SqlDatabaseArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SqlDatabase(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:synapse/v20200401preview:SqlDatabase", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SqlDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SqlDatabase Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SqlDatabase(name, id, options);
        }
    }

    public sealed class SqlDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The collation of the database.
        /// </summary>
        [Input("collation")]
        public Input<string>? Collation { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The max size of the database expressed in bytes.
        /// </summary>
        [Input("maxSizeBytes")]
        public Input<int>? MaxSizeBytes { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the sql database.
        /// </summary>
        [Input("sqlDatabaseName", required: true)]
        public Input<string> SqlDatabaseName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public SqlDatabaseArgs()
        {
        }
    }
}
