import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function listWebAppBackupConfigurationSlot(args: ListWebAppBackupConfigurationSlotArgs, opts?: pulumi.InvokeOptions): Promise<ListWebAppBackupConfigurationSlotResult>;
export interface ListWebAppBackupConfigurationSlotArgs {
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment slot. If a slot is not specified, the API will get the backup configuration for the production slot.
     */
    readonly slot: string;
}
/**
 * Description of a backup which will be performed.
 */
export interface ListWebAppBackupConfigurationSlotResult {
    /**
     * Name of the backup.
     */
    readonly backupName?: string;
    /**
     * Schedule for the backup if it is executed periodically.
     */
    readonly backupSchedule?: outputs.web.v20190801.BackupScheduleResponse;
    /**
     * Databases included in the backup.
     */
    readonly databases?: outputs.web.v20190801.DatabaseBackupSettingResponse[];
    /**
     * True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled.
     */
    readonly enabled?: boolean;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * SAS URL to the container.
     */
    readonly storageAccountUrl: string;
    /**
     * Resource type.
     */
    readonly type: string;
}