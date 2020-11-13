// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getStorageAccount(args: GetStorageAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetStorageAccountResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storage/v20150501preview:getStorageAccount", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetStorageAccountArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.  
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the user's subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * The storage account.
 */
export interface GetStorageAccountResult {
    /**
     * Gets the type of the storage account.
     */
    readonly accountType?: string;
    /**
     * Gets the creation date and time of the storage account in UTC.
     */
    readonly creationTime?: string;
    /**
     * Gets the user assigned custom domain assigned to this storage account.
     */
    readonly customDomain?: outputs.storage.v20150501preview.CustomDomainResponse;
    /**
     * Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is StandardGRS or StandardRAGRS.
     */
    readonly lastGeoFailoverTime?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Gets the URLs that are used to perform a retrieval of a public blob, queue or table object.Note that StandardZRS and PremiumLRS accounts only return the blob endpoint.
     */
    readonly primaryEndpoints?: outputs.storage.v20150501preview.EndpointsResponse;
    /**
     * Gets the location of the primary for the storage account.
     */
    readonly primaryLocation?: string;
    /**
     * Gets the status of the storage account at the time the operation was called.
     */
    readonly provisioningState?: string;
    /**
     * Gets the URLs that are used to perform a retrieval of a public blob, queue or table object from the secondary location of the storage account. Only available if the accountType is StandardRAGRS.
     */
    readonly secondaryEndpoints?: outputs.storage.v20150501preview.EndpointsResponse;
    /**
     * Gets the location of the geo replicated secondary for the storage account. Only available if the accountType is StandardGRS or StandardRAGRS.
     */
    readonly secondaryLocation?: string;
    /**
     * Gets the status indicating whether the primary location of the storage account is available or unavailable.
     */
    readonly statusOfPrimary?: string;
    /**
     * Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the accountType is StandardGRS or StandardRAGRS.
     */
    readonly statusOfSecondary?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}
