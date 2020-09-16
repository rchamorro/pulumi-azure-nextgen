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
    readonly dnsSettings?: outputs.network.v20200601.NetworkInterfaceDnsSettingsResponse;
    /**
     * A reference to the dscp configuration to which the network interface is linked.
     */
    readonly dscpConfiguration: outputs.network.v20200601.SubResourceResponse;
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
     * A list of references to linked BareMetal resources.
     */
    readonly hostedWorkloads: string[];
    /**
     * A list of IPConfigurations of the network interface.
     */
    readonly ipConfigurations?: outputs.network.v20200601.NetworkInterfaceIPConfigurationResponse[];
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
    readonly networkSecurityGroup?: outputs.network.v20200601.NetworkSecurityGroupResponse;
    /**
     * Whether this is a primary network interface on a virtual machine.
     */
    readonly primary: boolean;
    /**
     * A reference to the private endpoint to which the network interface is linked.
     */
    readonly privateEndpoint: outputs.network.v20200601.PrivateEndpointResponse;
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
    readonly tags?: {
        [key: string]: string;
    };
    /**
     * A list of TapConfigurations of the network interface.
     */
    readonly tapConfigurations: outputs.network.v20200601.NetworkInterfaceTapConfigurationResponse[];
    /**
     * Resource type.
     */
    readonly type: string;
    /**
     * The reference to a virtual machine.
     */
    readonly virtualMachine: outputs.network.v20200601.SubResourceResponse;
}