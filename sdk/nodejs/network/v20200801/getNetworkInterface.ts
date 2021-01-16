// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

export function getNetworkInterface(args: GetNetworkInterfaceArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkInterfaceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:network/v20200801:getNetworkInterface", {
        "expand": args.expand,
        "networkInterfaceName": args.networkInterfaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetNetworkInterfaceArgs {
    /**
     * Expands referenced resources.
     */
    readonly expand?: string;
    /**
     * The name of the network interface.
     */
    readonly networkInterfaceName: string;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: string;
}

/**
 * A network interface in a resource group.
 */
export interface GetNetworkInterfaceResult {
    /**
     * The DNS settings in network interface.
     */
    readonly dnsSettings?: outputs.network.v20200801.NetworkInterfaceDnsSettingsResponse;
    /**
     * A reference to the dscp configuration to which the network interface is linked.
     */
    readonly dscpConfiguration: outputs.network.v20200801.SubResourceResponse;
    /**
     * If the network interface is accelerated networking enabled.
     */
    readonly enableAcceleratedNetworking?: boolean;
    /**
     * Indicates whether IP forwarding is enabled on this network interface.
     */
    readonly enableIPForwarding?: boolean;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: string;
    /**
     * The extended location of the network interface.
     */
    readonly extendedLocation?: outputs.network.v20200801.ExtendedLocationResponse;
    /**
     * A list of references to linked BareMetal resources.
     */
    readonly hostedWorkloads: string[];
    /**
     * Resource ID.
     */
    readonly id?: string;
    /**
     * A list of IPConfigurations of the network interface.
     */
    readonly ipConfigurations?: outputs.network.v20200801.NetworkInterfaceIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The MAC address of the network interface.
     */
    readonly macAddress: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The reference to the NetworkSecurityGroup resource.
     */
    readonly networkSecurityGroup?: outputs.network.v20200801.NetworkSecurityGroupResponse;
    /**
     * Whether this is a primary network interface on a virtual machine.
     */
    readonly primary: boolean;
    /**
     * A reference to the private endpoint to which the network interface is linked.
     */
    readonly privateEndpoint: outputs.network.v20200801.PrivateEndpointResponse;
    /**
     * The provisioning state of the network interface resource.
     */
    readonly provisioningState: string;
    /**
     * The resource GUID property of the network interface resource.
     */
    readonly resourceGuid: string;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * A list of TapConfigurations of the network interface.
     */
    readonly tapConfigurations: outputs.network.v20200801.NetworkInterfaceTapConfigurationResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The reference to a virtual machine.
     */
    readonly virtualMachine: outputs.network.v20200801.SubResourceResponse;
}
