// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getManagementLockAtResourceLevel(args: GetManagementLockAtResourceLevelArgs, opts?: pulumi.InvokeOptions): Promise<GetManagementLockAtResourceLevelResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:authorization/latest:getManagementLockAtResourceLevel", {
        "lockName": args.lockName,
        "parentResourcePath": args.parentResourcePath,
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
        "resourceProviderNamespace": args.resourceProviderNamespace,
        "resourceType": args.resourceType,
    }, opts);
}

export interface GetManagementLockAtResourceLevelArgs {
    /**
     * The name of lock.
     */
    readonly lockName: string;
    /**
     * An extra path parameter needed in some services, like SQL Databases.
     */
    readonly parentResourcePath: string;
    /**
     * The name of the resource group. 
     */
    readonly resourceGroupName: string;
    /**
     * The name of the resource.
     */
    readonly resourceName: string;
    /**
     * The namespace of the resource provider.
     */
    readonly resourceProviderNamespace: string;
    /**
     * The type of the resource.
     */
    readonly resourceType: string;
}

/**
 * The lock information.
 */
export interface GetManagementLockAtResourceLevelResult {
    /**
     * The level of the lock. Possible values are: NotSpecified, CanNotDelete, ReadOnly. CanNotDelete means authorized users are able to read and modify the resources, but not delete. ReadOnly means authorized users can only read from a resource, but they can't modify or delete it.
     */
    readonly level: string;
    /**
     * The name of the lock.
     */
    readonly name: string;
    /**
     * Notes about the lock. Maximum of 512 characters.
     */
    readonly notes?: string;
    /**
     * The owners of the lock.
     */
    readonly owners?: outputs.authorization.latest.ManagementLockOwnerResponse[];
    /**
     * The resource type of the lock - Microsoft.Authorization/locks.
     */
    readonly type: string;
}
