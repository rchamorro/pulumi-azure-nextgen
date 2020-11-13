// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getRouteFilter(args: GetRouteFilterArgs, opts?: pulumi.InvokeOptions): Promise<GetRouteFilterResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20190401:getRouteFilter", {
        "expand": args.expand,
        "resourceGroupName": args.resourceGroupName,
        "routeFilterName": args.routeFilterName,
    }, opts);
}

export interface GetRouteFilterArgs {
    /**
     * Expands referenced express route bgp peering resources.
     */
    readonly expand?: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the route filter.
     */
    readonly routeFilterName: string;
}

/**
 * Route Filter Resource.
 */
export interface GetRouteFilterResult {
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * A collection of references to express route circuit ipv6 peerings.
     */
    readonly ipv6Peerings?: outputs.network.v20190401.ExpressRouteCircuitPeeringResponse[];
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * A collection of references to express route circuit peerings.
     */
    readonly peerings?: outputs.network.v20190401.ExpressRouteCircuitPeeringResponse[];
    /**
     * The provisioning state of the resource. Possible values are: 'Updating', 'Deleting', 'Succeeded' and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * Collection of RouteFilterRules contained within a route filter.
     */
    readonly rules?: outputs.network.v20190401.RouteFilterRuleResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
