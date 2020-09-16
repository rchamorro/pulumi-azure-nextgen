import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getStorageAccount(args: GetStorageAccountArgs, opts?: pulumi.InvokeOptions): Promise<GetStorageAccountResult>;
export interface GetStorageAccountArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}
/**
 * The storage account.
 */
export interface GetStorageAccountResult {
    /**
     * Required for storage accounts where kind = BlobStorage. The access tier used for billing.
     */
    readonly accessTier: string;
    /**
     * Gets the creation date and time of the storage account in UTC.
     */
    readonly creationTime: string;
    /**
     * Gets the custom domain the user assigned to this storage account.
     */
    readonly customDomain: outputs.storage.v20160501.CustomDomainResponse;
    /**
     * Gets the encryption settings on the account. If unspecified, the account is unencrypted.
     */
    readonly encryption: outputs.storage.v20160501.EncryptionResponse;
    /**
     * Gets the Kind.
     */
    readonly kind: string;
    /**
     * Gets the timestamp of the most recent instance of a failover to the secondary location. Only the most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only available if the accountType is Standard_GRS or Standard_RAGRS.
     */
    readonly lastGeoFailoverTime: string;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
     */
    readonly primaryEndpoints: outputs.storage.v20160501.EndpointsResponse;
    /**
     * Gets the location of the primary data center for the storage account.
     */
    readonly primaryLocation: string;
    /**
     * Gets the status of the storage account at the time the operation was called.
     */
    readonly provisioningState: string;
    /**
     * Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
     */
    readonly secondaryEndpoints: outputs.storage.v20160501.EndpointsResponse;
    /**
     * Gets the location of the geo-replicated secondary for the storage account. Only available if the accountType is Standard_GRS or Standard_RAGRS.
     */
    readonly secondaryLocation: string;
    /**
     * Gets the SKU.
     */
    readonly sku: outputs.storage.v20160501.SkuResponse;
    /**
     * Gets the status indicating whether the primary location of the storage account is available or unavailable.
     */
    readonly statusOfPrimary: string;
    /**
     * Gets the status indicating whether the secondary location of the storage account is available or unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
     */
    readonly statusOfSecondary: string;
    /**
     * Tags assigned to a resource; can be used for viewing and grouping a resource (across resource groups).
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
}