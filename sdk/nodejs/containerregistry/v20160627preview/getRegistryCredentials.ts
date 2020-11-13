// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRegistryCredentials(args: GetRegistryCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<GetRegistryCredentialsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerregistry/v20160627preview:getRegistryCredentials", {
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetRegistryCredentialsArgs {
    /**
     * The name of the container registry.
     */
    readonly registryName: string;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * The result of a request to get the administrator login credentials for a container registry.
 */
export interface GetRegistryCredentialsResult {
    /**
     * The administrator password.
     */
    readonly password?: string;
    /**
     * The administrator username.
     */
    readonly username?: string;
}
