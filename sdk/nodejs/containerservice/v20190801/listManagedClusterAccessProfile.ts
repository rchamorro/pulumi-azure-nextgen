// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listManagedClusterAccessProfile(args: ListManagedClusterAccessProfileArgs, opts?: pulumi.InvokeOptions): Promise<ListManagedClusterAccessProfileResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:containerservice/v20190801:listManagedClusterAccessProfile", {
        "resourceGroupName": args.resourceGroupName,
        "resourceName": args.resourceName,
        "roleName": args.roleName,
    }, opts);
}

export interface ListManagedClusterAccessProfileArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the managed cluster resource.
     */
    readonly resourceName: string;
    /**
     * The name of the role for managed cluster accessProfile resource.
     */
    readonly roleName: string;
}

/**
 * Managed cluster Access Profile.
 */
export interface ListManagedClusterAccessProfileResult {
    /**
     * Base64-encoded Kubernetes configuration file.
     */
    readonly kubeConfig?: string;
    /**
     * Resource location
     */
    readonly location: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
}
