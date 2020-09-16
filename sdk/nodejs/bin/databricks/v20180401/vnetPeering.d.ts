import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Peerings in a VirtualNetwork resource
 */
export declare class VNetPeering extends pulumi.CustomResource {
    /**
     * Get an existing VNetPeering resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VNetPeering;
    /**
     * Returns true if the given object is an instance of VNetPeering.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is VNetPeering;
    /**
     * Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network.
     */
    readonly allowForwardedTraffic: pulumi.Output<boolean | undefined>;
    /**
     * If gateway links can be used in remote virtual networking to link to this virtual network.
     */
    readonly allowGatewayTransit: pulumi.Output<boolean | undefined>;
    /**
     * Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space.
     */
    readonly allowVirtualNetworkAccess: pulumi.Output<boolean | undefined>;
    /**
     * The reference to the databricks virtual network address space.
     */
    readonly databricksAddressSpace: pulumi.Output<outputs.databricks.v20180401.AddressSpaceResponse | undefined>;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly databricksVirtualNetwork: pulumi.Output<outputs.databricks.v20180401.VirtualNetworkPeeringPropertiesFormatResponseDatabricksVirtualNetwork | undefined>;
    /**
     * Name of the virtual network peering resource
     */
    readonly name: pulumi.Output<string>;
    /**
     * The status of the virtual network peering.
     */
    readonly peeringState: pulumi.Output<string>;
    /**
     * The provisioning state of the virtual network peering resource.
     */
    readonly provisioningState: pulumi.Output<string>;
    /**
     * The reference to the remote virtual network address space.
     */
    readonly remoteAddressSpace: pulumi.Output<outputs.databricks.v20180401.AddressSpaceResponse | undefined>;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly remoteVirtualNetwork: pulumi.Output<outputs.databricks.v20180401.VirtualNetworkPeeringPropertiesFormatResponseRemoteVirtualNetwork>;
    /**
     * type of the virtual network peering resource
     */
    readonly type: pulumi.Output<string>;
    /**
     * If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
     */
    readonly useRemoteGateways: pulumi.Output<boolean | undefined>;
    /**
     * Create a VNetPeering resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VNetPeeringArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a VNetPeering resource.
 */
export interface VNetPeeringArgs {
    /**
     * Whether the forwarded traffic from the VMs in the local virtual network will be allowed/disallowed in remote virtual network.
     */
    readonly allowForwardedTraffic?: pulumi.Input<boolean>;
    /**
     * If gateway links can be used in remote virtual networking to link to this virtual network.
     */
    readonly allowGatewayTransit?: pulumi.Input<boolean>;
    /**
     * Whether the VMs in the local virtual network space would be able to access the VMs in remote virtual network space.
     */
    readonly allowVirtualNetworkAccess?: pulumi.Input<boolean>;
    /**
     * The reference to the databricks virtual network address space.
     */
    readonly databricksAddressSpace?: pulumi.Input<inputs.databricks.v20180401.AddressSpace>;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly databricksVirtualNetwork?: pulumi.Input<inputs.databricks.v20180401.VirtualNetworkPeeringPropertiesFormatDatabricksVirtualNetwork>;
    /**
     * The name of the workspace vNet peering.
     */
    readonly peeringName: pulumi.Input<string>;
    /**
     * The reference to the remote virtual network address space.
     */
    readonly remoteAddressSpace?: pulumi.Input<inputs.databricks.v20180401.AddressSpace>;
    /**
     *  The remote virtual network should be in the same region. See here to learn more (https://docs.microsoft.com/en-us/azure/databricks/administration-guide/cloud-configurations/azure/vnet-peering).
     */
    readonly remoteVirtualNetwork: pulumi.Input<inputs.databricks.v20180401.VirtualNetworkPeeringPropertiesFormatRemoteVirtualNetwork>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
     */
    readonly useRemoteGateways?: pulumi.Input<boolean>;
    /**
     * The name of the workspace.
     */
    readonly workspaceName: pulumi.Input<string>;
}