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
    return pulumi.runtime.invoke("azure-nextgen:media/v20180330preview:getJob", {
        "accountName": args.accountName,
        "jobName": args.jobName,
        "resourceGroupName": args.resourceGroupName,
        "transformName": args.transformName,
    }, opts);
}

export interface GetJobArgs {
    /**
     * The Media Services account name.
     */
    readonly accountName: string;
    /**
     * The Job name.
     */
    readonly jobName: string;
    /**
     * The name of the resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The Transform name.
     */
    readonly transformName: string;
}

/**
 * A Job resource type. The progress and state can be obtained by polling a Job or subscribing to events using EventGrid.
 */
export interface GetJobResult {
    /**
     * The UTC date and time when the Job was created, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    readonly created: string;
    /**
     * Optional customer supplied description of the Job.
     */
    readonly description?: string;
    /**
     * The inputs for the Job.
     */
    readonly input: outputs.media.v20180330preview.JobInputClipResponse | outputs.media.v20180330preview.JobInputsResponse;
    /**
     * The UTC date and time when the Job was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    readonly lastModified: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The outputs for the Job.
     */
    readonly outputs: outputs.media.v20180330preview.JobOutputAssetResponse[];
    /**
     * Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
     */
    readonly priority?: string;
    /**
     * The current state of the job.
     */
    readonly state: string;
    /**
     * The type of the resource.
     */
    readonly type: string;
}
