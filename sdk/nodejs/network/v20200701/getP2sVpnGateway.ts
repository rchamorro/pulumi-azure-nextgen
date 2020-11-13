// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getP2sVpnGateway(args: GetP2sVpnGatewayArgs, opts?: pulumi.InvokeOptions): Promise<GetP2sVpnGatewayResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200701:getP2sVpnGateway", {
        "gatewayName": args.gatewayName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

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
     * List of all customer specified DNS servers IP addresses.
     */
    readonly customDnsServers?: string[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Enable Routing Preference property for the Public IP Interface of the P2SVpnGateway.
     */
    readonly isRoutingPreferenceInternet?: boolean;
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
    readonly p2SConnectionConfigurations?: outputs.network.v20200701.P2SConnectionConfigurationResponse[];
    /**
     * The provisioning state of the P2S VPN gateway resource.
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
     * The VirtualHub to which the gateway belongs.
     */
    readonly virtualHub?: outputs.network.v20200701.SubResourceResponse;
    /**
     * All P2S VPN clients' connection health status.
     */
    readonly vpnClientConnectionHealth: outputs.network.v20200701.VpnClientConnectionHealthResponse;
    /**
     * The scale unit for this p2s vpn gateway.
     */
    readonly vpnGatewayScaleUnit?: number;
    /**
     * The VpnServerConfiguration to which the p2sVpnGateway is attached to.
     */
    readonly vpnServerConfiguration?: outputs.network.v20200701.SubResourceResponse;
}
