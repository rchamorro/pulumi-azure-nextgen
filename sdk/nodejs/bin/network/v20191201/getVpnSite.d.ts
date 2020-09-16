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
    readonly addressSpace?: outputs.network.v20191201.AddressSpaceResponse;
    /**
     * The set of bgp properties.
     */
    readonly bgpProperties?: outputs.network.v20191201.BgpSettingsResponse;
    /**
     * The device properties.
     */
    readonly deviceProperties?: outputs.network.v20191201.DevicePropertiesResponse;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The ip-address for the vpn-site.
     */
    readonly ipAddress?: string;
    /**
     * IsSecuritySite flag.
     */
    readonly isSecuritySite?: boolean;
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The provisioning state of the VPN site resource.
     */
    readonly provisioningState: string;
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
     * The VirtualWAN to which the vpnSite belongs.
     */
    readonly virtualWan?: outputs.network.v20191201.SubResourceResponse;
    /**
     * List of all vpn site links.
     */
    readonly vpnSiteLinks?: outputs.network.v20191201.VpnSiteLinkResponse[];
}