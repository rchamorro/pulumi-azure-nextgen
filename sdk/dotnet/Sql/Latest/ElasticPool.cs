// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Sql.Latest
{
    /// <summary>
    /// Represents a database elastic pool.
    /// Latest API Version: 2014-04-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:sql/latest:ElasticPool")]
    public partial class ElasticPool : Pulumi.CustomResource
    {
        /// <summary>
        /// The creation date of the elastic pool (ISO8601 format).
        /// </summary>
        [Output("creationDate")]
        public Output<string> CreationDate { get; private set; } = null!;

        /// <summary>
        /// The maximum DTU any one database can consume.
        /// </summary>
        [Output("databaseDtuMax")]
        public Output<int?> DatabaseDtuMax { get; private set; } = null!;

        /// <summary>
        /// The minimum DTU all databases are guaranteed.
        /// </summary>
        [Output("databaseDtuMin")]
        public Output<int?> DatabaseDtuMin { get; private set; } = null!;

        /// <summary>
        /// The total shared DTU for the database elastic pool.
        /// </summary>
        [Output("dtu")]
        public Output<int?> Dtu { get; private set; } = null!;

        /// <summary>
        /// The edition of the elastic pool.
        /// </summary>
        [Output("edition")]
        public Output<string?> Edition { get; private set; } = null!;

        /// <summary>
        /// Kind of elastic pool.  This is metadata used for the Azure portal experience.
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The state of the elastic pool.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// Gets storage limit for the database elastic pool in MB.
        /// </summary>
        [Output("storageMB")]
        public Output<int?> StorageMB { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Whether or not this database elastic pool is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
        /// </summary>
        [Output("zoneRedundant")]
        public Output<bool?> ZoneRedundant { get; private set; } = null!;


        /// <summary>
        /// Create a ElasticPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ElasticPool(string name, ElasticPoolArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:sql/latest:ElasticPool", name, args ?? new ElasticPoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ElasticPool(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:sql/latest:ElasticPool", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:sql/v20140401:ElasticPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:sql/v20171001preview:ElasticPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:sql/v20200202preview:ElasticPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:sql/v20200801preview:ElasticPool"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ElasticPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ElasticPool Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ElasticPool(name, id, options);
        }
    }

    public sealed class ElasticPoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum DTU any one database can consume.
        /// </summary>
        [Input("databaseDtuMax")]
        public Input<int>? DatabaseDtuMax { get; set; }

        /// <summary>
        /// The minimum DTU all databases are guaranteed.
        /// </summary>
        [Input("databaseDtuMin")]
        public Input<int>? DatabaseDtuMin { get; set; }

        /// <summary>
        /// The total shared DTU for the database elastic pool.
        /// </summary>
        [Input("dtu")]
        public Input<int>? Dtu { get; set; }

        /// <summary>
        /// The edition of the elastic pool.
        /// </summary>
        [Input("edition")]
        public InputUnion<string, Pulumi.AzureNextGen.Sql.Latest.ElasticPoolEdition>? Edition { get; set; }

        /// <summary>
        /// The name of the elastic pool to be operated on (updated or created).
        /// </summary>
        [Input("elasticPoolName", required: true)]
        public Input<string> ElasticPoolName { get; set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the server.
        /// </summary>
        [Input("serverName", required: true)]
        public Input<string> ServerName { get; set; } = null!;

        /// <summary>
        /// Gets storage limit for the database elastic pool in MB.
        /// </summary>
        [Input("storageMB")]
        public Input<int>? StorageMB { get; set; }

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
        /// Whether or not this database elastic pool is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
        /// </summary>
        [Input("zoneRedundant")]
        public Input<bool>? ZoneRedundant { get; set; }

        public ElasticPoolArgs()
        {
        }
    }
}
