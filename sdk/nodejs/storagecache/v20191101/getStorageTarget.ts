// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getStorageTarget(args: GetStorageTargetArgs, opts?: pulumi.InvokeOptions): Promise<GetStorageTargetResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storagecache/v20191101:getStorageTarget", {
        "cacheName": args.cacheName,
        "resourceGroupName": args.resourceGroupName,
        "storageTargetName": args.storageTargetName,
    }, opts);
}

export interface GetStorageTargetArgs {
    /**
     * Name of Cache.
     */
    readonly cacheName: string;
    /**
     * Target resource group.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the Storage Target.
     */
    readonly storageTargetName: string;
}

/**
 * A storage system being cached by a Cache.
 */
export interface GetStorageTargetResult {
    /**
     * Properties when targetType is clfs.
     */
    readonly clfs?: outputs.storagecache.v20191101.ClfsTargetResponse;
    /**
     * List of Cache namespace junctions to target for namespace associations.
     */
    readonly junctions?: outputs.storagecache.v20191101.NamespaceJunctionResponse[];
    /**
     * Name of the Storage Target.
     */
    readonly name: string;
    /**
     * Properties when targetType is nfs3.
     */
    readonly nfs3?: outputs.storagecache.v20191101.Nfs3TargetResponse;
    /**
     * ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
     */
    readonly provisioningState?: string;
    /**
     * Type of the Storage Target.
     */
    readonly targetType?: string;
    /**
     * Type of the Storage Target; Microsoft.StorageCache/Cache/StorageTarget
     */
    readonly type: string;
    /**
     * Properties when targetType is unknown.
     */
    readonly unknown?: outputs.storagecache.v20191101.UnknownTargetResponse;
}
