// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getTask(args: GetTaskArgs, opts?: pulumi.InvokeOptions): Promise<GetTaskResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datamigration/v20180419:getTask", {
        "expand": args.expand,
        "groupName": args.groupName,
        "projectName": args.projectName,
        "serviceName": args.serviceName,
        "taskName": args.taskName,
    }, opts);
}

export interface GetTaskArgs {
    /**
     * Expand the response
     */
    readonly expand?: string;
    /**
     * Name of the resource group
     */
    readonly groupName: string;
    /**
     * Name of the project
     */
    readonly projectName: string;
    /**
     * Name of the service
     */
    readonly serviceName: string;
    /**
     * Name of the Task
     */
    readonly taskName: string;
}

/**
 * A task resource
 */
export interface GetTaskResult {
    /**
     * HTTP strong entity tag value. This is ignored if submitted.
     */
    readonly etag?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Custom task properties
     */
    readonly properties: outputs.datamigration.v20180419.ConnectToSourcePostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToSourceSqlServerSyncTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToSourceSqlServerTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetAzureDbForMySqlTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetSqlDbTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetSqlMITaskPropertiesResponse | outputs.datamigration.v20180419.ConnectToTargetSqlSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180419.GetTdeCertificatesSqlTaskPropertiesResponse | outputs.datamigration.v20180419.GetUserTablesSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180419.GetUserTablesSqlTaskPropertiesResponse | outputs.datamigration.v20180419.MigrateMySqlAzureDbForMySqlSyncTaskPropertiesResponse | outputs.datamigration.v20180419.MigratePostgreSqlAzureDbForPostgreSqlSyncTaskPropertiesResponse | outputs.datamigration.v20180419.MigrateSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180419.MigrateSqlServerSqlDbTaskPropertiesResponse | outputs.datamigration.v20180419.MigrateSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180419.MigrateSqlServerSqlMITaskPropertiesResponse | outputs.datamigration.v20180419.ValidateMigrationInputSqlServerSqlDbSyncTaskPropertiesResponse | outputs.datamigration.v20180419.ValidateMigrationInputSqlServerSqlMISyncTaskPropertiesResponse | outputs.datamigration.v20180419.ValidateMigrationInputSqlServerSqlMITaskPropertiesResponse;
    /**
     * Resource type.
     */
    readonly type: string;
}