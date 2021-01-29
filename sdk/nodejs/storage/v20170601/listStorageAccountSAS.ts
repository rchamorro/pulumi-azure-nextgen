// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listStorageAccountSAS(args: ListStorageAccountSASArgs, opts?: pulumi.InvokeOptions): Promise<ListStorageAccountSASResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storage/v20170601:listStorageAccountSAS", {
        "accountName": args.accountName,
        "iPAddressOrRange": args.iPAddressOrRange,
        "keyToSign": args.keyToSign,
        "permissions": args.permissions,
        "protocols": args.protocols,
        "resourceGroupName": args.resourceGroupName,
        "resourceTypes": args.resourceTypes,
        "services": args.services,
        "sharedAccessExpiryTime": args.sharedAccessExpiryTime,
        "sharedAccessStartTime": args.sharedAccessStartTime,
    }, opts);
}

export interface ListStorageAccountSASArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.  
     */
    readonly accountName: string;
    /**
     * An IP address or a range of IP addresses from which to accept requests.
     */
    readonly iPAddressOrRange?: string;
    /**
     * The key to sign the account SAS token with.
     */
    readonly keyToSign?: string;
    /**
     * The signed permissions for the account SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
     */
    readonly permissions: string | enums.storage.v20170601.Permissions;
    /**
     * The protocol permitted for a request made with the account SAS.
     */
    readonly protocols?: enums.storage.v20170601.HttpProtocol;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The signed resource types that are accessible with the account SAS. Service (s): Access to service-level APIs; Container (c): Access to container-level APIs; Object (o): Access to object-level APIs for blobs, queue messages, table entities, and files.
     */
    readonly resourceTypes: string | enums.storage.v20170601.SignedResourceTypes;
    /**
     * The signed services accessible with the account SAS. Possible values include: Blob (b), Queue (q), Table (t), File (f).
     */
    readonly services: string | enums.storage.v20170601.Services;
    /**
     * The time at which the shared access signature becomes invalid.
     */
    readonly sharedAccessExpiryTime: string;
    /**
     * The time at which the SAS becomes valid.
     */
    readonly sharedAccessStartTime?: string;
}

/**
 * The List SAS credentials operation response.
 */
export interface ListStorageAccountSASResult {
    /**
     * List SAS credentials of storage account.
     */
    readonly accountSasToken: string;
}
