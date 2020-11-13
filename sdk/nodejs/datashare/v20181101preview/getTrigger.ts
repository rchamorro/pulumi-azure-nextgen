// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getTrigger(args: GetTriggerArgs, opts?: pulumi.InvokeOptions): Promise<GetTriggerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datashare/v20181101preview:getTrigger", {
        "accountName": args.accountName,
        "resourceGroupName": args.resourceGroupName,
        "shareSubscriptionName": args.shareSubscriptionName,
        "triggerName": args.triggerName,
    }, opts);
}

export interface GetTriggerArgs {
    /**
     * The name of the share account.
     */
    readonly accountName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the shareSubscription.
     */
    readonly shareSubscriptionName: string;
    /**
     * The name of the trigger.
     */
    readonly triggerName: string;
}

/**
 * A Trigger data transfer object.
 */
export interface GetTriggerResult {
    /**
     * Kind of synchronization
     */
    readonly kind: string;
    /**
     * Name of the azure resource
     */
    readonly name: string;
    /**
     * Type of the azure resource
     */
    readonly type: string;
}
