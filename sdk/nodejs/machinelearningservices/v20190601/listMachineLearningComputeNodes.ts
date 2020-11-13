// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listMachineLearningComputeNodes(args: ListMachineLearningComputeNodesArgs, opts?: pulumi.InvokeOptions): Promise<ListMachineLearningComputeNodesResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:machinelearningservices/v20190601:listMachineLearningComputeNodes", {
        "computeName": args.computeName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface ListMachineLearningComputeNodesArgs {
    /**
     * Name of the Azure Machine Learning compute.
     */
    readonly computeName: string;
    /**
     * Name of the resource group in which workspace is located.
     */
    readonly resourceGroupName: string;
    /**
     * Name of Azure Machine Learning workspace.
     */
    readonly workspaceName: string;
}

/**
 * Compute node information related to a AmlCompute.
 */
export interface ListMachineLearningComputeNodesResult {
    /**
     * The type of compute
     */
    readonly computeType: "AmlCompute";
    /**
     * The continuation token.
     */
    readonly nextLink: string;
    /**
     * The collection of returned AmlCompute nodes details.
     */
    readonly nodes: outputs.machinelearningservices.v20190601.AmlComputeNodeInformationResponse[];
}
