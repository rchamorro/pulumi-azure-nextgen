// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function listLinkedResource(args: ListLinkedResourceArgs, opts?: pulumi.InvokeOptions): Promise<ListLinkedResourceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:datadog/v20200201preview:listLinkedResource", {
        "monitorName": args.monitorName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface ListLinkedResourceArgs {
    /**
     * Monitor resource name
     */
    readonly monitorName: string;
    /**
     * The name of the resource group to which the Datadog resource belongs.
     */
    readonly resourceGroupName: string;
}

/**
 * Response of a list operation.
 */
export interface ListLinkedResourceResult {
    /**
     * Link to the next set of results, if any.
     */
    readonly nextLink?: string;
    /**
     * Results of a list operation.
     */
    readonly value?: outputs.datadog.v20200201preview.LinkedResourceResponse[];
}
