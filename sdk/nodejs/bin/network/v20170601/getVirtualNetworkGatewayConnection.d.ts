import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVirtualNetworkGatewayConnection(args: GetVirtualNetworkGatewayConnectionArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayConnectionResult>;
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
    readonly ipsecPolicies?: outputs.network.v20170601.IpsecPolicyResponse[];
    /**
     * The reference to local network gateway resource.
     */
    readonly localNetworkGateway2?: outputs.network.v20170601.LocalNetworkGatewayResponse;
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
    readonly peer?: outputs.network.v20170601.SubResourceResponse;
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
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Collection of all tunnels' connection health status.
     */
    readonly tunnelConnectionStatus: outputs.network.v20170601.TunnelConnectionHealthResponse[];
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
    readonly virtualNetworkGateway1: outputs.network.v20170601.VirtualNetworkGatewayResponse;
    /**
     * The reference to virtual network gateway resource.
     */
    readonly virtualNetworkGateway2?: outputs.network.v20170601.VirtualNetworkGatewayResponse;
}