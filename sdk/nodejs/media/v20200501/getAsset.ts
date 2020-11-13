// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAsset(args: GetAssetArgs, opts?: pulumi.InvokeOptions): Promise<GetAssetResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:media/v20200501:getAsset", {
        "accountName": args.accountName,
        "assetName": args.assetName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetAssetArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The Asset name.
     */
    readonly assetName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * An Asset.
 */
export interface GetAssetResult {
    /**
     * The alternate ID of the Asset.
     */
    readonly alternateId?: string;
    /**
     * The Asset ID.
     */
    readonly assetId: string;
    /**
     * The name of the asset blob container.
     */
    readonly container?: string;
    /**
     * The creation date of the Asset.
     */
    readonly created: string;
    /**
     * The Asset description.
     */
    readonly description?: string;
    /**
     * The last modified date of the Asset.
     */
    readonly lastModified: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The name of the storage account.
     */
    readonly storageAccountName?: string;
    /**
     * The Asset encryption format. One of None or MediaStorageEncryption.
     */
    readonly storageEncryptionFormat: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
