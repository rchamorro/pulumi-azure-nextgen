// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getHubRouteTable(args: GetHubRouteTableArgs, opts?: pulumi.InvokeOptions): Promise<GetHubRouteTableResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getHubRouteTable", {
        "resourceGroupName": args.resourceGroupName,
        "routeTableName": args.routeTableName,
        "virtualHubName": args.virtualHubName,
    }, opts);
}

export interface GetHubRouteTableArgs {
    /**
     * The resource group name of the VirtualHub.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the RouteTable.
     */
    readonly routeTableName: string;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: string;
}

/**
 * RouteTable resource in a virtual hub.
 */
export interface GetHubRouteTableResult {
    /**
     * List of all connections associated with this route table.
     */
    readonly associatedConnections: string[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * List of labels associated with this route table.
     */
    readonly labels?: string[];
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * List of all connections that advertise to this route table.
     */
    readonly propagatingConnections: string[];
    /**
     * The provisioning state of the RouteTable resource.
     */
    readonly provisioningState: string;
    /**
     * List of all routes.
     */
    readonly routes?: outputs.network.latest.HubRouteResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
}
