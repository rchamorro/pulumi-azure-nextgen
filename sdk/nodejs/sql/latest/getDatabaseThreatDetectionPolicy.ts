// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getDatabaseThreatDetectionPolicy(args: GetDatabaseThreatDetectionPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetDatabaseThreatDetectionPolicyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:sql/latest:getDatabaseThreatDetectionPolicy", {
        "databaseName": args.databaseName,
        "resourceGroupName": args.resourceGroupName,
        "securityAlertPolicyName": args.securityAlertPolicyName,
        "serverName": args.serverName,
    }, opts);
}

export interface GetDatabaseThreatDetectionPolicyArgs {
    /**
     * The name of the database for which database Threat Detection policy is defined.
     */
    readonly databaseName: string;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the security alert policy.
     */
    readonly securityAlertPolicyName: string;
    /**
     * The name of the server.
     */
    readonly serverName: string;
}

/**
 * Contains information about a database Threat Detection policy.
 */
export interface GetDatabaseThreatDetectionPolicyResult {
    /**
     * Specifies the semicolon-separated list of alerts that are disabled, or empty string to disable no alerts. Possible values: Sql_Injection; Sql_Injection_Vulnerability; Access_Anomaly; Data_Exfiltration; Unsafe_Action.
     */
    readonly disabledAlerts?: string;
    /**
     * Specifies that the alert is sent to the account administrators.
     */
    readonly emailAccountAdmins?: string;
    /**
     * Specifies the semicolon-separated list of e-mail addresses to which the alert is sent.
     */
    readonly emailAddresses?: string;
    /**
     * Resource ID.
     */
    readonly id: string;
    /**
     * Resource kind.
     */
    readonly kind: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * Specifies the number of days to keep in the Threat Detection audit logs.
     */
    readonly retentionDays?: number;
    /**
     * Specifies the state of the policy. If state is Enabled, storageEndpoint and storageAccountAccessKey are required.
     */
    readonly state: string;
    /**
     * Specifies the identifier key of the Threat Detection audit storage account. If state is Enabled, storageAccountAccessKey is required.
     */
    readonly storageAccountAccessKey?: string;
    /**
     * Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. If state is Enabled, storageEndpoint is required.
     */
    readonly storageEndpoint?: string;
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Specifies whether to use the default server policy.
     */
    readonly useServerDefault?: string;
}
