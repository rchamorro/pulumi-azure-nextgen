// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Dataset resource type.
 */
export class Dataset extends pulumi.CustomResource {
    /**
     * Get an existing Dataset resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Dataset {
        return new Dataset(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:datafactory/latest:Dataset';

    /**
     * Returns true if the given object is an instance of Dataset.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Dataset {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Dataset.__pulumiType;
    }

    /**
     * Etag identifies change in the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Dataset properties.
     */
    public readonly properties!: pulumi.Output<outputs.datafactory.latest.AmazonMWSObjectDatasetResponse | outputs.datafactory.latest.AmazonRedshiftTableDatasetResponse | outputs.datafactory.latest.AmazonS3DatasetResponse | outputs.datafactory.latest.AvroDatasetResponse | outputs.datafactory.latest.AzureBlobDatasetResponse | outputs.datafactory.latest.AzureBlobFSDatasetResponse | outputs.datafactory.latest.AzureDataExplorerTableDatasetResponse | outputs.datafactory.latest.AzureDataLakeStoreDatasetResponse | outputs.datafactory.latest.AzureDatabricksDeltaLakeDatasetResponse | outputs.datafactory.latest.AzureMariaDBTableDatasetResponse | outputs.datafactory.latest.AzureMySqlTableDatasetResponse | outputs.datafactory.latest.AzurePostgreSqlTableDatasetResponse | outputs.datafactory.latest.AzureSearchIndexDatasetResponse | outputs.datafactory.latest.AzureSqlDWTableDatasetResponse | outputs.datafactory.latest.AzureSqlMITableDatasetResponse | outputs.datafactory.latest.AzureSqlTableDatasetResponse | outputs.datafactory.latest.AzureTableDatasetResponse | outputs.datafactory.latest.BinaryDatasetResponse | outputs.datafactory.latest.CassandraTableDatasetResponse | outputs.datafactory.latest.CommonDataServiceForAppsEntityDatasetResponse | outputs.datafactory.latest.ConcurObjectDatasetResponse | outputs.datafactory.latest.CosmosDbMongoDbApiCollectionDatasetResponse | outputs.datafactory.latest.CosmosDbSqlApiCollectionDatasetResponse | outputs.datafactory.latest.CouchbaseTableDatasetResponse | outputs.datafactory.latest.CustomDatasetResponse | outputs.datafactory.latest.Db2TableDatasetResponse | outputs.datafactory.latest.DelimitedTextDatasetResponse | outputs.datafactory.latest.DocumentDbCollectionDatasetResponse | outputs.datafactory.latest.DrillTableDatasetResponse | outputs.datafactory.latest.DynamicsAXResourceDatasetResponse | outputs.datafactory.latest.DynamicsCrmEntityDatasetResponse | outputs.datafactory.latest.DynamicsEntityDatasetResponse | outputs.datafactory.latest.EloquaObjectDatasetResponse | outputs.datafactory.latest.ExcelDatasetResponse | outputs.datafactory.latest.FileShareDatasetResponse | outputs.datafactory.latest.GoogleAdWordsObjectDatasetResponse | outputs.datafactory.latest.GoogleBigQueryObjectDatasetResponse | outputs.datafactory.latest.GreenplumTableDatasetResponse | outputs.datafactory.latest.HBaseObjectDatasetResponse | outputs.datafactory.latest.HiveObjectDatasetResponse | outputs.datafactory.latest.HttpDatasetResponse | outputs.datafactory.latest.HubspotObjectDatasetResponse | outputs.datafactory.latest.ImpalaObjectDatasetResponse | outputs.datafactory.latest.InformixTableDatasetResponse | outputs.datafactory.latest.JiraObjectDatasetResponse | outputs.datafactory.latest.JsonDatasetResponse | outputs.datafactory.latest.MagentoObjectDatasetResponse | outputs.datafactory.latest.MariaDBTableDatasetResponse | outputs.datafactory.latest.MarketoObjectDatasetResponse | outputs.datafactory.latest.MicrosoftAccessTableDatasetResponse | outputs.datafactory.latest.MongoDbAtlasCollectionDatasetResponse | outputs.datafactory.latest.MongoDbCollectionDatasetResponse | outputs.datafactory.latest.MongoDbV2CollectionDatasetResponse | outputs.datafactory.latest.MySqlTableDatasetResponse | outputs.datafactory.latest.NetezzaTableDatasetResponse | outputs.datafactory.latest.ODataResourceDatasetResponse | outputs.datafactory.latest.OdbcTableDatasetResponse | outputs.datafactory.latest.Office365DatasetResponse | outputs.datafactory.latest.OracleServiceCloudObjectDatasetResponse | outputs.datafactory.latest.OracleTableDatasetResponse | outputs.datafactory.latest.OrcDatasetResponse | outputs.datafactory.latest.ParquetDatasetResponse | outputs.datafactory.latest.PaypalObjectDatasetResponse | outputs.datafactory.latest.PhoenixObjectDatasetResponse | outputs.datafactory.latest.PostgreSqlTableDatasetResponse | outputs.datafactory.latest.PrestoObjectDatasetResponse | outputs.datafactory.latest.QuickBooksObjectDatasetResponse | outputs.datafactory.latest.RelationalTableDatasetResponse | outputs.datafactory.latest.ResponsysObjectDatasetResponse | outputs.datafactory.latest.RestResourceDatasetResponse | outputs.datafactory.latest.SalesforceMarketingCloudObjectDatasetResponse | outputs.datafactory.latest.SalesforceObjectDatasetResponse | outputs.datafactory.latest.SalesforceServiceCloudObjectDatasetResponse | outputs.datafactory.latest.SapBwCubeDatasetResponse | outputs.datafactory.latest.SapCloudForCustomerResourceDatasetResponse | outputs.datafactory.latest.SapEccResourceDatasetResponse | outputs.datafactory.latest.SapHanaTableDatasetResponse | outputs.datafactory.latest.SapOpenHubTableDatasetResponse | outputs.datafactory.latest.SapTableResourceDatasetResponse | outputs.datafactory.latest.ServiceNowObjectDatasetResponse | outputs.datafactory.latest.SharePointOnlineListResourceDatasetResponse | outputs.datafactory.latest.ShopifyObjectDatasetResponse | outputs.datafactory.latest.SnowflakeDatasetResponse | outputs.datafactory.latest.SparkObjectDatasetResponse | outputs.datafactory.latest.SqlServerTableDatasetResponse | outputs.datafactory.latest.SquareObjectDatasetResponse | outputs.datafactory.latest.SybaseTableDatasetResponse | outputs.datafactory.latest.TeradataTableDatasetResponse | outputs.datafactory.latest.VerticaTableDatasetResponse | outputs.datafactory.latest.WebTableDatasetResponse | outputs.datafactory.latest.XeroObjectDatasetResponse | outputs.datafactory.latest.XmlDatasetResponse | outputs.datafactory.latest.ZohoObjectDatasetResponse>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Dataset resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatasetArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.datasetName === undefined) {
                throw new Error("Missing required property 'datasetName'");
            }
            if (!args || args.factoryName === undefined) {
                throw new Error("Missing required property 'factoryName'");
            }
            if (!args || args.properties === undefined) {
                throw new Error("Missing required property 'properties'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["datasetName"] = args ? args.datasetName : undefined;
            inputs["factoryName"] = args ? args.factoryName : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:datafactory/v20170901preview:Dataset" }, { type: "azure-nextgen:datafactory/v20180601:Dataset" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(Dataset.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Dataset resource.
 */
export interface DatasetArgs {
    /**
     * The dataset name.
     */
    readonly datasetName: pulumi.Input<string>;
    /**
     * The factory name.
     */
    readonly factoryName: pulumi.Input<string>;
    /**
     * Dataset properties.
     */
    readonly properties: pulumi.Input<inputs.datafactory.latest.AmazonMWSObjectDataset | inputs.datafactory.latest.AmazonRedshiftTableDataset | inputs.datafactory.latest.AmazonS3Dataset | inputs.datafactory.latest.AvroDataset | inputs.datafactory.latest.AzureBlobDataset | inputs.datafactory.latest.AzureBlobFSDataset | inputs.datafactory.latest.AzureDataExplorerTableDataset | inputs.datafactory.latest.AzureDataLakeStoreDataset | inputs.datafactory.latest.AzureDatabricksDeltaLakeDataset | inputs.datafactory.latest.AzureMariaDBTableDataset | inputs.datafactory.latest.AzureMySqlTableDataset | inputs.datafactory.latest.AzurePostgreSqlTableDataset | inputs.datafactory.latest.AzureSearchIndexDataset | inputs.datafactory.latest.AzureSqlDWTableDataset | inputs.datafactory.latest.AzureSqlMITableDataset | inputs.datafactory.latest.AzureSqlTableDataset | inputs.datafactory.latest.AzureTableDataset | inputs.datafactory.latest.BinaryDataset | inputs.datafactory.latest.CassandraTableDataset | inputs.datafactory.latest.CommonDataServiceForAppsEntityDataset | inputs.datafactory.latest.ConcurObjectDataset | inputs.datafactory.latest.CosmosDbMongoDbApiCollectionDataset | inputs.datafactory.latest.CosmosDbSqlApiCollectionDataset | inputs.datafactory.latest.CouchbaseTableDataset | inputs.datafactory.latest.CustomDataset | inputs.datafactory.latest.Db2TableDataset | inputs.datafactory.latest.DelimitedTextDataset | inputs.datafactory.latest.DocumentDbCollectionDataset | inputs.datafactory.latest.DrillTableDataset | inputs.datafactory.latest.DynamicsAXResourceDataset | inputs.datafactory.latest.DynamicsCrmEntityDataset | inputs.datafactory.latest.DynamicsEntityDataset | inputs.datafactory.latest.EloquaObjectDataset | inputs.datafactory.latest.ExcelDataset | inputs.datafactory.latest.FileShareDataset | inputs.datafactory.latest.GoogleAdWordsObjectDataset | inputs.datafactory.latest.GoogleBigQueryObjectDataset | inputs.datafactory.latest.GreenplumTableDataset | inputs.datafactory.latest.HBaseObjectDataset | inputs.datafactory.latest.HiveObjectDataset | inputs.datafactory.latest.HttpDataset | inputs.datafactory.latest.HubspotObjectDataset | inputs.datafactory.latest.ImpalaObjectDataset | inputs.datafactory.latest.InformixTableDataset | inputs.datafactory.latest.JiraObjectDataset | inputs.datafactory.latest.JsonDataset | inputs.datafactory.latest.MagentoObjectDataset | inputs.datafactory.latest.MariaDBTableDataset | inputs.datafactory.latest.MarketoObjectDataset | inputs.datafactory.latest.MicrosoftAccessTableDataset | inputs.datafactory.latest.MongoDbAtlasCollectionDataset | inputs.datafactory.latest.MongoDbCollectionDataset | inputs.datafactory.latest.MongoDbV2CollectionDataset | inputs.datafactory.latest.MySqlTableDataset | inputs.datafactory.latest.NetezzaTableDataset | inputs.datafactory.latest.ODataResourceDataset | inputs.datafactory.latest.OdbcTableDataset | inputs.datafactory.latest.Office365Dataset | inputs.datafactory.latest.OracleServiceCloudObjectDataset | inputs.datafactory.latest.OracleTableDataset | inputs.datafactory.latest.OrcDataset | inputs.datafactory.latest.ParquetDataset | inputs.datafactory.latest.PaypalObjectDataset | inputs.datafactory.latest.PhoenixObjectDataset | inputs.datafactory.latest.PostgreSqlTableDataset | inputs.datafactory.latest.PrestoObjectDataset | inputs.datafactory.latest.QuickBooksObjectDataset | inputs.datafactory.latest.RelationalTableDataset | inputs.datafactory.latest.ResponsysObjectDataset | inputs.datafactory.latest.RestResourceDataset | inputs.datafactory.latest.SalesforceMarketingCloudObjectDataset | inputs.datafactory.latest.SalesforceObjectDataset | inputs.datafactory.latest.SalesforceServiceCloudObjectDataset | inputs.datafactory.latest.SapBwCubeDataset | inputs.datafactory.latest.SapCloudForCustomerResourceDataset | inputs.datafactory.latest.SapEccResourceDataset | inputs.datafactory.latest.SapHanaTableDataset | inputs.datafactory.latest.SapOpenHubTableDataset | inputs.datafactory.latest.SapTableResourceDataset | inputs.datafactory.latest.ServiceNowObjectDataset | inputs.datafactory.latest.SharePointOnlineListResourceDataset | inputs.datafactory.latest.ShopifyObjectDataset | inputs.datafactory.latest.SnowflakeDataset | inputs.datafactory.latest.SparkObjectDataset | inputs.datafactory.latest.SqlServerTableDataset | inputs.datafactory.latest.SquareObjectDataset | inputs.datafactory.latest.SybaseTableDataset | inputs.datafactory.latest.TeradataTableDataset | inputs.datafactory.latest.VerticaTableDataset | inputs.datafactory.latest.WebTableDataset | inputs.datafactory.latest.XeroObjectDataset | inputs.datafactory.latest.XmlDataset | inputs.datafactory.latest.ZohoObjectDataset>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
