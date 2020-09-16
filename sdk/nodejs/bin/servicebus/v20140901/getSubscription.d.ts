import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getSubscription(args: GetSubscriptionArgs, opts?: pulumi.InvokeOptions): Promise<GetSubscriptionResult>;
export interface GetSubscriptionArgs {
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The subscription name.
     */
    readonly subscriptionName: string;
    /**
     * The topic name.
     */
    readonly topicName: string;
}
/**
 * Description of subscription resource.
 */
export interface GetSubscriptionResult {
    /**
     * Last time there was a receive request to this subscription.
     */
    readonly accessedAt: string;
    /**
     * TimeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
     */
    readonly autoDeleteOnIdle?: string;
    /**
     * Message Count Details.
     */
    readonly countDetails: outputs.servicebus.v20140901.MessageCountDetailsResponse;
    /**
     * Exact time the message was created.
     */
    readonly createdAt: string;
    /**
     * Value that indicates whether a subscription has dead letter support on filter evaluation exceptions.
     */
    readonly deadLetteringOnFilterEvaluationExceptions?: boolean;
    /**
     * Value that indicates whether a subscription has dead letter support when a message expires.
     */
    readonly deadLetteringOnMessageExpiration?: boolean;
    /**
     * Default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
     */
    readonly defaultMessageTimeToLive?: string;
    /**
     * Value that indicates whether server-side batched operations are enabled.
     */
    readonly enableBatchedOperations?: boolean;
    /**
     * Entity availability status for the topic.
     */
    readonly entityAvailabilityStatus?: string;
    /**
     * Value that indicates whether the entity description is read-only.
     */
    readonly isReadOnly?: boolean;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The lock duration time span for the subscription.
     */
    readonly lockDuration?: string;
    /**
     * Number of maximum deliveries.
     */
    readonly maxDeliveryCount?: number;
    /**
     * Number of messages.
     */
    readonly messageCount: number;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Value indicating if a subscription supports the concept of sessions.
     */
    readonly requiresSession?: boolean;
    /**
     * Enumerates the possible values for the status of a messaging entity.
     */
    readonly status?: string;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * The exact time the message was updated.
     */
    readonly updatedAt: string;
}