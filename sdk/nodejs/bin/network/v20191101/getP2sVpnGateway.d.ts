import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getP2sVpnGateway(args: GetP2sVpnGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetP2sVpnGatewayResult>;
export interface GetP2sVpnGatewayArgs {
    /**
     * The name of the gateway.
     */
    readonly gatewayName: string;
    /**
     * The resource group name of the P2SVpnGateway.
     */
    readonly resourceGroupName: string;
}
/**
 * P2SVpnGateway Resource.
 */
export interface GetP2sVpnGatewayResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * List of all p2s connection configurations of the gateway.
     */
    readonly p2SConnectionConfigurations?: outputs.network.v20191101.P2SConnectionConfigurationResponse[];
    /**
     * The provisioning state of the P2S VPN gateway resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The VirtualHub to which the gateway belongs.
     */
    readonly virtualHub?: outputs.network.v20191101.SubResourceResponse;
    /**
     * All P2S VPN clients' connection health status.
     */
    readonly vpnClientConnectionHealth: outputs.network.v20191101.VpnClientConnectionHealthResponse;
    /**
     * The scale unit for this p2s vpn gateway.
     */
    readonly vpnGatewayScaleUnit?: number;
    /**
     * The VpnServerConfiguration to which the p2sVpnGateway is attached to.
     */
    readonly vpnServerConfiguration?: outputs.network.v20191101.SubResourceResponse;
}