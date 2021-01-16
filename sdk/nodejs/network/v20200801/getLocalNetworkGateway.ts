// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getLocalNetworkGateway(args: GetLocalNetworkGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetLocalNetworkGatewayResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200801:getLocalNetworkGateway", {
        "localNetworkGatewayName": args.localNetworkGatewayName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetLocalNetworkGatewayArgs {
    /**
     * The name of the local network gateway.
     */
    readonly localNetworkGatewayName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A common class for general resource information.
 */
export interface GetLocalNetworkGatewayResult {
    /**
     * Local network gateway's BGP speaker settings.
     */
    readonly bgpSettings?: outputs.network.v20200801.BgpSettingsResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * FQDN of local network gateway.
     */
    readonly fqdn?: string;
    /**
     * IP address of local network gateway.
     */
    readonly gatewayIpAddress?: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * Local network site address space.
     */
    readonly localNetworkAddressSpace?: outputs.network.v20200801.AddressSpaceResponse;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the local network gateway resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the local network gateway resource.
     */
    readonly resourceGuid: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
