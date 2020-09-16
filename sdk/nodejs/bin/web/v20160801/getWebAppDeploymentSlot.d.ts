import * as pulumi from "@pulumi/pulumi";
export declare function getWebAppDeploymentSlot(args: GetWebAppDeploymentSlotArgs, opts?: pulumi.InvokeOptions): Promise<GetWebAppDeploymentSlotResult>;
export interface GetWebAppDeploymentSlotArgs {
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
    /**
     * Name of the deployment slot. If a slot is not specified, the API gets a deployment for the production slot.
     */
    readonly slot: string;
}
/**
 * User credentials used for publishing activity.
 */
export interface GetWebAppDeploymentSlotResult {
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