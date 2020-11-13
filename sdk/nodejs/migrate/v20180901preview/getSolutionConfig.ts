// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getSolutionConfig(args: GetSolutionConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetSolutionConfigResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:migrate/v20180901preview:getSolutionConfig", {
        "migrateProjectName": args.migrateProjectName,
        "resourceGroupName": args.resourceGroupName,
        "solutionName": args.solutionName,
    }, opts);
}

export interface GetSolutionConfigArgs {
    /**
     * Name of the Azure Migrate project.
     */
    readonly migrateProjectName: string;
    /**
     * Name of the Azure Resource Group that migrate project is part of.
     */
    readonly resourceGroupName: string;
    /**
     * Unique name of a migration solution within a migrate project.
     */
    readonly solutionName: string;
}

/**
 * Class representing the config for the solution in the migrate project.
 */
export interface GetSolutionConfigResult {
    /**
     * Gets or sets the publisher sas uri for the solution.
     */
    readonly publisherSasUri?: string;
}
