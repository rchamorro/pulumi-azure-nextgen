// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listRedisEnterpriseDatabaseKeys(args: ListRedisEnterpriseDatabaseKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListRedisEnterpriseDatabaseKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:cache/v20201001preview:listRedisEnterpriseDatabaseKeys", {
        "clusterName": args.clusterName,
        "databaseName": args.databaseName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListRedisEnterpriseDatabaseKeysArgs {
    /**
     * The name of the RedisEnterprise cluster.
     */
    readonly clusterName: string;
    /**
     * The name of the database.
     */
    readonly databaseName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * The secret access keys used for authenticating connections to redis
 */
export interface ListRedisEnterpriseDatabaseKeysResult {
    /**
     * The current primary key that clients can use to authenticate
     */
    readonly primaryKey: string;
    /**
     * The current secondary key that clients can use to authenticate
     */
    readonly secondaryKey: string;
}
