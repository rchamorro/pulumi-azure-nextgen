// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDeploymentAtSubscriptionScope(args: GetDeploymentAtSubscriptionScopeArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentAtSubscriptionScopeResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:resources/v20190701:getDeploymentAtSubscriptionScope", {
        "deploymentName": args.deploymentName,
    }, opts);
}

export interface GetDeploymentAtSubscriptionScopeArgs {
    /**
     * The name of the deployment.
     */
    readonly deploymentName: string;
}

/**
 * Deployment information.
 */
export interface GetDeploymentAtSubscriptionScopeResult {
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
    readonly properties: outputs.resources.v20190701.DeploymentPropertiesExtendedResponse;
    /**
     * The type of the deployment.
     */
    readonly type: string;
}
