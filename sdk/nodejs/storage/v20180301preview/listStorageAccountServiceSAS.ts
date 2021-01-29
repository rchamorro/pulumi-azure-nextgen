// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listStorageAccountServiceSAS(args: ListStorageAccountServiceSASArgs, opts?: pulumi.InvokeOptions): Promise<ListStorageAccountServiceSASResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storage/v20180301preview:listStorageAccountServiceSAS", {
        "accountName": args.accountName,
        "cacheControl": args.cacheControl,
        "canonicalizedResource": args.canonicalizedResource,
        "contentDisposition": args.contentDisposition,
        "contentEncoding": args.contentEncoding,
        "contentLanguage": args.contentLanguage,
        "contentType": args.contentType,
        "iPAddressOrRange": args.iPAddressOrRange,
        "identifier": args.identifier,
        "keyToSign": args.keyToSign,
        "partitionKeyEnd": args.partitionKeyEnd,
        "partitionKeyStart": args.partitionKeyStart,
        "permissions": args.permissions,
        "protocols": args.protocols,
        "resource": args.resource,
        "resourceGroupName": args.resourceGroupName,
        "rowKeyEnd": args.rowKeyEnd,
        "rowKeyStart": args.rowKeyStart,
        "sharedAccessExpiryTime": args.sharedAccessExpiryTime,
        "sharedAccessStartTime": args.sharedAccessStartTime,
    }, opts);
}

export interface ListStorageAccountServiceSASArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: string;
    /**
     * The response header override for cache control.
     */
    readonly cacheControl?: string;
    /**
     * The canonical path to the signed resource.
     */
    readonly canonicalizedResource: string;
    /**
     * The response header override for content disposition.
     */
    readonly contentDisposition?: string;
    /**
     * The response header override for content encoding.
     */
    readonly contentEncoding?: string;
    /**
     * The response header override for content language.
     */
    readonly contentLanguage?: string;
    /**
     * The response header override for content type.
     */
    readonly contentType?: string;
    /**
     * An IP address or a range of IP addresses from which to accept requests.
     */
    readonly iPAddressOrRange?: string;
    /**
     * A unique value up to 64 characters in length that correlates to an access policy specified for the container, queue, or table.
     */
    readonly identifier?: string;
    /**
     * The key to sign the account SAS token with.
     */
    readonly keyToSign?: string;
    /**
     * The end of partition key.
     */
    readonly partitionKeyEnd?: string;
    /**
     * The start of partition key.
     */
    readonly partitionKeyStart?: string;
    /**
     * The signed permissions for the service SAS. Possible values include: Read (r), Write (w), Delete (d), List (l), Add (a), Create (c), Update (u) and Process (p).
     */
    readonly permissions?: string | enums.storage.v20180301preview.Permissions;
    /**
     * The protocol permitted for a request made with the account SAS.
     */
    readonly protocols?: enums.storage.v20180301preview.HttpProtocol;
    /**
     * The signed services accessible with the service SAS. Possible values include: Blob (b), Container (c), File (f), Share (s).
     */
    readonly resource?: string | enums.storage.v20180301preview.SignedResource;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The end of row key.
     */
    readonly rowKeyEnd?: string;
    /**
     * The start of row key.
     */
    readonly rowKeyStart?: string;
    /**
     * The time at which the shared access signature becomes invalid.
     */
    readonly sharedAccessExpiryTime?: string;
    /**
     * The time at which the SAS becomes valid.
     */
    readonly sharedAccessStartTime?: string;
}

/**
 * The List service SAS credentials operation response.
 */
export interface ListStorageAccountServiceSASResult {
    /**
     * List service SAS credentials of specific resource.
     */
    readonly serviceSasToken: string;
}
