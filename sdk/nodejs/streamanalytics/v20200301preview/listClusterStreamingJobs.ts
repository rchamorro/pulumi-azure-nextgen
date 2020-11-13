// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listClusterStreamingJobs(args: ListClusterStreamingJobsArgs, opts?: pulumi.InvokeOptions): Promise<ListClusterStreamingJobsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:streamanalytics/v20200301preview:listClusterStreamingJobs", {
        "clusterName": args.clusterName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListClusterStreamingJobsArgs {
    /**
     * The name of the cluster.
     */
    readonly clusterName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
}

/**
 * A list of streaming jobs. Populated by a List operation.
 */
export interface ListClusterStreamingJobsResult {
    /**
     * The URL to fetch the next set of streaming jobs.
     */
    readonly nextLink: string;
    /**
     * A list of streaming jobs.
     */
    readonly value: outputs.streamanalytics.v20200301preview.ClusterJobResponse[];
}
