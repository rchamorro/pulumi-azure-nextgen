// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listBuildStepBuildArguments(args: ListBuildStepBuildArgumentsArgs, opts?: pulumi.InvokeOptions): Promise<ListBuildStepBuildArgumentsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerregistry/v20180201preview:listBuildStepBuildArguments", {
        "buildTaskName": args.buildTaskName,
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
        "stepName": args.stepName,
    }, opts);
}

export interface ListBuildStepBuildArgumentsArgs {
    /**
     * The name of the container registry build task.
     */
    readonly buildTaskName: string;
    /**
     * The name of the container registry.
     */
    readonly registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
    /**
     * The name of a build step for a container registry build task.
     */
    readonly stepName: string;
}

/**
 * The list of build arguments for a build step.
 */
export interface ListBuildStepBuildArgumentsResult {
    /**
     * The URI that can be used to request the next set of paged results.
     */
    readonly nextLink?: string;
    /**
     * The collection value.
     */
    readonly value?: outputs.containerregistry.v20180201preview.BuildArgumentResponse[];
}
