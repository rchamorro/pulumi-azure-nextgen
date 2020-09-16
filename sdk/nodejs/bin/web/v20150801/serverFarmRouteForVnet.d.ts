import * as pulumi from "@pulumi/pulumi";
/**
 * VnetRoute contract used to pass routing information for a vnet.
 */
export declare class ServerFarmRouteForVnet extends pulumi.CustomResource {
    /**
     * Get an existing ServerFarmRouteForVnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServerFarmRouteForVnet;
    /**
     * Returns true if the given object is an instance of ServerFarmRouteForVnet.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ServerFarmRouteForVnet;
    /**
     * The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
     */
    readonly endAddress: pulumi.Output<string | undefined>;
    /**
     * Kind of resource
     */
    readonly kind: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Output<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Output<string | undefined>;
    /**
     * The type of route this is:
     *             DEFAULT - By default, every web app has routes to the local address ranges specified by RFC1918
     *             INHERITED - Routes inherited from the real Virtual Network routes
     *             STATIC - Static route set on the web app only
     *
     *             These values will be used for syncing a Web App's routes with those from a Virtual Network. This operation will clear all DEFAULT and INHERITED routes and replace them
     *             with new INHERITED routes.
     */
    readonly routeType: pulumi.Output<string | undefined>;
    /**
     * The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
     */
    readonly startAddress: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    readonly tags: pulumi.Output<{
        [key: string]: string;
    } | undefined>;
    /**
     * Resource type
     */
    readonly type: pulumi.Output<string | undefined>;
    /**
     * Create a ServerFarmRouteForVnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerFarmRouteForVnetArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ServerFarmRouteForVnet resource.
 */
export interface ServerFarmRouteForVnetArgs {
    /**
     * The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
     */
    readonly endAddress?: pulumi.Input<string>;
    /**
     * Resource Id
     */
    readonly id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    readonly kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    readonly location: pulumi.Input<string>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the virtual network route
     */
    readonly routeName: pulumi.Input<string>;
    /**
     * The type of route this is:
     *             DEFAULT - By default, every web app has routes to the local address ranges specified by RFC1918
     *             INHERITED - Routes inherited from the real Virtual Network routes
     *             STATIC - Static route set on the web app only
     *
     *             These values will be used for syncing a Web App's routes with those from a Virtual Network. This operation will clear all DEFAULT and INHERITED routes and replace them
     *             with new INHERITED routes.
     */
    readonly routeType?: pulumi.Input<string>;
    /**
     * The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
     */
    readonly startAddress?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    readonly tags?: pulumi.Input<{
        [key: string]: pulumi.Input<string>;
    }>;
    /**
     * Resource type
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Name of virtual network
     */
    readonly vnetName: pulumi.Input<string>;
}