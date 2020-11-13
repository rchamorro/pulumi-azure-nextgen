// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVirtualNetworkGatewayVpnclientConnectionHealth(args: GetVirtualNetworkGatewayVpnclientConnectionHealthArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayVpnclientConnectionHealthResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200501:getVirtualNetworkGatewayVpnclientConnectionHealth", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayName": args.virtualNetworkGatewayName,
    }, opts);
}

export interface GetVirtualNetworkGatewayVpnclientConnectionHealthArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the virtual network gateway.
     */
    readonly virtualNetworkGatewayName: string;
}

/**
 * List of virtual network gateway vpn client connection health.
 */
export interface GetVirtualNetworkGatewayVpnclientConnectionHealthResult {
    /**
     * List of vpn client connection health.
     */
    readonly value?: outputs.network.v20200501.VpnClientConnectionHealthDetailResponse[];
}
