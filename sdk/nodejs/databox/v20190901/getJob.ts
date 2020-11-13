// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getJob(args: GetJobArgs, opts?: pulumi.InvokeOptions): Promise<GetJobResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:databox/v20190901:getJob", {
        "expand": args.expand,
        "jobName": args.jobName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetJobArgs {
    /**
     * $expand is supported on details parameter for job, which provides details on the job stages.
     */
    readonly expand?: string;
    /**
     * The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
     */
    readonly jobName: string;
    /**
     * The Resource Group Name
     */
    readonly resourceGroupName: string;
}

/**
 * Job Resource.
 */
export interface GetJobResult {
    /**
     * Reason for cancellation.
     */
    readonly cancellationReason: string;
    /**
     * Delivery Info of Job.
     */
    readonly deliveryInfo?: outputs.databox.v20190901.JobDeliveryInfoResponse;
    /**
     * Delivery type of Job.
     */
    readonly deliveryType?: string;
    /**
     * Details of a job run. This field will only be sent for expand details filter.
     */
    readonly details?: outputs.databox.v20190901.DataBoxDiskJobDetailsResponse | outputs.databox.v20190901.DataBoxHeavyJobDetailsResponse | outputs.databox.v20190901.DataBoxJobDetailsResponse;
    /**
     * Top level error for the job.
     */
    readonly error: outputs.databox.v20190901.ErrorResponse;
    /**
     * Describes whether the job is cancellable or not.
     */
    readonly isCancellable: boolean;
    /**
     * Flag to indicate cancellation of scheduled job.
     */
    readonly isCancellableWithoutFee: boolean;
    /**
     * Describes whether the job is deletable or not.
     */
    readonly isDeletable: boolean;
    /**
     * Describes whether the shipping address is editable or not.
     */
    readonly isShippingAddressEditable: boolean;
    /**
     * The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on update the request will succeed.
     */
    readonly location: string;
    /**
     * Name of the object.
     */
    readonly name: string;
    /**
     * The sku type.
     */
    readonly sku: outputs.databox.v20190901.SkuResponse;
    /**
     * Time at which the job was started in UTC ISO 8601 format.
     */
    readonly startTime: string;
    /**
     * Name of the stage which is in progress.
     */
    readonly status: string;
    /**
     * The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).
     */
    readonly tags?: {[key: string]: string};
    /**
     * Type of the object.
     */
    readonly type: string;
}
