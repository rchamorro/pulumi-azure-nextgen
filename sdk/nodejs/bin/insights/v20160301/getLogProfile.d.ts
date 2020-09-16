import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getLogProfile(args: GetLogProfileArgs, opts?: pulumi.InvokeOptions): Promise<GetLogProfileResult>;
export interface GetLogProfileArgs {
    /**
     * The name of the log profile.
     */
    readonly logProfileName: string;
}
/**
 * The log profile resource.
 */
export interface GetLogProfileResult {
    /**
     * the categories of the logs. These categories are created as is convenient to the user. Some values are: 'Write', 'Delete', and/or 'Action.'
     */
    readonly categories: string[];
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the 'global' location.
     */
    readonly locations: string[];
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * the retention policy for the events in the log.
     */
    readonly retentionPolicy: outputs.insights.v20160301.RetentionPolicyResponse;
    /**
     * The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: '{service bus resource ID}/authorizationrules/{key name}'.
     */
    readonly serviceBusRuleId?: string;
    /**
     * the resource id of the storage account to which you would like to send the Activity Log.
     */
    readonly storageAccountId?: string;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Azure resource type
     */
    readonly type: string;
}