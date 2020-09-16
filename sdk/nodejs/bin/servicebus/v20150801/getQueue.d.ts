import * as pulumi from "@pulumi/pulumi";
import * as outputs from "../../types/output";
export declare function getQueue(args: GetQueueArgs, opts?: pulumi.InvokeOptions): Promise<GetQueueResult>;
export interface GetQueueArgs {
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * The queue name.
     */
    readonly queueName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
}
/**
 * Description of queue Resource.
 */
export interface GetQueueResult {
    /**
     * Last time a message was sent, or the last time there was a receive request to this queue.
     */
    readonly accessedAt: string;
    /**
     * the TimeSpan idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes.
     */
    readonly autoDeleteOnIdle?: string;
    /**
     * Message Count Details.
     */
    readonly countDetails: outputs.servicebus.v20150801.MessageCountDetailsResponse;
    /**
     * The exact time the message was created.
     */
    readonly createdAt: string;
    /**
     * A value that indicates whether this queue has dead letter support when a message expires.
     */
    readonly deadLetteringOnMessageExpiration?: boolean;
    /**
     * The default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
     */
    readonly defaultMessageTimeToLive?: string;
    /**
     * TimeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
     */
    readonly duplicateDetectionHistoryTimeWindow?: string;
    /**
     * A value that indicates whether server-side batched operations are enabled.
     */
    readonly enableBatchedOperations?: boolean;
    /**
     * A value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage.
     */
    readonly enableExpress?: boolean;
    /**
     * A value that indicates whether the queue is to be partitioned across multiple message brokers.
     */
    readonly enablePartitioning?: boolean;
    /**
     * Entity availability status for the queue.
     */
    readonly entityAvailabilityStatus?: string;
    /**
     * A value that indicates whether the message is accessible anonymously.
     */
    readonly isAnonymousAccessible?: boolean;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * The duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
     */
    readonly lockDuration?: string;
    /**
     * The maximum delivery count. A message is automatically deadlettered after this number of deliveries.
     */
    readonly maxDeliveryCount?: number;
    /**
     * The maximum size of the queue in megabytes, which is the size of memory allocated for the queue.
     */
    readonly maxSizeInMegabytes?: number;
    /**
     * The number of messages in the queue.
     */
    readonly messageCount: number;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * A value indicating if this queue requires duplicate detection.
     */
    readonly requiresDuplicateDetection?: boolean;
    /**
     * A value that indicates whether the queue supports the concept of sessions.
     */
    readonly requiresSession?: boolean;
    /**
     * The size of the queue, in bytes.
     */
    readonly sizeInBytes: number;
    /**
     * Enumerates the possible values for the status of a messaging entity.
     */
    readonly status?: string;
    /**
     * A value that indicates whether the queue supports ordering.
     */
    readonly supportOrdering?: boolean;
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * The exact time the message was updated.
     */
    readonly updatedAt: string;
}