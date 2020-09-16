import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
/**
 * The details of subscription under management group.
 */
export declare class ManagementGroupSubscriptionSubscription extends pulumi.CustomResource {
    /**
     * Get an existing ManagementGroupSubscriptionSubscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagementGroupSubscriptionSubscription;
    /**
     * Returns true if the given object is an instance of ManagementGroupSubscriptionSubscription.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ManagementGroupSubscriptionSubscription;
    /**
     * The friendly name of the subscription.
     */
    readonly displayName: pulumi.Output<string | undefined>;
    /**
     * The stringified id of the subscription. For example, 00000000-0000-0000-0000-000000000000
     */
    readonly name: pulumi.Output<string>;
    /**
     * The ID of the parent management group.
     */
    readonly parent: pulumi.Output<outputs.management.v20200501.DescendantParentGroupInfoResponse | undefined>;
    /**
     * The state of the subscription.
     */
    readonly state: pulumi.Output<string | undefined>;
    /**
     * The AAD Tenant ID associated with the subscription. For example, 00000000-0000-0000-0000-000000000000
     */
    readonly tenant: pulumi.Output<string | undefined>;
    /**
     * The type of the resource.  For example, Microsoft.Management/managementGroups/subscriptions
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ManagementGroupSubscriptionSubscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagementGroupSubscriptionSubscriptionArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ManagementGroupSubscriptionSubscription resource.
 */
export interface ManagementGroupSubscriptionSubscriptionArgs {
    /**
     * Management Group ID.
     */
    readonly groupId: pulumi.Input<string>;
}