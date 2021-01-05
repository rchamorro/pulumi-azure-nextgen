// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20180101Preview
{
    public static class GetQueue
    {
        public static Task<GetQueueResult> InvokeAsync(GetQueueArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetQueueResult>("azure-nextgen:servicebus/v20180101preview:getQueue", args ?? new GetQueueArgs(), options.WithVersion());
    }


    public sealed class GetQueueArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The queue name.
        /// </summary>
        [Input("queueName", required: true)]
        public string QueueName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetQueueArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetQueueResult
    {
        /// <summary>
        /// Last time a message was sent, or the last time there was a receive request to this queue.
        /// </summary>
        public readonly string AccessedAt;
        /// <summary>
        /// ISO 8061 timeSpan idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        public readonly string? AutoDeleteOnIdle;
        /// <summary>
        /// Message Count Details.
        /// </summary>
        public readonly Outputs.MessageCountDetailsResponse CountDetails;
        /// <summary>
        /// The exact time the message was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// A value that indicates whether this queue has dead letter support when a message expires.
        /// </summary>
        public readonly bool? DeadLetteringOnMessageExpiration;
        /// <summary>
        /// ISO 8601 default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        /// </summary>
        public readonly string? DefaultMessageTimeToLive;
        /// <summary>
        /// ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        /// </summary>
        public readonly string? DuplicateDetectionHistoryTimeWindow;
        /// <summary>
        /// Value that indicates whether server-side batched operations are enabled.
        /// </summary>
        public readonly bool? EnableBatchedOperations;
        /// <summary>
        /// A value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage.
        /// </summary>
        public readonly bool? EnableExpress;
        /// <summary>
        /// A value that indicates whether the queue is to be partitioned across multiple message brokers.
        /// </summary>
        public readonly bool? EnablePartitioning;
        /// <summary>
        /// Queue/Topic name to forward the Dead Letter message
        /// </summary>
        public readonly string? ForwardDeadLetteredMessagesTo;
        /// <summary>
        /// Queue/Topic name to forward the messages
        /// </summary>
        public readonly string? ForwardTo;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute.
        /// </summary>
        public readonly string? LockDuration;
        /// <summary>
        /// The maximum delivery count. A message is automatically deadlettered after this number of deliveries. default value is 10.
        /// </summary>
        public readonly int? MaxDeliveryCount;
        /// <summary>
        /// The maximum size of the queue in megabytes, which is the size of memory allocated for the queue. Default is 1024.
        /// </summary>
        public readonly int? MaxSizeInMegabytes;
        /// <summary>
        /// The number of messages in the queue.
        /// </summary>
        public readonly double MessageCount;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A value indicating if this queue requires duplicate detection.
        /// </summary>
        public readonly bool? RequiresDuplicateDetection;
        /// <summary>
        /// A value that indicates whether the queue supports the concept of sessions.
        /// </summary>
        public readonly bool? RequiresSession;
        /// <summary>
        /// The size of the queue, in bytes.
        /// </summary>
        public readonly double SizeInBytes;
        /// <summary>
        /// Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The exact time the message was updated.
        /// </summary>
        public readonly string UpdatedAt;

        [OutputConstructor]
        private GetQueueResult(
            string accessedAt,

            string? autoDeleteOnIdle,

            Outputs.MessageCountDetailsResponse countDetails,

            string createdAt,

            bool? deadLetteringOnMessageExpiration,

            string? defaultMessageTimeToLive,

            string? duplicateDetectionHistoryTimeWindow,

            bool? enableBatchedOperations,

            bool? enableExpress,

            bool? enablePartitioning,

            string? forwardDeadLetteredMessagesTo,

            string? forwardTo,

            string id,

            string? lockDuration,

            int? maxDeliveryCount,

            int? maxSizeInMegabytes,

            double messageCount,

            string name,

            bool? requiresDuplicateDetection,

            bool? requiresSession,

            double sizeInBytes,

            string? status,

            string type,

            string updatedAt)
        {
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            CountDetails = countDetails;
            CreatedAt = createdAt;
            DeadLetteringOnMessageExpiration = deadLetteringOnMessageExpiration;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            EnableExpress = enableExpress;
            EnablePartitioning = enablePartitioning;
            ForwardDeadLetteredMessagesTo = forwardDeadLetteredMessagesTo;
            ForwardTo = forwardTo;
            Id = id;
            LockDuration = lockDuration;
            MaxDeliveryCount = maxDeliveryCount;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            MessageCount = messageCount;
            Name = name;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            RequiresSession = requiresSession;
            SizeInBytes = sizeInBytes;
            Status = status;
            Type = type;
            UpdatedAt = updatedAt;
        }
    }
}
