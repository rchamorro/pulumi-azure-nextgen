// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getImage(args: GetImageArgs, opts?: pulumi.InvokeOptions): Promise<GetImageResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:compute/v20170330:getImage", {
        "expand": args.expand,
        "imageName": args.imageName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetImageArgs {
    /**
     * The expand expression to apply on the operation.
     */
    readonly expand?: string;
    /**
     * The name of the image.
     */
    readonly imageName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual machine. If SourceImage is provided, the destination virtual hard drive must not exist.
 */
export interface GetImageResult {
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The source virtual machine from which Image is created.
     */
    readonly sourceVirtualMachine?: outputs.compute.v20170330.SubResourceResponse;
    /**
     * Specifies the storage settings for the virtual machine disks.
     */
    readonly storageProfile?: outputs.compute.v20170330.ImageStorageProfileResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}
