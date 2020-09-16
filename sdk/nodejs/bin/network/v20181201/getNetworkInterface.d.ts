import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getNetworkInterface(args: GetNetworkInterfaceArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkInterfaceResult>;
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
    readonly dnsSettings?: outputs.network.v20181201.NetworkInterfaceDnsSettingsResponse;
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
    readonly etag?: string;
    /**
     * A list of references to linked BareMetal resources
     */
    readonly hostedWorkloads: string[];
    /**
     * A reference to the interface endpoint to which the network interface is linked.
     */
    readonly interfaceEndpoint: outputs.network.v20181201.InterfaceEndpointResponse;
    /**
     * A list of IPConfigurations of the network interface.
     */
    readonly ipConfigurations?: outputs.network.v20181201.NetworkInterfaceIPConfigurationResponse[];
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The MAC address of the network interface.
     */
    readonly macAddress?: string;
    /**
     * Resource name.
     */
    readonly name: string;
    /**
     * The reference of the NetworkSecurityGroup resource.
     */
    readonly networkSecurityGroup?: outputs.network.v20181201.NetworkSecurityGroupResponse;
    /**
     * Gets whether this is a primary network interface on a virtual machine.
     */
    readonly primary?: boolean;
    /**
     * The provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    readonly provisioningState?: string;
    /**
     * The resource GUID property of the network interface resource.
     */
    readonly resourceGuid?: string;
    /**
     * Resource tags.
     */
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * A list of TapConfigurations of the network interface.
     */
    readonly tapConfigurations?: outputs.network.v20181201.NetworkInterfaceTapConfigurationResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The reference of a virtual machine.
     */
    readonly virtualMachine: outputs.network.v20181201.SubResourceResponse;
}