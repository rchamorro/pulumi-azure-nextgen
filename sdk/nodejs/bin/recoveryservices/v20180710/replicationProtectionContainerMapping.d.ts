import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * Protection container mapping object.
 */
export declare class ReplicationProtectionContainerMapping extends pulumi.CustomResource {
    /**
     * Get an existing ReplicationProtectionContainerMapping resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ReplicationProtectionContainerMapping;
    /**
     * Returns true if the given object is an instance of ReplicationProtectionContainerMapping.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ReplicationProtectionContainerMapping;
    /**
     * Resource Location
     */
    readonly location: pulumi.Output<string | undefined>;
    /**
     * Resource Name
     */
    readonly name: pulumi.Output<string>;
    /**
     * The custom data.
     */
    readonly properties: pulumi.Output<outputs.recoveryservices.v20180710.ProtectionContainerMappingPropertiesResponse>;
    /**
     * Resource Type
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ReplicationProtectionContainerMapping resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReplicationProtectionContainerMappingArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ReplicationProtectionContainerMapping resource.
 */
export interface ReplicationProtectionContainerMappingArgs {
    /**
     * Fabric name.
     */
    readonly fabricName: pulumi.Input<string>;
    /**
     * Protection container mapping name.
     */
    readonly mappingName: pulumi.Input<string>;
    /**
     * Configure protection input properties.
     */
    readonly properties?: pulumi.Input<inputs.recoveryservices.v20180710.CreateProtectionContainerMappingInputProperties>;
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