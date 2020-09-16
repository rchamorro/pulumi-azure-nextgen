import * as pulumi from "@pulumi/pulumi";
/**
 * The privateStore offer data structure.
 */
export declare class PrivateStoreOffer extends pulumi.CustomResource {
    /**
     * Get an existing PrivateStoreOffer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PrivateStoreOffer;
    /**
     * Returns true if the given object is an instance of PrivateStoreOffer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is PrivateStoreOffer;
    /**
     * Private store offer creator name
     */
    readonly createdBy: pulumi.Output<string>;
    /**
     * Private store offer created date
     */
    readonly createdDate: pulumi.Output<string>;
    /**
     * Identifier for purposes of race condition
     */
    readonly eTag: pulumi.Output<string | undefined>;
    /**
     * The name of the resource.
     */
    readonly name: pulumi.Output<string>;
    /**
     * It will be displayed prominently in the marketplace
     */
    readonly offerDisplayName: pulumi.Output<string>;
    /**
     * Private store unique id
     */
    readonly privateStoreId: pulumi.Output<string>;
    /**
     * Publisher name that will be displayed prominently in the marketplace
     */
    readonly publisherDisplayName: pulumi.Output<string>;
    /**
     * Plan ids limitation for this offer
     */
    readonly specificPlanIdsLimitation: pulumi.Output<string[] | undefined>;
    /**
     * The type of the resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Offers unique id
     */
    readonly uniqueOfferId: pulumi.Output<string>;
    /**
     * Create a PrivateStoreOffer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PrivateStoreOfferArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a PrivateStoreOffer resource.
 */
export interface PrivateStoreOfferArgs {
    /**
     * Identifier for purposes of race condition
     */
    readonly eTag?: pulumi.Input<string>;
    /**
     * The offer ID to update or delete
     */
    readonly offerId: pulumi.Input<string>;
    /**
     * The store ID - must use the tenant ID
     */
    readonly privateStoreId: pulumi.Input<string>;
    /**
     * Plan ids limitation for this offer
     */
    readonly specificPlanIdsLimitation?: pulumi.Input<pulumi.Input<string>[]>;
}