// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getCloudEndpoint(args: GetCloudEndpointArgs, opts?: pulumi.InvokeOptions): Promise<GetCloudEndpointResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storagesync/v20190301:getCloudEndpoint", {
        "cloudEndpointName": args.cloudEndpointName,
        "resourceGroupName": args.resourceGroupName,
        "storageSyncServiceName": args.storageSyncServiceName,
        "syncGroupName": args.syncGroupName,
    }, opts);
}

export interface GetCloudEndpointArgs {
    /**
     * Name of Cloud Endpoint object.
     */
    readonly cloudEndpointName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * Name of Storage Sync Service resource.
     */
    readonly storageSyncServiceName: string;
    /**
     * Name of Sync Group resource.
     */
    readonly syncGroupName: string;
}

/**
 * Cloud Endpoint object.
 */
export interface GetCloudEndpointResult {
    /**
     * Azure file share name
     */
    readonly azureFileShareName?: string;
    /**
     * Backup Enabled
     */
    readonly backupEnabled: string;
    /**
     * Friendly Name
     */
    readonly friendlyName?: string;
    /**
     * Resource Last Operation Name
     */
    readonly lastOperationName?: string;
    /**
     * CloudEndpoint lastWorkflowId
     */
    readonly lastWorkflowId?: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Partnership Id
     */
    readonly partnershipId?: string;
    /**
     * CloudEndpoint Provisioning State
     */
    readonly provisioningState?: string;
    /**
     * Storage Account Resource Id
     */
    readonly storageAccountResourceId?: string;
    /**
     * Storage Account Tenant Id
     */
    readonly storageAccountTenantId?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
