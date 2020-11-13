// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getFileShare(args: GetFileShareArgs, opts?: pulumi.InvokeOptions): Promise<GetFileShareResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:storsimple/latest:getFileShare", {
        "deviceName": args.deviceName,
        "fileServerName": args.fileServerName,
        "managerName": args.managerName,
        "resourceGroupName": args.resourceGroupName,
        "shareName": args.shareName,
    }, opts);
}

export interface GetFileShareArgs {
    /**
     * The device name.
     */
    readonly deviceName: string;
    /**
     * The file server name.
     */
    readonly fileServerName: string;
    /**
     * The manager name
     */
    readonly managerName: string;
    /**
     * The resource group name
     */
    readonly resourceGroupName: string;
    /**
     * The file share name.
     */
    readonly shareName: string;
}

/**
 * The File Share.
 */
export interface GetFileShareResult {
    /**
     * The user/group who will have full permission in this share. Active directory email address. Example: xyz@contoso.com or Contoso\xyz.
     */
    readonly adminUser: string;
    /**
     * The data policy
     */
    readonly dataPolicy: string;
    /**
     * Description for file share
     */
    readonly description?: string;
    /**
     * The local used capacity in Bytes.
     */
    readonly localUsedCapacityInBytes: number;
    /**
     * The monitoring status
     */
    readonly monitoringStatus: string;
    /**
     * The name.
     */
    readonly name: string;
    /**
     * The total provisioned capacity in Bytes
     */
    readonly provisionedCapacityInBytes: number;
    /**
     * The Share Status
     */
    readonly shareStatus: string;
    /**
     * The type.
     */
    readonly type: string;
    /**
     * The used capacity in Bytes.
     */
    readonly usedCapacityInBytes: number;
}
