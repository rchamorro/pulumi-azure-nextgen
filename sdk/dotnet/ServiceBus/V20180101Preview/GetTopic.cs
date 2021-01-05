// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20180101Preview
{
    public static class GetTopic
    {
        public static Task<GetTopicResult> InvokeAsync(GetTopicArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTopicResult>("azure-nextgen:servicebus/v20180101preview:getTopic", args ?? new GetTopicArgs(), options.WithVersion());
    }


    public sealed class GetTopicArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The topic name.
        /// </summary>
        [Input("topicName", required: true)]
        public string TopicName { get; set; } = null!;

        public GetTopicArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTopicResult
    {
        /// <summary>
        /// Last time the message was sent, or a request was received, for this topic.
        /// </summary>
        public readonly string AccessedAt;
        /// <summary>
        /// ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes.
        /// </summary>
        public readonly string? AutoDeleteOnIdle;
        /// <summary>
        /// Message count details
        /// </summary>
        public readonly Outputs.MessageCountDetailsResponse CountDetails;
        /// <summary>
        /// Exact time the message was created.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself.
        /// </summary>
        public readonly string? DefaultMessageTimeToLive;
        /// <summary>
        /// ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes.
        /// </summary>
        public readonly string? DuplicateDetectionHistoryTimeWindow;
        /// <summary>
        /// Value that indicates whether server-side batched operations are enabled.
        /// </summary>
        public readonly bool? EnableBatchedOperations;
        /// <summary>
        /// Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage.
        /// </summary>
        public readonly bool? EnableExpress;
        /// <summary>
        /// Value that indicates whether the topic to be partitioned across multiple message brokers is enabled.
        /// </summary>
        public readonly bool? EnablePartitioning;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024.
        /// </summary>
        public readonly int? MaxSizeInMegabytes;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Value indicating if this topic requires duplicate detection.
        /// </summary>
        public readonly bool? RequiresDuplicateDetection;
        /// <summary>
        /// Size of the topic, in bytes.
        /// </summary>
        public readonly double SizeInBytes;
        /// <summary>
        /// Enumerates the possible values for the status of a messaging entity.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Number of subscriptions.
        /// </summary>
        public readonly int SubscriptionCount;
        /// <summary>
        /// Value that indicates whether the topic supports ordering.
        /// </summary>
        public readonly bool? SupportOrdering;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The exact time the message was updated.
        /// </summary>
        public readonly string UpdatedAt;

        [OutputConstructor]
        private GetTopicResult(
            string accessedAt,

            string? autoDeleteOnIdle,

            Outputs.MessageCountDetailsResponse countDetails,

            string createdAt,

            string? defaultMessageTimeToLive,

            string? duplicateDetectionHistoryTimeWindow,

            bool? enableBatchedOperations,

            bool? enableExpress,

            bool? enablePartitioning,

            string id,

            int? maxSizeInMegabytes,

            string name,

            bool? requiresDuplicateDetection,

            double sizeInBytes,

            string? status,

            int subscriptionCount,

            bool? supportOrdering,

            string type,

            string updatedAt)
        {
            AccessedAt = accessedAt;
            AutoDeleteOnIdle = autoDeleteOnIdle;
            CountDetails = countDetails;
            CreatedAt = createdAt;
            DefaultMessageTimeToLive = defaultMessageTimeToLive;
            DuplicateDetectionHistoryTimeWindow = duplicateDetectionHistoryTimeWindow;
            EnableBatchedOperations = enableBatchedOperations;
            EnableExpress = enableExpress;
            EnablePartitioning = enablePartitioning;
            Id = id;
            MaxSizeInMegabytes = maxSizeInMegabytes;
            Name = name;
            RequiresDuplicateDetection = requiresDuplicateDetection;
            SizeInBytes = sizeInBytes;
            Status = status;
            SubscriptionCount = subscriptionCount;
            SupportOrdering = supportOrdering;
            Type = type;
            UpdatedAt = updatedAt;
        }
    }
}
