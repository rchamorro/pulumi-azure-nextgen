// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listBatchAccountKeys(args: ListBatchAccountKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListBatchAccountKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:batch/v20151201:listBatchAccountKeys", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListBatchAccountKeysArgs {
    /**
     * The name of the account.
     */
    readonly accountName: string;
    /**
     * The name of the resource group that contains the Batch account.
     */
    readonly resourceGroupName: string;
}

/**
 * A set of Azure Batch account keys.
 */
export interface ListBatchAccountKeysResult {
    /**
     * The primary key associated with the account.
     */
    readonly primary?: string;
    /**
     * The secondary key associated with the account.
     */
    readonly secondary?: string;
}
