// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getEnvironment(args: GetEnvironmentArgs, opts?: pulumi.InvokeOptions): Promise<GetEnvironmentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:timeseriesinsights/v20170228preview:getEnvironment", {
        "environmentName": args.environmentName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetEnvironmentArgs {
    /**
     * The name of the Time Series Insights environment associated with the specified resource group.
     */
    readonly environmentName: string;
    /**
     * Name of an Azure Resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * An environment is a set of time-series data available for query, and is the top level Azure Time Series Insights resource.
 */
export interface GetEnvironmentResult {
    /**
     * The time the resource was created.
     */
    readonly creationTime: string;
    /**
     * The fully qualified domain name used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
     */
    readonly dataAccessFqdn: string;
    /**
     * An id used to access the environment data, e.g. to query the environment's events or upload reference data for the environment.
     */
    readonly dataAccessId: string;
    /**
     * ISO8601 timespan specifying the minimum number of days the environment's events will be available for query.
     */
    readonly dataRetentionTime: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Provisioning state of the resource.
     */
    readonly provisioningState: string;
    /**
     * The sku determines the capacity of the environment, the SLA (in queries-per-minute and total capacity), and the billing rate.
     */
    readonly sku?: outputs.timeseriesinsights.v20170228preview.SkuResponse;
    /**
     * The behavior the Time Series Insights service should take when the environment's capacity has been exceeded. If "PauseIngress" is specified, new events will not be read from the event source. If "PurgeOldData" is specified, new events will continue to be read and old events will be deleted from the environment. The default behavior is PurgeOldData.
     */
    readonly storageLimitExceededBehavior?: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}