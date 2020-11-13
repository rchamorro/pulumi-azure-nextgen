// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getP2sVpnGatewayP2sVpnConnectionHealthDetailed(args: GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs, opts?: pulumi.InvokeOptions): Promise<GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getP2sVpnGatewayP2sVpnConnectionHealthDetailed", {
        "gatewayName": args.gatewayName,
        "outputBlobSasUrl": args.outputBlobSasUrl,
        "resourceGroupName": args.resourceGroupName,
        "vpnUserNamesFilter": args.vpnUserNamesFilter,
    }, opts);
}

export interface GetP2sVpnGatewayP2sVpnConnectionHealthDetailedArgs {
    /**
     * The name of the P2SVpnGateway.
     */
    readonly gatewayName: string;
    /**
     * The sas-url to download the P2S Vpn connection health detail.
     */
    readonly outputBlobSasUrl?: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
    /**
     * The list of p2s vpn user names whose p2s vpn connection detailed health to retrieve for.
     */
    readonly vpnUserNamesFilter?: string[];
}

/**
 * P2S Vpn connection detailed health written to sas url.
 */
export interface GetP2sVpnGatewayP2sVpnConnectionHealthDetailedResult {
    /**
     * Returned sas url of the blob to which the p2s vpn connection detailed health will be written.
     */
    readonly sasUrl?: string;
}
