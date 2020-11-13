// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVirtualHubRouteTableV2(args: GetVirtualHubRouteTableV2Args, opts?: pulumi.InvokeOptions): Promise<GetVirtualHubRouteTableV2Result> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200401:getVirtualHubRouteTableV2", {
        "resourceGroupName": args.resourceGroupName,
        "routeTableName": args.routeTableName,
        "virtualHubName": args.virtualHubName,
    }, opts);
}

export interface GetVirtualHubRouteTableV2Args {
    /**
     * The resource group name of the VirtualHubRouteTableV2.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VirtualHubRouteTableV2.
     */
    readonly routeTableName: string;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: string;
}

/**
 * VirtualHubRouteTableV2 Resource.
 */
export interface GetVirtualHubRouteTableV2Result {
    /**
     * List of all connections attached to this route table v2.
     */
    readonly attachedConnections?: string[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The provisioning state of the virtual hub route table v2 resource.
     */
    readonly provisioningState: string;
    /**
     * List of all routes.
     */
    readonly routes?: outputs.network.v20200401.VirtualHubRouteV2Response[];
}
