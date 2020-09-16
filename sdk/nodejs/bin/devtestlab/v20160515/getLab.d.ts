import * as pulumi from "@pulumi/pulumi";
export declare function getLab(args: GetLabArgs, opts?: pulumi.InvokeOptions): Promise<GetLabResult>;
export interface GetLabArgs {
    /**
     * Specify the $expand query. Example: 'properties($select=defaultStorageAccount)'
     */
    readonly expand?: string;
    /**
     * The name of the lab.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * A lab.
 */
export interface GetLabResult {
    /**
     * The lab's artifact storage account.
     */
    readonly artifactsStorageAccount: string;
    /**
     * The creation date of the lab.
     */
    readonly createdDate: string;
    /**
     * The lab's default premium storage account.
     */
    readonly defaultPremiumStorageAccount: string;
    /**
     * The lab's default storage account.
     */
    readonly defaultStorageAccount: string;
    /**
     * Type of storage used by the lab. It can be either Premium or Standard. Default is Premium.
     */
    readonly labStorageType?: string;
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The lab's premium data disk storage account.
     */
    readonly premiumDataDiskStorageAccount: string;
    /**
     * The setting to enable usage of premium data disks.
     * When its value is 'Enabled', creation of standard or premium data disks is allowed.
     * When its value is 'Disabled', only creation of standard data disks is allowed.
     */
    readonly premiumDataDisks?: string;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState?: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    readonly uniqueIdentifier?: string;
    /**
     * The lab's Key vault.
     */
    readonly vaultName: string;
}