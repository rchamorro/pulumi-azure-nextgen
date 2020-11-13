// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listScheduleApplicable(args: ListScheduleApplicableArgs, opts?: pulumi.InvokeOptions): Promise<ListScheduleApplicableResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devtestlab/v20180915:listScheduleApplicable", {
        "labName": args.labName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListScheduleApplicableArgs {
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
 * The response of a list operation.
 */
export interface ListScheduleApplicableResult {
    /**
     * Link for next set of results.
     */
    readonly nextLink?: string;
    /**
     * Results of the list operation.
     */
    readonly value?: outputs.devtestlab.v20180915.ScheduleResponse[];
}
