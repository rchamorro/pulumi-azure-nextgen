// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function listClusterLanguageExtensions(args: ListClusterLanguageExtensionsArgs, opts?: pulumi.InvokeOptions): Promise<ListClusterLanguageExtensionsResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:kusto/latest:listClusterLanguageExtensions", {
        "clusterName": args.clusterName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListClusterLanguageExtensionsArgs {
    /**
     * The name of the Kusto cluster.
     */
    readonly clusterName: string;
    /**
     * The name of the resource group containing the Kusto cluster.
     */
    readonly resourceGroupName: string;
}

/**
 * The list of language extension objects.
 */
export interface ListClusterLanguageExtensionsResult {
    /**
     * The list of language extensions.
     */
    readonly value?: outputs.kusto.latest.LanguageExtensionResponse[];
}
