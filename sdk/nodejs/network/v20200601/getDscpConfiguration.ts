// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getDscpConfiguration(args: GetDscpConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetDscpConfigurationResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200601:getDscpConfiguration", {
        "dscpConfigurationName": args.dscpConfigurationName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDscpConfigurationArgs {
    /**
     * The name of the resource.
     */
    readonly dscpConfigurationName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * DSCP Configuration in a resource group.
 */
export interface GetDscpConfigurationResult {
    /**
     * Associated Network Interfaces to the DSCP Configuration.
     */
    readonly associatedNetworkInterfaces: outputs.network.v20200601.NetworkInterfaceResponse[];
    /**
     * Destination IP ranges.
     */
    readonly destinationIpRanges?: outputs.network.v20200601.QosIpRangeResponse[];
    /**
     * Destination port ranges.
     */
    readonly destinationPortRanges?: outputs.network.v20200601.QosPortRangeResponse[];
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * List of markings to be used in the configuration.
     */
    readonly markings?: number[];
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * RNM supported protocol types.
     */
    readonly protocol?: string;
    /**
     * The provisioning state of the DSCP Configuration resource.
     */
    readonly provisioningState: string;
    /**
     * Qos Collection ID generated by RNM.
     */
    readonly qosCollectionId: string;
    /**
     * The resource GUID property of the DSCP Configuration resource.
     */
    readonly resourceGuid: string;
    /**
     * Source IP ranges.
     */
    readonly sourceIpRanges?: outputs.network.v20200601.QosIpRangeResponse[];
    /**
     * Sources port ranges.
     */
    readonly sourcePortRanges?: outputs.network.v20200601.QosPortRangeResponse[];
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type.
     */
    readonly type: string;
}
