// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualHub(args: GetVirtualHubArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualHubResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getVirtualHub", {
        "resourceGroupName": args.resourceGroupName,
        "virtualHubName": args.virtualHubName,
    }, opts);
}

export interface GetVirtualHubArgs {
    /**
     * The resource group name of the VirtualHub.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VirtualHub.
     */
    readonly virtualHubName: string;
}

/**
 * VirtualHub Resource.
 */
export interface GetVirtualHubResult {
    /**
     * Address-prefix for this VirtualHub.
     */
    readonly addressPrefix?: string;
    /**
     * Flag to control transit for VirtualRouter hub.
     */
    readonly allowBranchToBranchTraffic?: boolean;
    /**
     * The azureFirewall associated with this VirtualHub.
     */
    readonly azureFirewall?: outputs.network.v20200701.SubResourceResponse;
    /**
     * List of references to Bgp Connections.
     */
    readonly bgpConnections: outputs.network.v20200701.SubResourceResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The expressRouteGateway associated with this VirtualHub.
     */
    readonly expressRouteGateway?: outputs.network.v20200701.SubResourceResponse;
    /**
     * List of references to IpConfigurations.
     */
    readonly ipConfigurations: outputs.network.v20200701.SubResourceResponse[];
    /**
     * Resource location.
     */
    readonly location: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The P2SVpnGateway associated with this VirtualHub.
     */
    readonly p2SVpnGateway?: outputs.network.v20200701.SubResourceResponse;
    /**
     * The provisioning state of the virtual hub resource.
     */
    readonly provisioningState: string;
    /**
     * The routeTable associated with this virtual hub.
     */
    readonly routeTable?: outputs.network.v20200701.VirtualHubRouteTableResponse;
    /**
     * The routing state.
     */
    readonly routingState: string;
    /**
     * The securityPartnerProvider associated with this VirtualHub.
     */
    readonly securityPartnerProvider?: outputs.network.v20200701.SubResourceResponse;
    /**
     * The Security Provider name.
     */
    readonly securityProviderName?: string;
    /**
     * The sku of this VirtualHub.
     */
    readonly sku?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * List of all virtual hub route table v2s associated with this VirtualHub.
     */
    readonly virtualHubRouteTableV2s?: outputs.network.v20200701.VirtualHubRouteTableV2Response[];
    /**
     * VirtualRouter ASN.
     */
    readonly virtualRouterAsn?: number;
    /**
     * VirtualRouter IPs.
     */
    readonly virtualRouterIps?: string[];
    /**
     * The VirtualWAN to which the VirtualHub belongs.
     */
    readonly virtualWan?: outputs.network.v20200701.SubResourceResponse;
    /**
     * The VpnGateway associated with this VirtualHub.
     */
    readonly vpnGateway?: outputs.network.v20200701.SubResourceResponse;
}
