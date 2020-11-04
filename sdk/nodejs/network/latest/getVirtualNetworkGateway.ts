// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualNetworkGateway(args: GetVirtualNetworkGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkGatewayResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/latest:getVirtualNetworkGateway", {
        "resourceGroupName": args.resourceGroupName,
        "virtualNetworkGatewayName": args.virtualNetworkGatewayName,
    }, opts);
}

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
 * A common class for general resource information.
 */
export interface GetVirtualNetworkGatewayResult {
    /**
     * ActiveActive flag.
     */
    readonly activeActive?: boolean;
    /**
     * Virtual network gateway's BGP speaker settings.
     */
    readonly bgpSettings?: outputs.network.latest.BgpSettingsResponse;
    /**
     * The reference to the address space resource which represents the custom routes address space specified by the customer for virtual network gateway and VpnClient.
     */
    readonly customRoutes?: outputs.network.latest.AddressSpaceResponse;
    /**
     * Whether BGP is enabled for this virtual network gateway or not.
     */
    readonly enableBgp?: boolean;
    /**
     * Whether dns forwarding is enabled or not.
     */
    readonly enableDnsForwarding?: boolean;
    /**
     * Whether private IP needs to be enabled on this gateway for connections or not.
     */
    readonly enablePrivateIpAddress?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The extended location of type local virtual network gateway.
     */
    readonly extendedLocation?: outputs.network.latest.ExtendedLocationResponse;
    /**
     * The reference to the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
     */
    readonly gatewayDefaultSite?: outputs.network.latest.SubResourceResponse;
    /**
     * The type of this virtual network gateway.
     */
    readonly gatewayType?: string;
    /**
     * The IP address allocated by the gateway to which dns requests can be sent.
     */
    readonly inboundDnsForwardingEndpoint: string;
    /**
     * IP configurations for virtual network gateway.
     */
    readonly ipConfigurations?: outputs.network.latest.VirtualNetworkGatewayIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the virtual network gateway resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the virtual network gateway resource.
     */
    readonly resourceGuid: string;
    /**
     * The reference to the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
     */
    readonly sku?: outputs.network.latest.VirtualNetworkGatewaySkuResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * MAS FIJI customer vnet resource id. VirtualNetworkGateway of type local gateway is associated with the customer vnet.
     */
    readonly virtualNetworkExtendedLocationResourceId?: string;
    /**
     * The reference to the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
     */
    readonly vpnClientConfiguration?: outputs.network.latest.VpnClientConfigurationResponse;
    /**
     * The generation for this VirtualNetworkGateway. Must be None if gatewayType is not VPN.
     */
    readonly vpnGatewayGeneration?: string;
    /**
     * The type of this virtual network gateway.
     */
    readonly vpnType?: string;
}
