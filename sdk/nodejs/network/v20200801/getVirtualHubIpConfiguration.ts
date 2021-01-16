// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getVirtualHubIpConfiguration(args: GetVirtualHubIpConfigurationArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualHubIpConfigurationResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200801:getVirtualHubIpConfiguration", {
        "ipConfigName": args.ipConfigName,
        "resourceGroupName": args.resourceGroupName,
        "virtualHubName": args.virtualHubName,
    }, opts);
}

export interface GetVirtualHubIpConfigurationArgs {
    /**
     * The name of the ipconfig.
     */
    readonly ipConfigName: string;
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
 * IpConfigurations.
 */
export interface GetVirtualHubIpConfigurationResult {
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * Name of the Ip Configuration.
     */
    readonly name?: string;
    /**
     * The private IP address of the IP configuration.
     */
    readonly privateIPAddress?: string;
    /**
     * The private IP address allocation method.
     */
    readonly privateIPAllocationMethod?: string;
    /**
     * The provisioning state of the IP configuration resource.
     */
    readonly provisioningState: string;
    /**
     * The reference to the public IP resource.
     */
    readonly publicIPAddress?: outputs.network.v20200801.PublicIPAddressResponse;
    /**
     * The reference to the subnet resource.
     */
    readonly subnet?: outputs.network.v20200801.SubnetResponse;
    /**
     * Ipconfiguration type.
     */
    readonly type: string;
}
