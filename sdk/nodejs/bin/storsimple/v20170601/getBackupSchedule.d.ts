import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getBackupSchedule(args: GetBackupScheduleArgs, opts?: pulumi.InvokeOptions): Promise<GetBackupScheduleResult>;
export interface GetBackupScheduleArgs {
    /**
     * The backup policy name.
     */
    readonly backupPolicyName: string;
    /**
     * The name of the backup schedule to be fetched
     */
    readonly backupScheduleName: string;
    /**
     * The device name
     */
    readonly deviceName: string;
    /**
     * The manager name
     */
    readonly managerName: string;
    /**
     * The resource group name
     */
    readonly resourceGroupName: string;
}
/**
 * The backup schedule.
 */
export interface GetBackupScheduleResult {
    /**
     * The type of backup which needs to be taken.
     */
    readonly backupType: string;
    /**
     * The Kind of the object. Currently only Series8000 is supported
     */
    readonly kind?: string;
    /**
     * The last successful backup run which was triggered for the schedule.
     */
    readonly lastSuccessfulRun: string;
    /**
     * The name of the object.
     */
    readonly name: string;
    /**
     * The number of backups to be retained.
     */
    readonly retentionCount: number;
    /**
     * The schedule recurrence.
     */
    readonly scheduleRecurrence: outputs.storsimple.v20170601.ScheduleRecurrenceResponse;
    /**
     * The schedule status.
     */
    readonly scheduleStatus: string;
    /**
     * The start time of the schedule.
     */
    readonly startTime: string;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
}