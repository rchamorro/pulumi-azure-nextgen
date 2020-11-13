// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getImportPipeline(args: GetImportPipelineArgs, opts?: pulumi.InvokeOptions): Promise<GetImportPipelineResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerregistry/v20191201preview:getImportPipeline", {
        "importPipelineName": args.importPipelineName,
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetImportPipelineArgs {
    /**
     * The name of the import pipeline.
     */
    readonly importPipelineName: string;
    /**
     * The name of the container registry.
     */
    readonly registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * An object that represents an import pipeline for a container registry.
 */
export interface GetImportPipelineResult {
    /**
     * The identity of the import pipeline.
     */
    readonly identity?: outputs.containerregistry.v20191201preview.IdentityPropertiesResponse;
    /**
     * The location of the import pipeline.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The list of all options configured for the pipeline.
     */
    readonly options?: string[];
    /**
     * The provisioning state of the pipeline at the time the operation was called.
     */
    readonly provisioningState: string;
    /**
     * The source properties of the import pipeline.
     */
    readonly source: outputs.containerregistry.v20191201preview.ImportPipelineSourcePropertiesResponse;
    /**
     * The properties that describe the trigger of the import pipeline.
     */
    readonly trigger?: outputs.containerregistry.v20191201preview.PipelineTriggerPropertiesResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}
