// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
import * as utilities from "../../utilities";

/**
 * Peerings in a virtual network resource.
 */
export class VirtualNetworkPeering extends pulumi.CustomResource {
    /**
     * Get an existing VirtualNetworkPeering resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualNetworkPeering {
        return new VirtualNetworkPeering(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20170901:VirtualNetworkPeering';

    /**
     * Returns true if the given object is an instance of VirtualNetworkPeering.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualNetworkPeering {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualNetworkPeering.__pulumiType;
    }

    /**
     * Whether the forwarded traffic from the VMs in the remote virtual network will be allowed/disallowed.
     */
    public readonly allowForwardedTraffic!: pulumi.Output<boolean | undefined>;
    /**
     * If gateway links can be used in remote virtual networking to link to this virtual network.
     */
    public readonly allowGatewayTransit!: pulumi.Output<boolean | undefined>;
    /**
     * Whether the VMs in the linked virtual network space would be able to access all the VMs in local Virtual network space.
     */
    public readonly allowVirtualNetworkAccess!: pulumi.Output<boolean | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public readonly etag!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The status of the virtual network peering. Possible values are 'Initiated', 'Connected', and 'Disconnected'.
     */
    public readonly peeringState!: pulumi.Output<string | undefined>;
    /**
     * The provisioning state of the resource.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * The reference of the remote virtual network address space.
     */
    public readonly remoteAddressSpace!: pulumi.Output<outputs.network.v20170901.AddressSpaceResponse | undefined>;
    /**
     * The reference of the remote virtual network. The remote virtual network can be in the same or different region (preview). See here to register for the preview and learn more (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
     */
    public readonly remoteVirtualNetwork!: pulumi.Output<outputs.network.v20170901.SubResourceResponse | undefined>;
    /**
     * If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
     */
    public readonly useRemoteGateways!: pulumi.Output<boolean | undefined>;

    /**
     * Create a VirtualNetworkPeering resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualNetworkPeeringArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.virtualNetworkName === undefined) {
                throw new Error("Missing required property 'virtualNetworkName'");
            }
            if (!args || args.virtualNetworkPeeringName === undefined) {
                throw new Error("Missing required property 'virtualNetworkPeeringName'");
            }
            inputs["allowForwardedTraffic"] = args ? args.allowForwardedTraffic : undefined;
            inputs["allowGatewayTransit"] = args ? args.allowGatewayTransit : undefined;
            inputs["allowVirtualNetworkAccess"] = args ? args.allowVirtualNetworkAccess : undefined;
            inputs["etag"] = args ? args.etag : undefined;
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peeringState"] = args ? args.peeringState : undefined;
            inputs["provisioningState"] = args ? args.provisioningState : undefined;
            inputs["remoteAddressSpace"] = args ? args.remoteAddressSpace : undefined;
            inputs["remoteVirtualNetwork"] = args ? args.remoteVirtualNetwork : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["useRemoteGateways"] = args ? args.useRemoteGateways : undefined;
            inputs["virtualNetworkName"] = args ? args.virtualNetworkName : undefined;
            inputs["virtualNetworkPeeringName"] = args ? args.virtualNetworkPeeringName : undefined;
        } else {
            inputs["allowForwardedTraffic"] = undefined /*out*/;
            inputs["allowGatewayTransit"] = undefined /*out*/;
            inputs["allowVirtualNetworkAccess"] = undefined /*out*/;
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peeringState"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["remoteAddressSpace"] = undefined /*out*/;
            inputs["remoteVirtualNetwork"] = undefined /*out*/;
            inputs["useRemoteGateways"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20160601:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20160901:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20161201:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20170301:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20170601:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20170801:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20171001:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20171101:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180101:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180201:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180401:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180601:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180701:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20180801:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20181001:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20181101:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20181201:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190201:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190401:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190601:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190701:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190801:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20190901:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20191101:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20191201:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20200301:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20200401:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20200501:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20200601:VirtualNetworkPeering" }, { type: "azure-nextgen:network/v20200701:VirtualNetworkPeering" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualNetworkPeering.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualNetworkPeering resource.
 */
export interface VirtualNetworkPeeringArgs {
    /**
     * Whether the forwarded traffic from the VMs in the remote virtual network will be allowed/disallowed.
     */
    readonly allowForwardedTraffic?: pulumi.Input<boolean>;
    /**
     * If gateway links can be used in remote virtual networking to link to this virtual network.
     */
    readonly allowGatewayTransit?: pulumi.Input<boolean>;
    /**
     * Whether the VMs in the linked virtual network space would be able to access all the VMs in local Virtual network space.
     */
    readonly allowVirtualNetworkAccess?: pulumi.Input<boolean>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The name of the resource that is unique within a resource group. This name can be used to access the resource.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The status of the virtual network peering. Possible values are 'Initiated', 'Connected', and 'Disconnected'.
     */
    readonly peeringState?: pulumi.Input<string>;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The reference of the remote virtual network address space.
     */
    readonly remoteAddressSpace?: pulumi.Input<inputs.network.v20170901.AddressSpace>;
    /**
     * The reference of the remote virtual network. The remote virtual network can be in the same or different region (preview). See here to register for the preview and learn more (https://docs.microsoft.com/en-us/azure/virtual-network/virtual-network-create-peering).
     */
    readonly remoteVirtualNetwork?: pulumi.Input<inputs.network.v20170901.SubResource>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * If remote gateways can be used on this virtual network. If the flag is set to true, and allowGatewayTransit on remote peering is also true, virtual network will use gateways of remote virtual network for transit. Only one peering can have this flag set to true. This flag cannot be set if virtual network already has a gateway.
     */
    readonly useRemoteGateways?: pulumi.Input<boolean>;
    /**
     * The name of the virtual network.
     */
    readonly virtualNetworkName: pulumi.Input<string>;
    /**
     * The name of the peering.
     */
    readonly virtualNetworkPeeringName: pulumi.Input<string>;
}
