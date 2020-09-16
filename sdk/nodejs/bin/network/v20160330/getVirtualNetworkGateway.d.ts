import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVirtualNetworkGateway(args: GetVirtualNetworkGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayResult>;
export interface GetVirtualNetworkGatewayArgs {
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
 * A common class for general resource information
 */
export interface GetVirtualNetworkGatewayResult {
    /**
     * Virtual network gateway's BGP speaker settings
     */
    readonly bgpSettings?: outputs.network.v20160330.BgpSettingsResponse;
    /**
     * EnableBgp Flag
     */
    readonly enableBgp?: boolean;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    readonly etag?: string;
    /**
     * Gets or sets the reference of the LocalNetworkGateway resource which represents Local network site having default routes. Assign Null value in case of removing existing default site setting.
     */
    readonly gatewayDefaultSite?: outputs.network.v20160330.SubResourceResponse;
    /**
     * The type of this virtual network gateway.
     */
    readonly gatewayType?: string;
    /**
     * IpConfigurations for Virtual network gateway.
     */
    readonly ipConfigurations?: outputs.network.v20160330.VirtualNetworkGatewayIPConfigurationResponse[];
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Gets or sets Provisioning state of the VirtualNetworkGateway resource Updating/Deleting/Failed
     */
    readonly provisioningState?: string;
    /**
     * Gets or sets resource GUID property of the VirtualNetworkGateway resource
     */
    readonly resourceGuid?: string;
    /**
     * Gets or sets the reference of the VirtualNetworkGatewaySku resource which represents the sku selected for Virtual network gateway.
     */
    readonly sku?: outputs.network.v20160330.VirtualNetworkGatewaySkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * Gets or sets the reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
     */
    readonly vpnClientConfiguration?: outputs.network.v20160330.VpnClientConfigurationResponse;
    /**
     * The type of this virtual network gateway.
     */
    readonly vpnType?: string;
}