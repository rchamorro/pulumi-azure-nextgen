// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listTaskDetails(args: ListTaskDetailsArgs, opts?: pulumi.InvokeOptions): Promise<ListTaskDetailsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerregistry/v20190601preview:listTaskDetails", {
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
        "taskName": args.taskName,
    }, opts);
}

export interface ListTaskDetailsArgs {
    /**
     * The name of the container registry.
     */
    readonly registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the container registry task.
     */
    readonly taskName: string;
}

/**
 * The task that has the ARM resource and task properties. 
 * The task will have all information to schedule a run against it.
 */
export interface ListTaskDetailsResult {
    /**
     * The machine configuration of the run agent.
     */
    readonly agentConfiguration?: outputs.containerregistry.v20190601preview.AgentPropertiesResponse;
    /**
     * The dedicated agent pool for the task.
     */
    readonly agentPoolName?: string;
    /**
     * The creation date of task.
     */
    readonly creationDate: string;
    /**
     * The properties that describes a set of credentials that will be used when this run is invoked.
     */
    readonly credentials?: outputs.containerregistry.v20190601preview.CredentialsResponse;
    /**
     * Identity for the resource.
     */
    readonly identity?: outputs.containerregistry.v20190601preview.IdentityPropertiesResponse;
    /**
     * The value of this property indicates whether the task resource is system task or not.
     */
    readonly isSystemTask?: boolean;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    readonly location: string;
    /**
     * The template that describes the repository and tag information for run log artifact.
     */
    readonly logTemplate?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The platform properties against which the run has to happen.
     */
    readonly platform?: outputs.containerregistry.v20190601preview.PlatformPropertiesResponse;
    /**
     * The provisioning state of the task.
     */
    readonly provisioningState: string;
    /**
     * The current status of task.
     */
    readonly status?: string;
    /**
     * The properties of a task step.
     */
    readonly step?: outputs.containerregistry.v20190601preview.DockerBuildStepResponse | outputs.containerregistry.v20190601preview.EncodedTaskStepResponse | outputs.containerregistry.v20190601preview.FileTaskStepResponse;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Run timeout in seconds.
     */
    readonly timeout?: number;
    /**
     * The properties that describe all triggers for the task.
     */
    readonly trigger?: outputs.containerregistry.v20190601preview.TriggerPropertiesResponse;
    /**
     * The type of the resource.
     */
    readonly type: string;
}
