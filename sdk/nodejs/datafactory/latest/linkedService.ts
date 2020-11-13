// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

/**
 * Linked service resource type.
 */
export class LinkedService extends pulumi.CustomResource {
    /**
     * Get an existing LinkedService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): LinkedService {
        return new LinkedService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:datafactory/latest:LinkedService';

    /**
     * Returns true if the given object is an instance of LinkedService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LinkedService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LinkedService.__pulumiType;
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
     * Properties of linked service.
     */
    public readonly properties!: pulumi.Output<outputs.datafactory.latest.AmazonMWSLinkedServiceResponse | outputs.datafactory.latest.AmazonRedshiftLinkedServiceResponse | outputs.datafactory.latest.AmazonS3LinkedServiceResponse | outputs.datafactory.latest.AzureBatchLinkedServiceResponse | outputs.datafactory.latest.AzureBlobFSLinkedServiceResponse | outputs.datafactory.latest.AzureBlobStorageLinkedServiceResponse | outputs.datafactory.latest.AzureDataExplorerLinkedServiceResponse | outputs.datafactory.latest.AzureDataLakeAnalyticsLinkedServiceResponse | outputs.datafactory.latest.AzureDataLakeStoreLinkedServiceResponse | outputs.datafactory.latest.AzureDatabricksDeltaLakeLinkedServiceResponse | outputs.datafactory.latest.AzureDatabricksLinkedServiceResponse | outputs.datafactory.latest.AzureFileStorageLinkedServiceResponse | outputs.datafactory.latest.AzureFunctionLinkedServiceResponse | outputs.datafactory.latest.AzureKeyVaultLinkedServiceResponse | outputs.datafactory.latest.AzureMLLinkedServiceResponse | outputs.datafactory.latest.AzureMLServiceLinkedServiceResponse | outputs.datafactory.latest.AzureMariaDBLinkedServiceResponse | outputs.datafactory.latest.AzureMySqlLinkedServiceResponse | outputs.datafactory.latest.AzurePostgreSqlLinkedServiceResponse | outputs.datafactory.latest.AzureSearchLinkedServiceResponse | outputs.datafactory.latest.AzureSqlDWLinkedServiceResponse | outputs.datafactory.latest.AzureSqlDatabaseLinkedServiceResponse | outputs.datafactory.latest.AzureSqlMILinkedServiceResponse | outputs.datafactory.latest.AzureStorageLinkedServiceResponse | outputs.datafactory.latest.AzureTableStorageLinkedServiceResponse | outputs.datafactory.latest.CassandraLinkedServiceResponse | outputs.datafactory.latest.CommonDataServiceForAppsLinkedServiceResponse | outputs.datafactory.latest.ConcurLinkedServiceResponse | outputs.datafactory.latest.CosmosDbLinkedServiceResponse | outputs.datafactory.latest.CosmosDbMongoDbApiLinkedServiceResponse | outputs.datafactory.latest.CouchbaseLinkedServiceResponse | outputs.datafactory.latest.CustomDataSourceLinkedServiceResponse | outputs.datafactory.latest.Db2LinkedServiceResponse | outputs.datafactory.latest.DrillLinkedServiceResponse | outputs.datafactory.latest.DynamicsAXLinkedServiceResponse | outputs.datafactory.latest.DynamicsCrmLinkedServiceResponse | outputs.datafactory.latest.DynamicsLinkedServiceResponse | outputs.datafactory.latest.EloquaLinkedServiceResponse | outputs.datafactory.latest.FileServerLinkedServiceResponse | outputs.datafactory.latest.FtpServerLinkedServiceResponse | outputs.datafactory.latest.GoogleAdWordsLinkedServiceResponse | outputs.datafactory.latest.GoogleBigQueryLinkedServiceResponse | outputs.datafactory.latest.GoogleCloudStorageLinkedServiceResponse | outputs.datafactory.latest.GreenplumLinkedServiceResponse | outputs.datafactory.latest.HBaseLinkedServiceResponse | outputs.datafactory.latest.HDInsightLinkedServiceResponse | outputs.datafactory.latest.HDInsightOnDemandLinkedServiceResponse | outputs.datafactory.latest.HdfsLinkedServiceResponse | outputs.datafactory.latest.HiveLinkedServiceResponse | outputs.datafactory.latest.HttpLinkedServiceResponse | outputs.datafactory.latest.HubspotLinkedServiceResponse | outputs.datafactory.latest.ImpalaLinkedServiceResponse | outputs.datafactory.latest.InformixLinkedServiceResponse | outputs.datafactory.latest.JiraLinkedServiceResponse | outputs.datafactory.latest.MagentoLinkedServiceResponse | outputs.datafactory.latest.MariaDBLinkedServiceResponse | outputs.datafactory.latest.MarketoLinkedServiceResponse | outputs.datafactory.latest.MicrosoftAccessLinkedServiceResponse | outputs.datafactory.latest.MongoDbAtlasLinkedServiceResponse | outputs.datafactory.latest.MongoDbLinkedServiceResponse | outputs.datafactory.latest.MongoDbV2LinkedServiceResponse | outputs.datafactory.latest.MySqlLinkedServiceResponse | outputs.datafactory.latest.NetezzaLinkedServiceResponse | outputs.datafactory.latest.ODataLinkedServiceResponse | outputs.datafactory.latest.OdbcLinkedServiceResponse | outputs.datafactory.latest.Office365LinkedServiceResponse | outputs.datafactory.latest.OracleLinkedServiceResponse | outputs.datafactory.latest.OracleServiceCloudLinkedServiceResponse | outputs.datafactory.latest.PaypalLinkedServiceResponse | outputs.datafactory.latest.PhoenixLinkedServiceResponse | outputs.datafactory.latest.PostgreSqlLinkedServiceResponse | outputs.datafactory.latest.PrestoLinkedServiceResponse | outputs.datafactory.latest.QuickBooksLinkedServiceResponse | outputs.datafactory.latest.ResponsysLinkedServiceResponse | outputs.datafactory.latest.RestServiceLinkedServiceResponse | outputs.datafactory.latest.SalesforceLinkedServiceResponse | outputs.datafactory.latest.SalesforceMarketingCloudLinkedServiceResponse | outputs.datafactory.latest.SalesforceServiceCloudLinkedServiceResponse | outputs.datafactory.latest.SapBWLinkedServiceResponse | outputs.datafactory.latest.SapCloudForCustomerLinkedServiceResponse | outputs.datafactory.latest.SapEccLinkedServiceResponse | outputs.datafactory.latest.SapHanaLinkedServiceResponse | outputs.datafactory.latest.SapOpenHubLinkedServiceResponse | outputs.datafactory.latest.SapTableLinkedServiceResponse | outputs.datafactory.latest.ServiceNowLinkedServiceResponse | outputs.datafactory.latest.SftpServerLinkedServiceResponse | outputs.datafactory.latest.SharePointOnlineListLinkedServiceResponse | outputs.datafactory.latest.ShopifyLinkedServiceResponse | outputs.datafactory.latest.SnowflakeLinkedServiceResponse | outputs.datafactory.latest.SparkLinkedServiceResponse | outputs.datafactory.latest.SqlServerLinkedServiceResponse | outputs.datafactory.latest.SquareLinkedServiceResponse | outputs.datafactory.latest.SybaseLinkedServiceResponse | outputs.datafactory.latest.TeradataLinkedServiceResponse | outputs.datafactory.latest.VerticaLinkedServiceResponse | outputs.datafactory.latest.WebLinkedServiceResponse | outputs.datafactory.latest.XeroLinkedServiceResponse | outputs.datafactory.latest.ZohoLinkedServiceResponse>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a LinkedService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LinkedServiceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.factoryName === undefined) {
                throw new Error("Missing required property 'factoryName'");
            }
            if (!args || args.linkedServiceName === undefined) {
                throw new Error("Missing required property 'linkedServiceName'");
            }
            if (!args || args.properties === undefined) {
                throw new Error("Missing required property 'properties'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["factoryName"] = args ? args.factoryName : undefined;
            inputs["linkedServiceName"] = args ? args.linkedServiceName : undefined;
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
        const aliasOpts = { aliases: [{ type: "azure-nextgen:datafactory/v20170901preview:LinkedService" }, { type: "azure-nextgen:datafactory/v20180601:LinkedService" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(LinkedService.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a LinkedService resource.
 */
export interface LinkedServiceArgs {
    /**
     * The factory name.
     */
    readonly factoryName: pulumi.Input<string>;
    /**
     * The linked service name.
     */
    readonly linkedServiceName: pulumi.Input<string>;
    /**
     * Properties of linked service.
     */
    readonly properties: pulumi.Input<inputs.datafactory.latest.AmazonMWSLinkedService | inputs.datafactory.latest.AmazonRedshiftLinkedService | inputs.datafactory.latest.AmazonS3LinkedService | inputs.datafactory.latest.AzureBatchLinkedService | inputs.datafactory.latest.AzureBlobFSLinkedService | inputs.datafactory.latest.AzureBlobStorageLinkedService | inputs.datafactory.latest.AzureDataExplorerLinkedService | inputs.datafactory.latest.AzureDataLakeAnalyticsLinkedService | inputs.datafactory.latest.AzureDataLakeStoreLinkedService | inputs.datafactory.latest.AzureDatabricksDeltaLakeLinkedService | inputs.datafactory.latest.AzureDatabricksLinkedService | inputs.datafactory.latest.AzureFileStorageLinkedService | inputs.datafactory.latest.AzureFunctionLinkedService | inputs.datafactory.latest.AzureKeyVaultLinkedService | inputs.datafactory.latest.AzureMLLinkedService | inputs.datafactory.latest.AzureMLServiceLinkedService | inputs.datafactory.latest.AzureMariaDBLinkedService | inputs.datafactory.latest.AzureMySqlLinkedService | inputs.datafactory.latest.AzurePostgreSqlLinkedService | inputs.datafactory.latest.AzureSearchLinkedService | inputs.datafactory.latest.AzureSqlDWLinkedService | inputs.datafactory.latest.AzureSqlDatabaseLinkedService | inputs.datafactory.latest.AzureSqlMILinkedService | inputs.datafactory.latest.AzureStorageLinkedService | inputs.datafactory.latest.AzureTableStorageLinkedService | inputs.datafactory.latest.CassandraLinkedService | inputs.datafactory.latest.CommonDataServiceForAppsLinkedService | inputs.datafactory.latest.ConcurLinkedService | inputs.datafactory.latest.CosmosDbLinkedService | inputs.datafactory.latest.CosmosDbMongoDbApiLinkedService | inputs.datafactory.latest.CouchbaseLinkedService | inputs.datafactory.latest.CustomDataSourceLinkedService | inputs.datafactory.latest.Db2LinkedService | inputs.datafactory.latest.DrillLinkedService | inputs.datafactory.latest.DynamicsAXLinkedService | inputs.datafactory.latest.DynamicsCrmLinkedService | inputs.datafactory.latest.DynamicsLinkedService | inputs.datafactory.latest.EloquaLinkedService | inputs.datafactory.latest.FileServerLinkedService | inputs.datafactory.latest.FtpServerLinkedService | inputs.datafactory.latest.GoogleAdWordsLinkedService | inputs.datafactory.latest.GoogleBigQueryLinkedService | inputs.datafactory.latest.GoogleCloudStorageLinkedService | inputs.datafactory.latest.GreenplumLinkedService | inputs.datafactory.latest.HBaseLinkedService | inputs.datafactory.latest.HDInsightLinkedService | inputs.datafactory.latest.HDInsightOnDemandLinkedService | inputs.datafactory.latest.HdfsLinkedService | inputs.datafactory.latest.HiveLinkedService | inputs.datafactory.latest.HttpLinkedService | inputs.datafactory.latest.HubspotLinkedService | inputs.datafactory.latest.ImpalaLinkedService | inputs.datafactory.latest.InformixLinkedService | inputs.datafactory.latest.JiraLinkedService | inputs.datafactory.latest.MagentoLinkedService | inputs.datafactory.latest.MariaDBLinkedService | inputs.datafactory.latest.MarketoLinkedService | inputs.datafactory.latest.MicrosoftAccessLinkedService | inputs.datafactory.latest.MongoDbAtlasLinkedService | inputs.datafactory.latest.MongoDbLinkedService | inputs.datafactory.latest.MongoDbV2LinkedService | inputs.datafactory.latest.MySqlLinkedService | inputs.datafactory.latest.NetezzaLinkedService | inputs.datafactory.latest.ODataLinkedService | inputs.datafactory.latest.OdbcLinkedService | inputs.datafactory.latest.Office365LinkedService | inputs.datafactory.latest.OracleLinkedService | inputs.datafactory.latest.OracleServiceCloudLinkedService | inputs.datafactory.latest.PaypalLinkedService | inputs.datafactory.latest.PhoenixLinkedService | inputs.datafactory.latest.PostgreSqlLinkedService | inputs.datafactory.latest.PrestoLinkedService | inputs.datafactory.latest.QuickBooksLinkedService | inputs.datafactory.latest.ResponsysLinkedService | inputs.datafactory.latest.RestServiceLinkedService | inputs.datafactory.latest.SalesforceLinkedService | inputs.datafactory.latest.SalesforceMarketingCloudLinkedService | inputs.datafactory.latest.SalesforceServiceCloudLinkedService | inputs.datafactory.latest.SapBWLinkedService | inputs.datafactory.latest.SapCloudForCustomerLinkedService | inputs.datafactory.latest.SapEccLinkedService | inputs.datafactory.latest.SapHanaLinkedService | inputs.datafactory.latest.SapOpenHubLinkedService | inputs.datafactory.latest.SapTableLinkedService | inputs.datafactory.latest.ServiceNowLinkedService | inputs.datafactory.latest.SftpServerLinkedService | inputs.datafactory.latest.SharePointOnlineListLinkedService | inputs.datafactory.latest.ShopifyLinkedService | inputs.datafactory.latest.SnowflakeLinkedService | inputs.datafactory.latest.SparkLinkedService | inputs.datafactory.latest.SqlServerLinkedService | inputs.datafactory.latest.SquareLinkedService | inputs.datafactory.latest.SybaseLinkedService | inputs.datafactory.latest.TeradataLinkedService | inputs.datafactory.latest.VerticaLinkedService | inputs.datafactory.latest.WebLinkedService | inputs.datafactory.latest.XeroLinkedService | inputs.datafactory.latest.ZohoLinkedService>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
