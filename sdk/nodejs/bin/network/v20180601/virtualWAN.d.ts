import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
/**
 * VirtualWAN Resource.
 */
export declare class VirtualWAN extends pulumi.CustomResource {
    /**
     * Get an existing VirtualWAN resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualWAN;
    /**
     * Returns true if the given object is an instance of VirtualWAN.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is VirtualWAN;
    /**
     * Vpn encryption to be disabled or not.
     */
    readonly disableVpnEncryption: pulumi.Output<boolean | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated.
     */
    readonly etag: pulumi.Output<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Output<string>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type.
     */
    readonly type: pulumi.Output<string>;
    /**
     * List of VirtualHubs in the VirtualWAN.
     */
    readonly virtualHubs: pulumi.Output<outputs.network.v20180601.SubResourceResponse[]>;
    readonly vpnSites: pulumi.Output<outputs.network.v20180601.SubResourceResponse[]>;
    /**
     * Create a VirtualWAN resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualWANArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a VirtualWAN resource.
 */
export interface VirtualWANArgs {
    /**
     * Vpn encryption to be disabled or not.
     */
    readonly disableVpnEncryption?: pulumi.Input<boolean>;
    /**
     * Resource ID.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    readonly location: pulumi.Input<string>;
    /**
     * The provisioning state of the resource.
     */
    readonly provisioningState?: pulumi.Input<string>;
    /**
     * The resource group name of the VirtualWan.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * The name of the VirtualWAN being created or updated.
     */
    readonly virtualWANName: pulumi.Input<string>;
}