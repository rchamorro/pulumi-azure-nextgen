import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getSchedule(args: GetScheduleArgs, opts?: pulumi.InvokeOptions): Promise<GetScheduleResult>;
export interface GetScheduleArgs {
    /**
     * Specify the $expand query. Example: 'properties($select=status)'
     */
    readonly expand?: string;
    /**
     * The name of the lab.
     */
    readonly labName: string;
    /**
     * The name of the schedule.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}
/**
 * A schedule.
 */
export interface GetScheduleResult {
    /**
     * The creation date of the schedule.
     */
    readonly createdDate: string;
    /**
     * If the schedule will occur once each day of the week, specify the daily recurrence.
     */
    readonly dailyRecurrence?: outputs.devtestlab.v20180915.DayDetailsResponse;
    /**
     * If the schedule will occur multiple times a day, specify the hourly recurrence.
     */
    readonly hourlyRecurrence?: outputs.devtestlab.v20180915.HourDetailsResponse;
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * Notification settings.
     */
    readonly notificationSettings?: outputs.devtestlab.v20180915.NotificationSettingsResponse;
    /**
     * The provisioning status of the resource.
     */
    readonly provisioningState: string;
    /**
     * The status of the schedule (i.e. Enabled, Disabled)
     */
    readonly status?: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * The resource ID to which the schedule belongs
     */
    readonly targetResourceId?: string;
    /**
     * The task type of the schedule (e.g. LabVmsShutdownTask, LabVmAutoStart).
     */
    readonly taskType?: string;
    /**
     * The time zone ID (e.g. Pacific Standard time).
     */
    readonly timeZoneId?: string;
    /**
     * The type of the resource.
     */
    readonly type: string;
    /**
     * The unique immutable identifier of a resource (Guid).
     */
    readonly uniqueIdentifier: string;
    /**
     * If the schedule will occur only some days of the week, specify the weekly recurrence.
     */
    readonly weeklyRecurrence?: outputs.devtestlab.v20180915.WeekDetailsResponse;
}