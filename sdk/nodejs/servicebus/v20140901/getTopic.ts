// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../../types";
import * as utilities from "../../utilities";

export function getTopic(args: GetTopicArgs, opts?: pulumi.InvokeOptions): Promise<GetTopicResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure-nextgen:servicebus/v20140901:getTopic", {
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
        "topicName": args.topicName,
    }, opts);
}

export interface GetTopicArgs {
    /**
     * The namespace name
     */
    readonly namespaceName: string;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    readonly resourceGroupName: string;
    /**
     * The topic name.
     */
    readonly topicName: string;
}

/**
 * Description of topic resource.
 */
export interface GetTopicResult {
    /**
     * Last time the message was sent, or a request was received, for this topic.
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
     * Default message time to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
     */
    readonly defaultMessageTimeToLive?: string;
    /**
     * TimeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
     */
    readonly duplicateDetectionHistoryTimeWindow?: string;
    /**
     * Value that indicates whether server-side batched operations are enabled.
     */
    readonly enableBatchedOperations?: boolean;
    /**
     * Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.
     */
    readonly enableExpress?: boolean;
    /**
     * Value that indicates whether the topic to be partitioned across multiple message brokers is enabled.
     */
    readonly enablePartitioning?: boolean;
    /**
     * Entity availability status for the topic.
     */
    readonly entityAvailabilityStatus?: string;
    /**
     * Whether messages should be filtered before publishing.
     */
    readonly filteringMessagesBeforePublishing?: boolean;
    /**
     * Value that indicates whether the message is accessible anonymously.
     */
    readonly isAnonymousAccessible?: boolean;
    readonly isExpress?: boolean;
    /**
     * Resource location.
     */
    readonly location?: string;
    /**
     * Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic.
     */
    readonly maxSizeInMegabytes?: number;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * Value indicating if this topic requires duplicate detection.
     */
    readonly requiresDuplicateDetection?: boolean;
    /**
     * Size of the topic, in bytes.
     */
    readonly sizeInBytes: number;
    /**
     * Enumerates the possible values for the status of a messaging entity.
     */
    readonly status?: string;
    /**
     * Number of subscriptions.
     */
    readonly subscriptionCount: number;
    /**
     * Value that indicates whether the topic supports ordering.
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
