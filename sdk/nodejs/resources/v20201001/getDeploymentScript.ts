// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDeploymentScript(args: GetDeploymentScriptArgs, opts?: pulumi.InvokeOptions): Promise<GetDeploymentScriptResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:resources/v20201001:getDeploymentScript", {
        "resourceGroupName": args.resourceGroupName,
        "scriptName": args.scriptName,
    }, opts);
}

export interface GetDeploymentScriptArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the deployment script.
     */
    readonly scriptName: string;
}

/**
 * Deployment script object.
 */
export interface GetDeploymentScriptResult {
    /**
     * Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported.
     */
    readonly identity?: outputs.resources.v20201001.ManagedServiceIdentityResponse;
    /**
     * Type of the script.
     */
    readonly kind: string;
    /**
     * The location of the ACI and the storage account for the deployment script.
     */
    readonly location: string;
    /**
     * Name of this resource.
     */
    readonly name: string;
    /**
     * The system metadata related to this resource.
     */
    readonly systemData: outputs.resources.v20201001.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Type of this resource.
     */
    readonly type: string;
}
