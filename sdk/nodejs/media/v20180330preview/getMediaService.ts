// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getMediaService(args: GetMediaServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetMediaServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20180330preview:getMediaService", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMediaServiceArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * A Media Services account.
 */
export interface GetMediaServiceResult {
    /**
     * The Azure Region of the resource.
     */
    readonly location?: string;
    /**
     * The Media Services account ID.
     */
    readonly mediaServiceId: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The storage accounts for this resource.
     */
    readonly storageAccounts?: outputs.media.v20180330preview.StorageAccountResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}
