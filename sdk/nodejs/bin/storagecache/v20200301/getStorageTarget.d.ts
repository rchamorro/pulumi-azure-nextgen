import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getStorageTarget(args: GetStorageTargetArgs, opts?: pulumi.InvokeOptions): Promise<GetStorageTargetResult>;
export interface GetStorageTargetArgs {
    /**
     * Name of Cache. Length of name must be not greater than 80 and chars must be in list of [-0-9a-zA-Z_] char class.
     */
    readonly cacheName: string;
    /**
     * Target resource group.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the Storage Target. Length of name must be not greater than 80 and chars must be in list of [-0-9a-zA-Z_] char class.
     */
    readonly storageTargetName: string;
}
/**
 * Type of the Storage Target.
 */
export interface GetStorageTargetResult {
    /**
     * Properties when targetType is clfs.
     */
    readonly clfs?: outputs.storagecache.v20200301.ClfsTargetResponse;
    /**
     * List of Cache namespace junctions to target for namespace associations.
     */
    readonly junctions?: outputs.storagecache.v20200301.NamespaceJunctionResponse[];
    /**
     * Name of the Storage Target.
     */
    readonly name: string;
    /**
     * Properties when targetType is nfs3.
     */
    readonly nfs3?: outputs.storagecache.v20200301.Nfs3TargetResponse;
    /**
     * ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
     */
    readonly provisioningState?: string;
    /**
     * Type of the Storage Target.
     */
    readonly targetType: string;
    /**
     * Type of the Storage Target; Microsoft.StorageCache/Cache/StorageTarget
     */
    readonly type: string;
    /**
     * Properties when targetType is unknown.
     */
    readonly unknown?: outputs.storagecache.v20200301.UnknownTargetResponse;
}