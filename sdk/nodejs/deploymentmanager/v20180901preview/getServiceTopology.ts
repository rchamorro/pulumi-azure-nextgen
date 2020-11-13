// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getServiceTopology(args: GetServiceTopologyArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceTopologyResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:deploymentmanager/v20180901preview:getServiceTopology", {
        "resourceGroupName": args.resourceGroupName,
        "serviceTopologyName": args.serviceTopologyName,
    }, opts);
}

export interface GetServiceTopologyArgs {
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the service topology .
     */
    readonly serviceTopologyName: string;
}

/**
 * The resource representation of a service topology.
 */
export interface GetServiceTopologyResult {
    /**
     * The resource Id of the artifact source that contains the artifacts that can be referenced in the service units.
     */
    readonly artifactSourceId?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}
