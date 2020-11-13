// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getPeeringService(args: GetPeeringServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetPeeringServiceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:peering/v20201001:getPeeringService", {
        "peeringServiceName": args.peeringServiceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetPeeringServiceArgs {
    /**
     * The name of the peering.
     */
    readonly peeringServiceName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * Peering Service
 */
export interface GetPeeringServiceResult {
    /**
     * The location of the resource.
     */
    readonly location: string;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The PeeringServiceLocation of the Customer.
     */
    readonly peeringServiceLocation?: string;
    /**
     * The MAPS Provider Name.
     */
    readonly peeringServiceProvider?: string;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState: string;
    /**
     * The SKU that defines the type of the peering service.
     */
    readonly sku?: outputs.peering.v20201001.PeeringServiceSkuResponse;
    /**
     * The resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}
