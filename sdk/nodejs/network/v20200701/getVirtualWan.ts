// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

export function getVirtualWan(args: GetVirtualWanArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualWanResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getVirtualWan", {
        "resourceGroupName": args.resourceGroupName,
        "virtualWANName": args.virtualWANName,
    }, opts);
}

export interface GetVirtualWanArgs {
    /**
     * The resource group name of the VirtualWan.
     */
    readonly resourceGroupName: string;
    /**
     * The name of the VirtualWAN being retrieved.
     */
    readonly virtualWANName: string;
}

/**
 * VirtualWAN Resource.
 */
export interface GetVirtualWanResult {
    /**
     * True if branch to branch traffic is allowed.
     */
    readonly allowBranchToBranchTraffic?: boolean;
    /**
     * True if Vnet to Vnet traffic is allowed.
     */
    readonly allowVnetToVnetTraffic?: boolean;
    /**
     * Vpn encryption to be disabled or not.
     */
    readonly disableVpnEncryption?: boolean;
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
     * The office local breakout category.
     */
    readonly office365LocalBreakoutCategory: string;
    /**
     * The provisioning state of the virtual WAN resource.
     */
    readonly provisioningState: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * List of VirtualHubs in the VirtualWAN.
     */
    readonly virtualHubs: outputs.network.v20200701.SubResourceResponse[];
    /**
     * List of VpnSites in the VirtualWAN.
     */
    readonly vpnSites: outputs.network.v20200701.SubResourceResponse[];
}
