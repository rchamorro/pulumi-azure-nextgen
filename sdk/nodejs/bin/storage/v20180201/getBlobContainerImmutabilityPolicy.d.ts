import * as pulumi from "@pulumi/pulumi";
export declare function getBlobContainerImmutabilityPolicy(args: GetBlobContainerImmutabilityPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetBlobContainerImmutabilityPolicyResult>;
export interface GetBlobContainerImmutabilityPolicyArgs {
    /**
     * The name of the storage account within the specified resource group. Storage account names must be between 3 and 24 characters in length and use numbers and lower-case letters only.
     */
    readonly accountName: string;
    /**
     * The name of the blob container within the specified storage account. Blob container names must be between 3 and 63 characters in length and use numbers, lower-case letters and dash (-) only. Every dash (-) character must be immediately preceded and followed by a letter or number.
     */
    readonly containerName: string;
    /**
     * The name of the blob container immutabilityPolicy within the specified storage account. ImmutabilityPolicy Name must be 'default'
     */
    readonly immutabilityPolicyName: string;
    /**
     * The name of the resource group within the user's subscription. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}
/**
 * The ImmutabilityPolicy property of a blob container, including Id, resource name, resource type, Etag.
 */
export interface GetBlobContainerImmutabilityPolicyResult {
    /**
     * Resource Etag.
     */
    readonly etag: string;
    /**
     * The immutability period for the blobs in the container since the policy creation, in days.
     */
    readonly immutabilityPeriodSinceCreationInDays: number;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The ImmutabilityPolicy state of a blob container, possible values include: Locked and Unlocked.
     */
    readonly state: string;
    /**
     * The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
     */
    readonly type: string;
}