// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview
{
    /// <summary>
    /// Dataset resource type.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:datafactory/v20170901preview:Dataset")]
    public partial class Dataset : Pulumi.CustomResource
    {
        /// <summary>
        /// Etag identifies change in the resource.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Dataset properties.
        /// </summary>
        [Output("properties")]
        public Output<Union<Outputs.AmazonMWSObjectDatasetResponse, Union<Outputs.AmazonS3DatasetResponse, Union<Outputs.AzureBlobDatasetResponse, Union<Outputs.AzureDataLakeStoreDatasetResponse, Union<Outputs.AzureMySqlTableDatasetResponse, Union<Outputs.AzurePostgreSqlTableDatasetResponse, Union<Outputs.AzureSearchIndexDatasetResponse, Union<Outputs.AzureSqlDWTableDatasetResponse, Union<Outputs.AzureSqlTableDatasetResponse, Union<Outputs.AzureTableDatasetResponse, Union<Outputs.CassandraTableDatasetResponse, Union<Outputs.ConcurObjectDatasetResponse, Union<Outputs.CouchbaseTableDatasetResponse, Union<Outputs.CustomDatasetResponse, Union<Outputs.DocumentDbCollectionDatasetResponse, Union<Outputs.DrillTableDatasetResponse, Union<Outputs.DynamicsEntityDatasetResponse, Union<Outputs.EloquaObjectDatasetResponse, Union<Outputs.FileShareDatasetResponse, Union<Outputs.GoogleBigQueryObjectDatasetResponse, Union<Outputs.GreenplumTableDatasetResponse, Union<Outputs.HBaseObjectDatasetResponse, Union<Outputs.HiveObjectDatasetResponse, Union<Outputs.HttpDatasetResponse, Union<Outputs.HubspotObjectDatasetResponse, Union<Outputs.ImpalaObjectDatasetResponse, Union<Outputs.JiraObjectDatasetResponse, Union<Outputs.MagentoObjectDatasetResponse, Union<Outputs.MariaDBTableDatasetResponse, Union<Outputs.MarketoObjectDatasetResponse, Union<Outputs.MongoDbCollectionDatasetResponse, Union<Outputs.NetezzaTableDatasetResponse, Union<Outputs.ODataResourceDatasetResponse, Union<Outputs.OracleTableDatasetResponse, Union<Outputs.PaypalObjectDatasetResponse, Union<Outputs.PhoenixObjectDatasetResponse, Union<Outputs.PrestoObjectDatasetResponse, Union<Outputs.QuickBooksObjectDatasetResponse, Union<Outputs.RelationalTableDatasetResponse, Union<Outputs.ResponsysObjectDatasetResponse, Union<Outputs.SalesforceMarketingCloudObjectDatasetResponse, Union<Outputs.SalesforceObjectDatasetResponse, Union<Outputs.SapCloudForCustomerResourceDatasetResponse, Union<Outputs.SapEccResourceDatasetResponse, Union<Outputs.ServiceNowObjectDatasetResponse, Union<Outputs.ShopifyObjectDatasetResponse, Union<Outputs.SparkObjectDatasetResponse, Union<Outputs.SqlServerTableDatasetResponse, Union<Outputs.SquareObjectDatasetResponse, Union<Outputs.VerticaTableDatasetResponse, Union<Outputs.WebTableDatasetResponse, Union<Outputs.XeroObjectDatasetResponse, Outputs.ZohoObjectDatasetResponse>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Properties { get; private set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Dataset resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Dataset(string name, DatasetArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:datafactory/v20170901preview:Dataset", name, args ?? new DatasetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Dataset(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:datafactory/v20170901preview:Dataset", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:datafactory/latest:Dataset"},
                    new Pulumi.Alias { Type = "azure-nextgen:datafactory/v20180601:Dataset"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Dataset resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Dataset Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Dataset(name, id, options);
        }
    }

    public sealed class DatasetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The dataset name.
        /// </summary>
        [Input("datasetName", required: true)]
        public Input<string> DatasetName { get; set; } = null!;

        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public Input<string> FactoryName { get; set; } = null!;

        /// <summary>
        /// Dataset properties.
        /// </summary>
        [Input("properties", required: true)]
        public InputUnion<Inputs.AmazonMWSObjectDatasetArgs, InputUnion<Inputs.AmazonS3DatasetArgs, InputUnion<Inputs.AzureBlobDatasetArgs, InputUnion<Inputs.AzureDataLakeStoreDatasetArgs, InputUnion<Inputs.AzureMySqlTableDatasetArgs, InputUnion<Inputs.AzurePostgreSqlTableDatasetArgs, InputUnion<Inputs.AzureSearchIndexDatasetArgs, InputUnion<Inputs.AzureSqlDWTableDatasetArgs, InputUnion<Inputs.AzureSqlTableDatasetArgs, InputUnion<Inputs.AzureTableDatasetArgs, InputUnion<Inputs.CassandraTableDatasetArgs, InputUnion<Inputs.ConcurObjectDatasetArgs, InputUnion<Inputs.CouchbaseTableDatasetArgs, InputUnion<Inputs.CustomDatasetArgs, InputUnion<Inputs.DocumentDbCollectionDatasetArgs, InputUnion<Inputs.DrillTableDatasetArgs, InputUnion<Inputs.DynamicsEntityDatasetArgs, InputUnion<Inputs.EloquaObjectDatasetArgs, InputUnion<Inputs.FileShareDatasetArgs, InputUnion<Inputs.GoogleBigQueryObjectDatasetArgs, InputUnion<Inputs.GreenplumTableDatasetArgs, InputUnion<Inputs.HBaseObjectDatasetArgs, InputUnion<Inputs.HiveObjectDatasetArgs, InputUnion<Inputs.HttpDatasetArgs, InputUnion<Inputs.HubspotObjectDatasetArgs, InputUnion<Inputs.ImpalaObjectDatasetArgs, InputUnion<Inputs.JiraObjectDatasetArgs, InputUnion<Inputs.MagentoObjectDatasetArgs, InputUnion<Inputs.MariaDBTableDatasetArgs, InputUnion<Inputs.MarketoObjectDatasetArgs, InputUnion<Inputs.MongoDbCollectionDatasetArgs, InputUnion<Inputs.NetezzaTableDatasetArgs, InputUnion<Inputs.ODataResourceDatasetArgs, InputUnion<Inputs.OracleTableDatasetArgs, InputUnion<Inputs.PaypalObjectDatasetArgs, InputUnion<Inputs.PhoenixObjectDatasetArgs, InputUnion<Inputs.PrestoObjectDatasetArgs, InputUnion<Inputs.QuickBooksObjectDatasetArgs, InputUnion<Inputs.RelationalTableDatasetArgs, InputUnion<Inputs.ResponsysObjectDatasetArgs, InputUnion<Inputs.SalesforceMarketingCloudObjectDatasetArgs, InputUnion<Inputs.SalesforceObjectDatasetArgs, InputUnion<Inputs.SapCloudForCustomerResourceDatasetArgs, InputUnion<Inputs.SapEccResourceDatasetArgs, InputUnion<Inputs.ServiceNowObjectDatasetArgs, InputUnion<Inputs.ShopifyObjectDatasetArgs, InputUnion<Inputs.SparkObjectDatasetArgs, InputUnion<Inputs.SqlServerTableDatasetArgs, InputUnion<Inputs.SquareObjectDatasetArgs, InputUnion<Inputs.VerticaTableDatasetArgs, InputUnion<Inputs.WebTableDatasetArgs, InputUnion<Inputs.XeroObjectDatasetArgs, Inputs.ZohoObjectDatasetArgs>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Properties { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DatasetArgs()
        {
        }
    }
}
