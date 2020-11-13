// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listWorkspaceCollectionAccessKeys(args: ListWorkspaceCollectionAccessKeysArgs, opts?: pulumi.InvokeOptions): Promise<ListWorkspaceCollectionAccessKeysResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:powerbi/latest:listWorkspaceCollectionAccessKeys", {
        "resourceGroupName": args.resourceGroupName,
        "workspaceCollectionName": args.workspaceCollectionName,
    }, opts);
}

export interface ListWorkspaceCollectionAccessKeysArgs {
    /**
     * Azure resource group
     */
    readonly resourceGroupName: string;
    /**
     * Power BI Embedded Workspace Collection name
     */
    readonly workspaceCollectionName: string;
}

export interface ListWorkspaceCollectionAccessKeysResult {
    /**
     * Access key 1
     */
    readonly key1?: string;
    /**
     * Access key 2
     */
    readonly key2?: string;
}
