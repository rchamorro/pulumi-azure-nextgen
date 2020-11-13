// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getVirtualNetworkGatewayConnection(args: GetVirtualNetworkGatewayConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayConnectionResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20171001:getVirtualNetworkGatewayConnection", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayConnectionName": args.virtualNetworkGatewayConnectionName,
    }, opts);
}

export interface GetVirtualNetworkGatewayConnectionArgs {
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the virtual network gateway connection.
     */
    readonly virtualNetworkGatewayConnectionName: string;
}

/**
 * A common class for general resource information
 */
export interface GetVirtualNetworkGatewayConnectionResult {
    /**
     * The authorizationKey.
     */
    readonly authorizationKey?: string;
    /**
     * Virtual network Gateway connection status. Possible values are 'Unknown', 'Connecting', 'Connected' and 'NotConnected'.
     */
    readonly connectionStatus: string;
    /**
     * Gateway connection type. Possible values are: 'IPsec','Vnet2Vnet','ExpressRoute', and 'VPNClient.
     */
    readonly connectionType: string;
    /**
     * The egress bytes transferred in this connection.
     */
    readonly egressBytesTransferred: number;
    /**
     * EnableBgp flag
     */
    readonly enableBgp?: boolean;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: string;
    /**
     * The ingress bytes transferred in this connection.
     */
    readonly ingressBytesTransferred: number;
    /**
     * The IPSec Policies to be considered by this connection.
     */
    readonly ipsecPolicies?: outputs.network.v20171001.IpsecPolicyResponse[];
    /**
     * The reference to local network gateway resource.
     */
    readonly localNetworkGateway2?: outputs.network.v20171001.LocalNetworkGatewayResponse;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The reference to peerings resource.
     */
    readonly peer?: outputs.network.v20171001.SubResourceResponse;
    /**
     * The provisioning state of the VirtualNetworkGatewayConnection resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the VirtualNetworkGatewayConnection resource.
     */
    readonly resourceGuid?: string;
    /**
     * The routing weight.
     */
    readonly routingWeight?: number;
    /**
     * The IPSec shared key.
     */
    readonly sharedKey?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Collection of all tunnels' connection health status.
     */
    readonly tunnelConnectionStatus: outputs.network.v20171001.TunnelConnectionHealthResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * Enable policy-based traffic selectors.
     */
    readonly usePolicyBasedTrafficSelectors?: boolean;
    /**
     * The reference to virtual network gateway resource.
     */
    readonly virtualNetworkGateway1: outputs.network.v20171001.VirtualNetworkGatewayResponse;
    /**
     * The reference to virtual network gateway resource.
     */
    readonly virtualNetworkGateway2?: outputs.network.v20171001.VirtualNetworkGatewayResponse;
}
