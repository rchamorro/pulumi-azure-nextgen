// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getDataSource(args: GetDataSourceArgs, opts?: pulumi.InvokeOptions): Promise<GetDataSourceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:operationalinsights/v20200801:getDataSource", {
        "dataSourceName": args.dataSourceName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetDataSourceArgs {
    /**
     * Name of the datasource
     */
    readonly dataSourceName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: string;
}

/**
 * Datasources under OMS Workspace.
 */
export interface GetDataSourceResult {
    /**
     * The ETag of the data source.
     */
    readonly etag?: string;
    /**
     * The kind of the DataSource.
     */
    readonly kind: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The data source properties in raw json format, each kind of data source have it's own schema.
     */
    readonly properties: any;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
}
