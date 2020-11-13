// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getBlobServiceProperties(args: GetBlobServicePropertiesArgs, opts?: pulumi.InvokeOptions): Promise<GetBlobServicePropertiesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storage/v20190601:getBlobServiceProperties", {
        "accountName": args.accountName,
        "blobServicesName": args.blobServicesName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetBlobServicePropertiesArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: string;
    /**
     * The name of the blob Service within the specified storage account. Blob Service Name must be 'default'
     */
    readonly blobServicesName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * The properties of a storage account’s Blob service.
 */
export interface GetBlobServicePropertiesResult {
    /**
     * Deprecated in favor of isVersioningEnabled property.
     */
    readonly automaticSnapshotPolicyEnabled?: boolean;
    /**
     * The blob service properties for change feed events.
     */
    readonly changeFeed?: outputs.storage.v20190601.ChangeFeedResponse;
    /**
     * The blob service properties for container soft delete.
     */
    readonly containerDeleteRetentionPolicy?: outputs.storage.v20190601.DeleteRetentionPolicyResponse;
    /**
     * Specifies CORS rules for the Blob service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the Blob service.
     */
    readonly cors?: outputs.storage.v20190601.CorsRulesResponse;
    /**
     * DefaultServiceVersion indicates the default version to use for requests to the Blob service if an incoming request’s version is not specified. Possible values include version 2008-10-27 and all more recent versions.
     */
    readonly defaultServiceVersion?: string;
    /**
     * The blob service properties for blob soft delete.
     */
    readonly deleteRetentionPolicy?: outputs.storage.v20190601.DeleteRetentionPolicyResponse;
    /**
     * Versioning is enabled if set to true.
     */
    readonly isVersioningEnabled?: boolean;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The blob service properties for blob restore policy.
     */
    readonly restorePolicy?: outputs.storage.v20190601.RestorePolicyPropertiesResponse;
    /**
     * Sku name and tier.
     */
    readonly sku: outputs.storage.v20190601.SkuResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
