// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getExpressRouteCircuitPeering(args: GetExpressRouteCircuitPeeringArgs, opts?: pulumi.InvokeOptions): Promise<GetExpressRouteCircuitPeeringResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20170301:getExpressRouteCircuitPeering", {
        "circuitName": args.circuitName,
        "peeringName": args.peeringName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExpressRouteCircuitPeeringArgs {
    /**
     * The name of the express route circuit.
     */
    readonly circuitName: string;
    /**
     * The name of the peering.
     */
    readonly peeringName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Peering in an ExpressRouteCircuit resource.
 */
export interface GetExpressRouteCircuitPeeringResult {
    /**
     * The Azure ASN.
     */
    readonly azureASN?: number;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The GatewayManager Etag.
     */
    readonly gatewayManagerEtag?: string;
    /**
     * The IPv6 peering configuration.
     */
    readonly ipv6PeeringConfig?: outputs.network.v20170301.Ipv6ExpressRouteCircuitPeeringConfigResponse;
    /**
     * Gets whether the provider or the customer last modified the peering.
     */
    readonly lastModifiedBy?: string;
    /**
     * The Microsoft peering configuration.
     */
    readonly microsoftPeeringConfig?: outputs.network.v20170301.ExpressRouteCircuitPeeringConfigResponse;
    /**
     * Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: string;
    /**
     * The peer ASN.
     */
    readonly peerASN?: number;
    /**
     * The PeeringType. Possible values are: 'AzurePublicPeering', 'AzurePrivatePeering', and 'MicrosoftPeering'.
     */
    readonly peeringType?: string;
    /**
     * The primary port.
     */
    readonly primaryAzurePort?: string;
    /**
     * The primary address prefix.
     */
    readonly primaryPeerAddressPrefix?: string;
    /**
     * Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: string;
    /**
     * The reference of the RouteFilter resource.
     */
    readonly routeFilter?: outputs.network.v20170301.RouteFilterResponse;
    /**
     * The secondary port.
     */
    readonly secondaryAzurePort?: string;
    /**
     * The secondary address prefix.
     */
    readonly secondaryPeerAddressPrefix?: string;
    /**
     * The shared key.
     */
    readonly sharedKey?: string;
    /**
     * The state of peering. Possible values are: 'Disabled' and 'Enabled'
     */
    readonly state?: string;
    /**
     * Gets peering stats.
     */
    readonly stats?: outputs.network.v20170301.ExpressRouteCircuitStatsResponse;
    /**
     * The VLAN ID.
     */
    readonly vlanId?: number;
}
