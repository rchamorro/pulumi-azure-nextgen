import * as pulumi from "@pulumi/pulumi";
/**
 * Subscription details.
 */
export declare class Subscription extends pulumi.CustomResource {
    /**
     * Get an existing Subscription resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Subscription;
    /**
     * Returns true if the given object is an instance of Subscription.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    static isInstance(obj: any): obj is Subscription;
    /**
     * Determines whether tracing is enabled
     */
    readonly allowTracing: pulumi.Output<boolean | undefined>;
    /**
     * Subscription creation date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly createdDate: pulumi.Output<string>;
    /**
     * The name of the subscription, or null if the subscription has no name.
     */
    readonly displayName: pulumi.Output<string | undefined>;
    /**
     * Date when subscription was cancelled or expired. The setting is for audit purposes only and the subscription is not automatically cancelled. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly endDate: pulumi.Output<string | undefined>;
    /**
     * Subscription expiration date. The setting is for audit purposes only and the subscription is not automatically expired. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly expirationDate: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    readonly name: pulumi.Output<string>;
    /**
     * Upcoming subscription expiration notification date. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly notificationDate: pulumi.Output<string | undefined>;
    /**
     * The user resource identifier of the subscription owner. The value is a valid relative URL in the format of /users/{userId} where {userId} is a user identifier.
     */
    readonly ownerId: pulumi.Output<string | undefined>;
    /**
     * Subscription primary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
     */
    readonly primaryKey: pulumi.Output<string | undefined>;
    /**
     * Scope like /products/{productId} or /apis or /apis/{apiId}.
     */
    readonly scope: pulumi.Output<string>;
    /**
     * Subscription secondary key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
     */
    readonly secondaryKey: pulumi.Output<string | undefined>;
    /**
     * Subscription activation date. The setting is for audit purposes only and the subscription is not automatically activated. The subscription lifecycle can be managed by using the `state` property. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    readonly startDate: pulumi.Output<string | undefined>;
    /**
     * Subscription state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
     */
    readonly state: pulumi.Output<string>;
    /**
     * Optional subscription comment added by an administrator when the state is changed to the 'rejected'.
     */
    readonly stateComment: pulumi.Output<string | undefined>;
    /**
     * Resource type for API Management resource.
     */
    readonly type: pulumi.Output<string>;
    /**
     * Create a Subscription resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubscriptionArgs, opts?: pulumi.CustomResourceOptions);
    constructor(name: string, state: undefined, opts: pulumi.CustomResourceOptions);
}
/**
 * The set of arguments for constructing a Subscription resource.
 */
export interface SubscriptionArgs {
    /**
     * Determines whether tracing can be enabled
     */
    readonly allowTracing?: pulumi.Input<boolean>;
    /**
     * Determines the type of application which send the create user request. Default is legacy publisher portal.
     */
    readonly appType?: pulumi.Input<string>;
    /**
     * Subscription name.
     */
    readonly displayName: pulumi.Input<string>;
    /**
     * Notify change in Subscription State.
     *  - If false, do not send any email notification for change of state of subscription
     *  - If true, send email notification of change of state of subscription
     */
    readonly notify?: pulumi.Input<boolean>;
    /**
     * User (user id path) for whom subscription is being created in form /users/{userId}
     */
    readonly ownerId?: pulumi.Input<string>;
    /**
     * Primary subscription key. If not specified during request key will be generated automatically.
     */
    readonly primaryKey?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Scope like /products/{productId} or /apis or /apis/{apiId}.
     */
    readonly scope: pulumi.Input<string>;
    /**
     * Secondary subscription key. If not specified during request key will be generated automatically.
     */
    readonly secondaryKey?: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    readonly serviceName: pulumi.Input<string>;
    /**
     * Subscription entity Identifier. The entity represents the association between a user and a product in API Management.
     */
    readonly sid: pulumi.Input<string>;
    /**
     * Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
     */
    readonly state?: pulumi.Input<string>;
}