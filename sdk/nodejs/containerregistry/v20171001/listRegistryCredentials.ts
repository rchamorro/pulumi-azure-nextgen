// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listRegistryCredentials(args: ListRegistryCredentialsArgs, opts?: pulumi.InvokeOptions): Promise<ListRegistryCredentialsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerregistry/v20171001:listRegistryCredentials", {
        "registryName": args.registryName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListRegistryCredentialsArgs {
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
 * The response from the ListCredentials operation.
 */
export interface ListRegistryCredentialsResult {
    /**
     * The list of passwords for a container registry.
     */
    readonly passwords?: outputs.containerregistry.v20171001.RegistryPasswordResponse[];
    /**
     * The username for a container registry.
     */
    readonly username?: string;
}
