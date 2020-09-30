// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getPipeline(args: GetPipelineArgs, opts?: pulumi.InvokeOptions): Promise<GetPipelineResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datafactory/v20180601:getPipeline", {
        "factoryName": args.factoryName,
        "pipelineName": args.pipelineName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPipelineArgs {
    /**
     * The factory name.
     */
    readonly factoryName: string;
    /**
     * The pipeline name.
     */
    readonly pipelineName: string;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: string;
}

/**
 * Pipeline resource type.
 */
export interface GetPipelineResult {
    /**
     * List of activities in pipeline.
     */
    readonly activities?: outputs.datafactory.v20180601.ControlActivityResponse | outputs.datafactory.v20180601.ExecutionActivityResponse[];
    /**
     * List of tags that can be used for describing the Pipeline.
     */
    readonly annotations?: any[];
    /**
     * The max number of concurrent runs for the pipeline.
     */
    readonly concurrency?: number;
    /**
     * The description of the pipeline.
     */
    readonly description?: string;
    /**
     * Etag identifies change in the resource.
     */
    readonly etag: string;
    /**
     * The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level.
     */
    readonly folder?: outputs.datafactory.v20180601.PipelineResponseFolder;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * List of parameters for pipeline.
     */
    readonly parameters?: {[key: string]: outputs.datafactory.v20180601.ParameterSpecificationResponse};
    /**
     * Dimensions emitted by Pipeline.
     */
    readonly runDimensions?: {[key: string]: any};
    /**
     * The resource type.
     */
    readonly type: string;
    /**
     * List of variables for pipeline.
     */
    readonly variables?: {[key: string]: outputs.datafactory.v20180601.VariableSpecificationResponse};
}
