import * as pulumi from "@pulumi/pulumi";
/**
 * Policy Contract details.
 */
export declare class ApiPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ApiPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApiPolicy;
    /**
     * Returns true if the given object is an instance of ApiPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ApiPolicy;
    /**
     * Format of the policyContent.
     */
    readonly contentFormat: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * Json escaped Xml Encoded contents of the Policy.
     */
    readonly policyContent: pulumi.Output<string>;
    /**
     * Resource type for API Management resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a ApiPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiPolicyArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ApiPolicy resource.
 */
export interface ApiPolicyArgs {
    /**
     * API revision identifier. Must be unique in the current API Management service instance. Non-current revision has ;rev=n as a suffix where n is the revision number.
     */
    readonly apiId: pulumi.Input<string>;
    /**
     * Format of the policyContent.
     */
    readonly contentFormat?: pulumi.Input<string>;
    /**
     * Json escaped Xml Encoded contents of the Policy.
     */
    readonly policyContent: pulumi.Input<string>;
    /**
     * The identifier of the Policy.
     */
    readonly policyId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
}