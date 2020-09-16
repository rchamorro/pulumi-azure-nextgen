import * as pulumi from "@pulumi/pulumi";
/**
 * Trigger details.
 */
export declare class Trigger extends pulumi.CustomResource {
    /**
     * Get an existing Trigger resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Trigger;
    /**
     * Returns true if the given object is an instance of Trigger.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Trigger;
    /**
     * Trigger Kind.
     */
    readonly kind: pulumi.Output<string>;
    /**
     * The object name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * The hierarchical type of the object.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a Trigger resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TriggerArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Trigger resource.
 */
export interface TriggerArgs {
    /**
     * Creates or updates a trigger
     */
    readonly deviceName: pulumi.Input<string>;
    /**
     * Trigger Kind.
     */
    readonly kind: pulumi.Input<string>;
    /**
     * The trigger name.
     */
    readonly name: pulumi.Input<string>;
    /**
     * The resource group name.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}