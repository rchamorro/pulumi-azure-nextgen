import * as pulumi from "@pulumi/pulumi";
/**
 * Issue Comment Contract details.
 */
export declare class ApiIssueComment extends pulumi.CustomResource {
    /**
     * Get an existing ApiIssueComment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApiIssueComment;
    /**
     * Returns true if the given object is an instance of ApiIssueComment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is ApiIssueComment;
    /**
     * Date and time when the comment was created.
     */
    readonly createdDate: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * Comment text.
     */
    readonly text: pulumi.Output<string>;
    /**
     * Resource type for API Management resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * A resource identifier for the user who left the comment.
     */
    readonly userId: pulumi.Output<string>;
    /**
     * Create a ApiIssueComment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiIssueCommentArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a ApiIssueComment resource.
 */
export interface ApiIssueCommentArgs {
    /**
     * API identifier. Must be unique in the current API Management service instance.
     */
    readonly apiId: pulumi.Input<string>;
    /**
     * Comment identifier within an Issue. Must be unique in the current Issue.
     */
    readonly commentId: pulumi.Input<string>;
    /**
     * Date and time when the comment was created.
     */
    readonly createdDate?: pulumi.Input<string>;
    /**
     * Issue identifier. Must be unique in the current API Management service instance.
     */
    readonly issueId: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
    /**
     * Comment text.
     */
    readonly text: pulumi.Input<string>;
    /**
     * A resource identifier for the user who left the comment.
     */
    readonly userId: pulumi.Input<string>;
}