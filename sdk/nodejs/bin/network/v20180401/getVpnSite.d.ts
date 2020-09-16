import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getVpnSite(args: GetVpnSiteArgs, opts?: pulumi.InvokeOptions): Promise<GetVpnSiteResult>;
export interface GetVpnSiteArgs {
    /**
     * The resource group name of the VpnSite.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VpnSite being retrieved.
     */
    readonly vpnSiteName: string;
}
/**
 * VpnSite Resource.
 */
export interface GetVpnSiteResult {
    /**
     * The AddressSpace that contains an array of IP address ranges.
     */
    readonly addressSpace?: outputs.network.v20180401.AddressSpaceResponse;
    /**
     * The set of bgp properties.
     */
    readonly bgpProperties?: outputs.network.v20180401.BgpSettingsResponse;
    /**
     * The device properties
     */
    readonly deviceProperties?: outputs.network.v20180401.DevicePropertiesResponse;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The ip-address for the vpn-site.
     */
    readonly ipAddress?: string;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState?: string;
    /**
     * The key for vpn-site that can be used for connections.
     */
    readonly siteKey?: string;
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
     * The VirtualWAN to which the vpnSite belongs
     */
    readonly virtualWAN?: outputs.network.v20180401.SubResourceResponse;
}