// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getWebAppDeployment(args: GetWebAppDeploymentArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppDeploymentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:web/latest:getWebAppDeployment", {
        "id": args.id,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetWebAppDeploymentArgs {
    /**
     * Deployment ID.
     */
    readonly id: string;
    /**
     * Name of the app.
     */
    readonly name: string;
    /**
     * Name of the resource group to which the resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * User credentials used for publishing activity.
 */
export interface GetWebAppDeploymentResult {
    /**
     * True if deployment is currently active, false if completed and null if not started.
     */
    readonly active?: boolean;
    /**
     * Who authored the deployment.
     */
    readonly author?: string;
    /**
     * Author email.
     */
    readonly authorEmail?: string;
    /**
     * Who performed the deployment.
     */
    readonly deployer?: string;
    /**
     * Details on deployment.
     */
    readonly details?: string;
    /**
     * End time.
     */
    readonly endTime?: string;
    /**
     * Kind of resource.
     */
    readonly kind?: string;
    /**
     * Details about deployment status.
     */
    readonly message?: string;
    /**
     * Resource Name.
     */
    readonly name: string;
    /**
     * Start time.
     */
    readonly startTime?: string;
    /**
     * Deployment status.
     */
    readonly status?: number;
    /**
     * Resource type.
     */
    readonly type: string;
}
