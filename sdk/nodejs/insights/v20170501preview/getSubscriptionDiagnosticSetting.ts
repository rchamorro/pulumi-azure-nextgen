// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSubscriptionDiagnosticSetting(args: GetSubscriptionDiagnosticSettingArgs, opts?: pulumi.InvokeOptions): Promise<GetSubscriptionDiagnosticSettingResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:insights/v20170501preview:getSubscriptionDiagnosticSetting", {
        "name": args.name,
    }, opts);
}

export interface GetSubscriptionDiagnosticSettingArgs {
    /**
     * The name of the diagnostic setting.
     */
    readonly name: string;
}

/**
 * The subscription diagnostic setting resource.
 */
export interface GetSubscriptionDiagnosticSettingResult {
    /**
     * The resource Id for the event hub authorization rule.
     */
    readonly eventHubAuthorizationRuleId?: string;
    /**
     * The name of the event hub. If none is specified, the default event hub will be selected.
     */
    readonly eventHubName?: string;
    /**
     * Location of the resource
     */
    readonly location?: string;
    /**
     * The list of logs settings.
     */
    readonly logs?: outputs.insights.v20170501preview.SubscriptionLogSettingsResponse[];
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
     */
    readonly serviceBusRuleId?: string;
    /**
     * The resource ID of the storage account to which you would like to send Diagnostic Logs.
     */
    readonly storageAccountId?: string;
    /**
     * Azure resource type
     */
    readonly type: string;
    /**
     * The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
     */
    readonly workspaceId?: string;
}
