import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
export declare function listSiteBackupStatusSecretsSlot(args: ListSiteBackupStatusSecretsSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListSiteBackupStatusSecretsSlotResult>;
export interface ListSiteBackupStatusSecretsSlotArgs {
    /**
     * Id of backup
     */
    readonly backupId: string;
    /**
     * Schedule for the backup if it is executed periodically
     */
    readonly backupSchedule?: inputs.web.v20150801.BackupSchedule;
    /**
     * Databases included in the backup
     */
    readonly databases?: inputs.web.v20150801.DatabaseBackupSetting[];
    /**
     * True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled
     */
    readonly enabled?: boolean;
    /**
     * Resource Id
     */
    readonly id?: string;
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Resource Name
     */
    readonly name: string;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: string;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    readonly slot: string;
    /**
     * SAS URL to the container
     */
    readonly storageAccountUrl?: string;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
}
/**
 * Backup description
 */
export interface ListSiteBackupStatusSecretsSlotResult {
    /**
     * Name of the blob which contains data for this backup
     */
    readonly blobName?: string;
    /**
     * Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support.
     */
    readonly correlationId?: string;
    /**
     * Timestamp of the backup creation
     */
    readonly created?: string;
    /**
     * List of databases included in the backup
     */
    readonly databases?: outputs.web.v20150801.DatabaseBackupSettingResponse[];
    /**
     * Timestamp when this backup finished.
     */
    readonly finishedTimeStamp?: string;
    /**
     * Kind of resource
     */
    readonly kind?: string;
    /**
     * Timestamp of a last restore operation which used this backup.
     */
    readonly lastRestoreTimeStamp?: string;
    /**
     * Resource Location
     */
    readonly location: string;
    /**
     * Details regarding this backup. Might contain an error message.
     */
    readonly log?: string;
    /**
     * Resource Name
     */
    readonly name?: string;
    /**
     * True if this backup has been created due to a schedule being triggered.
     */
    readonly scheduled?: boolean;
    /**
     * Size of the backup in bytes
     */
    readonly sizeInBytes?: number;
    /**
     * Backup status
     */
    readonly status: string;
    /**
     * SAS URL for the storage account container which contains this backup
     */
    readonly storageAccountUrl?: string;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type?: string;
    /**
     * Size of the original web app which has been backed up
     */
    readonly websiteSizeInBytes?: number;
}