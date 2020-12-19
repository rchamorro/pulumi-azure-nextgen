// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Kusto.Latest
{
    /// <summary>
    /// Class representing an data connection.
    /// Latest API Version: 2020-09-18.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:kusto/latest:DataConnection")]
    public partial class DataConnection : Pulumi.CustomResource
    {
        /// <summary>
        /// Kind of the endpoint for the data connection
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DataConnection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DataConnection(string name, DataConnectionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:kusto/latest:DataConnection", name, args ?? new DataConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DataConnection(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:kusto/latest:DataConnection", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20190121:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20190515:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20190907:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20191109:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20200215:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20200614:DataConnection"},
                    new Pulumi.Alias { Type = "azure-nextgen:kusto/v20200918:DataConnection"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DataConnection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DataConnection Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DataConnection(name, id, options);
        }
    }

    public sealed class DataConnectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Kusto cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The name of the data connection.
        /// </summary>
        [Input("dataConnectionName", required: true)]
        public Input<string> DataConnectionName { get; set; } = null!;

        /// <summary>
        /// The name of the database in the Kusto cluster.
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        /// <summary>
        /// Kind of the endpoint for the data connection
        /// </summary>
        [Input("kind", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.Kusto.Latest.DataConnectionKind> Kind { get; set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group containing the Kusto cluster.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DataConnectionArgs()
        {
        }
    }
}
