// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listAssetContainerSas(args: ListAssetContainerSasArgs, opts?: pulumi.InvokeOptions): Promise<ListAssetContainerSasResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20180601preview:listAssetContainerSas", {
        "accountName": args.accountName,
        "assetName": args.assetName,
        "expiryTime": args.expiryTime,
        "permissions": args.permissions,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListAssetContainerSasArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The Asset name.
     */
    readonly assetName: string;
    /**
     * The SAS URL expiration time.  This must be less than 24 hours from the current time.
     */
    readonly expiryTime?: string;
    /**
     * The permissions to set on the SAS URL.
     */
    readonly permissions?: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The Asset Storage container SAS URLs.
 */
export interface ListAssetContainerSasResult {
    /**
     * The list of Asset container SAS URLs.
     */
    readonly assetContainerSasUrls?: string[];
}
