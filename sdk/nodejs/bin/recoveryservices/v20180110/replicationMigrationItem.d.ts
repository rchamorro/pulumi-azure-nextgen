import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Migration item.
 */
export declare class ReplicationMigrationItem extends pulumi.CustomResource {
    /**
     * Get an existing ReplicationMigrationItem resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ReplicationMigrationItem;
    /**
     * Returns true if the given object is an instance of ReplicationMigrationItem.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ReplicationMigrationItem;
    /**
     * Resource Location
     */
    readonly location: pulumi.Output<string | undefined>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Output<string>;
    /**
     * The migration item properties.
     */
    readonly properties: pulumi.Output<outputs.recoveryservices.v20180110.MigrationItemPropertiesResponse>;
    /**
     * Resource Type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ReplicationMigrationItem resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReplicationMigrationItemArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ReplicationMigrationItem resource.
 */
export interface ReplicationMigrationItemArgs {
    /**
     * Fabric name.
     */
    readonly fabricName: pulumi.Input<string>;
    /**
     * Migration item name.
     */
    readonly migrationItemName: pulumi.Input<string>;
    /**
     * Enable migration input properties.
     */
    readonly properties: pulumi.Input<inputs.recoveryservices.v20180110.EnableMigrationInputProperties>;
    /**
     * Protection container name.
     */
    readonly protectionContainerName: pulumi.Input<string>;
    /**
     * The name of the resource group where the recovery services vault is present.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the recovery services vault.
     */
    readonly resourceName: pulumi.Input<string>;
}