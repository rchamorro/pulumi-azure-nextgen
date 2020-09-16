// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getDatabase(args: GetDatabaseArgs, opts?: pulumi.InvokeOptions): Promise<GetDatabaseResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:sql/v20170301preview:getDatabase", {
        "databaseName": args.databaseName,
        "resourceGroupName": args.resourceGroupName,
        "serverName": args.serverName,
    }, opts);
}

export interface GetDatabaseArgs {
    /**
     * The name of the database.
     */
    readonly databaseName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the server.
     */
    readonly serverName: string;
}

/**
 * A database resource.
 */
export interface GetDatabaseResult {
    /**
     * Collation of the metadata catalog.
     */
    readonly catalogCollation?: string;
    /**
     * The collation of the database.
     */
    readonly collation?: string;
    /**
     * Specifies the mode of database creation.
     * 
     * Default: regular database creation.
     * 
     * Copy: creates a database as a copy of an existing database. sourceDatabaseId must be specified as the resource ID of the source database.
     * 
     * Secondary: creates a database as a secondary replica of an existing database. sourceDatabaseId must be specified as the resource ID of the existing primary database.
     * 
     * PointInTimeRestore: Creates a database by restoring a point in time backup of an existing database. sourceDatabaseId must be specified as the resource ID of the existing database, and restorePointInTime must be specified.
     * 
     * Recovery: Creates a database by restoring a geo-replicated backup. sourceDatabaseId must be specified as the recoverable database resource ID to restore.
     * 
     * Restore: Creates a database by restoring a backup of a deleted database. sourceDatabaseId must be specified. If sourceDatabaseId is the database's original resource ID, then sourceDatabaseDeletionDate must be specified. Otherwise sourceDatabaseId must be the restorable dropped database resource ID and sourceDatabaseDeletionDate is ignored. restorePointInTime may also be specified to restore from an earlier point in time.
     * 
     * RestoreLongTermRetentionBackup: Creates a database by restoring from a long term retention vault. recoveryServicesRecoveryPointResourceId must be specified as the recovery point resource ID.
     * 
     * Copy, Secondary, and RestoreLongTermRetentionBackup are not supported for DataWarehouse edition.
     */
    readonly createMode?: string;
    /**
     * The creation date of the database (ISO8601 format).
     */
    readonly creationDate: string;
    /**
     * The current service level objective name of the database.
     */
    readonly currentServiceObjectiveName: string;
    /**
     * The ID of the database.
     */
    readonly databaseId: string;
    /**
     * The default secondary region for this database.
     */
    readonly defaultSecondaryLocation: string;
    /**
     * The resource identifier of the elastic pool containing this database.
     */
    readonly elasticPoolId?: string;
    /**
     * Failover Group resource identifier that this database belongs to.
     */
    readonly failoverGroupId: string;
    /**
     * Kind of database. This is metadata used for the Azure portal experience.
     */
    readonly kind: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * The resource identifier of the long term retention backup associated with create operation of this database.
     */
    readonly longTermRetentionBackupResourceId?: string;
    /**
     * The max size of the database expressed in bytes.
     */
    readonly maxSizeBytes?: number;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The resource identifier of the recoverable database associated with create operation of this database.
     */
    readonly recoverableDatabaseId?: string;
    /**
     * The resource identifier of the recovery point associated with create operation of this database.
     */
    readonly recoveryServicesRecoveryPointId?: string;
    /**
     * The resource identifier of the restorable dropped database associated with create operation of this database.
     */
    readonly restorableDroppedDatabaseId?: string;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
     */
    readonly restorePointInTime?: string;
    /**
     * The name of the sample schema to apply when creating this database.
     */
    readonly sampleName?: string;
    /**
     * The name and tier of the SKU.
     */
    readonly sku?: outputs.sql.v20170301preview.SkuResponse;
    /**
     * Specifies the time that the database was deleted.
     */
    readonly sourceDatabaseDeletionDate?: string;
    /**
     * The resource identifier of the source database associated with create operation of this database.
     */
    readonly sourceDatabaseId?: string;
    /**
     * The status of the database.
     */
    readonly status: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
     */
    readonly zoneRedundant?: boolean;
}