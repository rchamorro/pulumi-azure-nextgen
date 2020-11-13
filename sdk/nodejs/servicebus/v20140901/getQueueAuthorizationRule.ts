// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getQueueAuthorizationRule(args: GetQueueAuthorizationRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetQueueAuthorizationRuleResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:servicebus/v20140901:getQueueAuthorizationRule", {
        "authorizationRuleName": args.authorizationRuleName,
        "namespaceName": args.namespaceName,
        "queueName": args.queueName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetQueueAuthorizationRuleArgs {
    /**
     * The authorization rule name.
     */
    readonly authorizationRuleName: string;
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * The queue name.
     */
    readonly queueName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}

/**
 * Description of a namespace authorization rule.
 */
export interface GetQueueAuthorizationRuleResult {
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The rights associated with the rule.
     */
    readonly rights: string[];
    /**
     * Resource type
     */
    readonly type: string;
}
