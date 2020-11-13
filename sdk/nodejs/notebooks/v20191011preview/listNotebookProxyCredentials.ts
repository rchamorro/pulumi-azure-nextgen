// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listNotebookProxyCredentials(args: ListNotebookProxyCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<ListNotebookProxyCredentialsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:notebooks/v20191011preview:listNotebookProxyCredentials", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
    }, opts);
}

export interface ListNotebookProxyCredentialsArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the resource.
     */
    readonly resourceName: string;
}

/**
 * Credentials and other properties of NotebookProxy resource
 */
export interface ListNotebookProxyCredentialsResult {
    /**
     * Hostname for the Notebook Proxy resource
     */
    readonly hostname?: string;
    /**
     * The primary key of the NotebookProxy resource.
     */
    readonly primaryAccessKey?: string;
    /**
     * Notebook Proxy resource id
     */
    readonly resourceId?: string;
    /**
     * The secondary key of the NotebookProxy resource.
     */
    readonly secondaryAccessKey?: string;
}
