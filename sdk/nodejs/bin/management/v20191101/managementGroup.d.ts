import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../../types/input";
import * as outputs from "../../types/output";
/**
 * The management group details.
 */
export declare class ManagementGroup extends pulumi.CustomResource {
    /**
     * Get an existing ManagementGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagementGroup;
    /**
     * Returns true if the given object is an instance of ManagementGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ManagementGroup;
    /**
     * The list of children.
     */
    readonly children: pulumi.Output<outputs.management.v20191101.ManagementGroupChildInfoResponse[] | undefined>;
    /**
     * The details of a management group.
     */
    readonly details: pulumi.Output<outputs.management.v20191101.ManagementGroupDetailsResponse | undefined>;
    /**
     * The friendly name of the management group.
     */
    readonly displayName: pulumi.Output<string | undefined>;
    /**
     * The name of the management group. For example, 00000000-0000-0000-0000-000000000000
     */
    readonly name: pulumi.Output<string>;
    /**
     * The hierarchial path from the root group to the current group.
     */
    readonly path: pulumi.Output<outputs.management.v20191101.ManagementGroupPathElementResponse[] | undefined>;
    /**
     * The role definitions associated with the management group.
     */
    readonly roles: pulumi.Output<string[] | undefined>;
    /**
     * The AAD Tenant ID associated with the management group. For example, 00000000-0000-0000-0000-000000000000
     */
    readonly tenantId: pulumi.Output<string | undefined>;
    /**
     * The type of the resource.  For example, Microsoft.Management/managementGroups
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ManagementGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagementGroupArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ManagementGroup resource.
 */
export interface ManagementGroupArgs {
    /**
     * The details of a management group used during creation.
     */
    readonly details?: pulumi.Input<inputs.management.v20191101.CreateManagementGroupDetails>;
    /**
     * The friendly name of the management group. If no value is passed then this  field will be set to the groupId.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * Management Group ID.
     */
    readonly groupId: pulumi.Input<string>;
    /**
     * The name of the management group. For example, 00000000-0000-0000-0000-000000000000
     */
    readonly name?: pulumi.Input<string>;
}