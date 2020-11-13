// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getServiceRunner(args: GetServiceRunnerArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceRunnerResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:devtestlab/latest:getServiceRunner", {
        "labName": args.labName,
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetServiceRunnerArgs {
    /**
     * The name of the lab.
     */
    readonly labName: string;
    /**
     * The name of the service runner.
     */
    readonly name: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A container for a managed identity to execute DevTest lab services.
 */
export interface GetServiceRunnerResult {
    /**
     * The identity of the resource.
     */
    readonly identity?: outputs.devtestlab.latest.IdentityPropertiesResponse;
    /**
     * The location of the resource.
     */
    readonly location?: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The tags of the resource.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}
