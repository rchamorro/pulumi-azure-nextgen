// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getBandwidthSchedule(args: GetBandwidthScheduleArgs, opts?: pulumi.InvokeOptions): Promise<GetBandwidthScheduleResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:databoxedge/v20200901preview:getBandwidthSchedule", {
        "deviceName": args.deviceName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetBandwidthScheduleArgs {
    /**
     * The device name.
     */
    readonly deviceName: string;
    /**
     * The bandwidth schedule name.
     */
    readonly name: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * The bandwidth schedule details.
 */
export interface GetBandwidthScheduleResult {
    /**
     * The days of the week when this schedule is applicable.
     */
    readonly days: string[];
    /**
     * The path ID that uniquely identifies the object.
     */
    readonly id: string;
    /**
     * The object name.
     */
    readonly name: string;
    /**
     * The bandwidth rate in Mbps.
     */
    readonly rateInMbps: number;
    /**
     * The start time of the schedule in UTC.
     */
    readonly start: string;
    /**
     * The stop time of the schedule in UTC.
     */
    readonly stop: string;
    /**
     * Bandwidth object related to ASE resource
     */
    readonly systemData: outputs.databoxedge.v20200901preview.SystemDataResponse;
    /**
     * The hierarchical type of the object.
     */
    readonly type: string;
}
