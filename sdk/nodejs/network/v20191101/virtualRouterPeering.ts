// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Virtual Router Peering resource.
 */
export class VirtualRouterPeering extends pulumi.CustomResource {
    /**
     * Get an existing VirtualRouterPeering resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualRouterPeering {
        return new VirtualRouterPeering(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-nextgen:network/v20191101:VirtualRouterPeering';

    /**
     * Returns true if the given object is an instance of VirtualRouterPeering.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualRouterPeering {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualRouterPeering.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Name of the virtual router peering that is unique within a virtual router.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Peer ASN.
     */
    public readonly peerAsn!: pulumi.Output<number | undefined>;
    /**
     * Peer IP.
     */
    public readonly peerIp!: pulumi.Output<string | undefined>;
    /**
     * The provisioning state of the resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Peering type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a VirtualRouterPeering resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualRouterPeeringArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (!(opts && opts.id)) {
            if ((!args || args.peeringName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'peeringName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.virtualRouterName === undefined) && !(opts && opts.urn)) {
                throw new Error("Missing required property 'virtualRouterName'");
            }
            inputs["id"] = args ? args.id : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peerAsn"] = args ? args.peerAsn : undefined;
            inputs["peerIp"] = args ? args.peerIp : undefined;
            inputs["peeringName"] = args ? args.peeringName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["virtualRouterName"] = args ? args.virtualRouterName : undefined;
            inputs["etag"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        } else {
            inputs["etag"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["peerAsn"] = undefined /*out*/;
            inputs["peerIp"] = undefined /*out*/;
            inputs["provisioningState"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        const aliasOpts = { aliases: [{ type: "azure-nextgen:network/latest:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20190701:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20190801:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20190901:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20191201:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200301:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200401:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200501:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200601:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200701:VirtualRouterPeering" }, { type: "azure-nextgen:network/v20200801:VirtualRouterPeering" }] };
        opts = opts ? pulumi.mergeOptions(opts, aliasOpts) : aliasOpts;
        super(VirtualRouterPeering.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualRouterPeering resource.
 */
export interface VirtualRouterPeeringArgs {
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Name of the virtual router peering that is unique within a virtual router.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Peer ASN.
     */
    readonly peerAsn?: pulumi.Input<number>;
    /**
     * Peer IP.
     */
    readonly peerIp?: pulumi.Input<string>;
    /**
     * The name of the Virtual Router Peering.
     */
    readonly peeringName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Virtual Router.
     */
    readonly virtualRouterName: pulumi.Input<string>;
}
