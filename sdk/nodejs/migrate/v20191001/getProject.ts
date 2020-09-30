// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getProject(args: GetProjectArgs, opts?: pulumi.InvokeOptions): Promise<GetProjectResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:migrate/v20191001:getProject", {
        "projectName": args.projectName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetProjectArgs {
    /**
     * Name of the Azure Migrate project.
     */
    readonly projectName: string;
    /**
     * Name of the Azure Resource Group that project is part of.
     */
    readonly resourceGroupName: string;
}

/**
 * Azure Migrate Project.
 */
export interface GetProjectResult {
    /**
     * For optimistic concurrency control.
     */
    readonly eTag?: string;
    /**
     * Azure location in which project is created.
     */
    readonly location?: string;
    /**
     * Name of the project.
     */
    readonly name: string;
    /**
     * Properties of the project.
     */
    readonly properties: outputs.migrate.v20191001.ProjectPropertiesResponse;
    /**
     * Tags provided by Azure Tagging service.
     */
    readonly tags?: any;
    /**
     * Type of the object = [Microsoft.Migrate/assessmentProjects].
     */
    readonly type: string;
}
