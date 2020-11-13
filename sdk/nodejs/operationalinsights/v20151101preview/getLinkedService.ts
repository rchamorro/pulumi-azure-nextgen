// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getLinkedService(args: GetLinkedServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetLinkedServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:operationalinsights/v20151101preview:getLinkedService", {
        "linkedServiceName": args.linkedServiceName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetLinkedServiceArgs {
    /**
     * Name of the linked service.
     */
    readonly linkedServiceName: string;
    /**
     * The name of the resource group to get. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * Name of the Log Analytics Workspace that contains the linkedServices resource
     */
    readonly workspaceName: string;
}

/**
 * The top level Linked service resource container.
 */
export interface GetLinkedServiceResult {
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The resource id of the resource that will be linked to the workspace.
     */
    readonly resourceId: string;
    /**
     * Resource type.
     */
    readonly type: string;
}
