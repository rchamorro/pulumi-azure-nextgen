// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDeploymentAtScope(args: GetDeploymentAtScopeArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentAtScopeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:resources/v20191001:getDeploymentAtScope", {
        "deploymentName": args.deploymentName,
        "scope": args.scope,
    }, opts);
}

export interface GetDeploymentAtScopeArgs {
    /**
     * The name of the deployment.
     */
    readonly deploymentName: string;
    /**
     * The resource scope.
     */
    readonly scope: string;
}

/**
 * Deployment information.
 */
export interface GetDeploymentAtScopeResult {
    /**
     * the location of the deployment.
     */
    readonly location?: string;
    /**
     * The name of the deployment.
     */
    readonly name: string;
    /**
     * Deployment properties.
     */
    readonly properties: outputs.resources.v20191001.DeploymentPropertiesExtendedResponse;
    /**
     * Deployment tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the deployment.
     */
    readonly type: string;
}
