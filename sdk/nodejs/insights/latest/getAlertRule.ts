// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getAlertRule(args: GetAlertRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetAlertRuleResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:insights/latest:getAlertRule", {
        "resourceGroupName": args.resourceGroupName,
        "ruleName": args.ruleName,
    }, opts);
}

export interface GetAlertRuleArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the rule.
     */
    readonly ruleName: string;
}

/**
 * The alert rule resource.
 */
export interface GetAlertRuleResult {
    /**
     * the array of actions that are performed when the alert rule becomes active, and when an alert condition is resolved.
     */
    readonly actions?: outputs.insights.latest.RuleEmailActionResponse | outputs.insights.latest.RuleWebhookActionResponse[];
    /**
     * the condition that results in the alert rule being activated.
     */
    readonly condition: outputs.insights.latest.LocationThresholdRuleConditionResponse | outputs.insights.latest.ManagementEventRuleConditionResponse | outputs.insights.latest.ThresholdRuleConditionResponse;
    /**
     * the description of the alert rule that will be included in the alert email.
     */
    readonly description?: string;
    /**
     * the flag that indicates whether the alert rule is enabled.
     */
    readonly isEnabled: boolean;
    /**
     * Last time the rule was updated in ISO8601 format.
     */
    readonly lastUpdatedTime: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Azure resource name
     */
    readonly name: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Azure resource type
     */
    readonly type: string;
}
