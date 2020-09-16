import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getSnapshot(args: GetSnapshotArgs, opts?: pulumi.InvokeOptions): Promise<GetSnapshotResult>;
export interface GetSnapshotArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the snapshot that is being created. The name can't be changed after the snapshot is created. Supported characters for the name are a-z, A-Z, 0-9 and _. The max name length is 80 characters.
     */
    readonly snapshotName: string;
}
/**
 * Snapshot resource.
 */
export interface GetSnapshotResult {
    /**
     * Disk source information. CreationData information cannot be changed after the disk has been created.
     */
    readonly creationData: outputs.compute.v20170330.CreationDataResponse;
    /**
     * If creationData.createOption is Empty, this field is mandatory and it indicates the size of the VHD to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
     */
    readonly diskSizeGB?: number;
    /**
     * Encryption settings for disk or snapshot
     */
    readonly encryptionSettings?: outputs.compute.v20170330.EncryptionSettingsResponse;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Unused. Always Null.
     */
    readonly managedBy: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The Operating System type.
     */
    readonly osType?: string;
    /**
     * The disk provisioning state.
     */
    readonly provisioningState: string;
    /**
     * The disks and snapshots sku name. Can be Standard_LRS or Premium_LRS.
     */
    readonly sku?: outputs.compute.v20170330.DiskSkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The time when the disk was created.
     */
    readonly timeCreated: string;
    /**
     * Resource type
     */
    readonly type: string;
}