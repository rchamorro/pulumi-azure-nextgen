// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20140901.Outputs
{

    [OutputType]
    public sealed class MessageCountDetailsResponse
    {
        /// <summary>
        /// Number of active messages in the queue, topic, or subscription.
        /// </summary>
        public readonly double ActiveMessageCount;
        /// <summary>
        /// Number of messages that are dead lettered.
        /// </summary>
        public readonly double DeadLetterMessageCount;
        /// <summary>
        /// Number of scheduled messages.
        /// </summary>
        public readonly double ScheduledMessageCount;
        /// <summary>
        /// Number of messages transferred into dead letters.
        /// </summary>
        public readonly double TransferDeadLetterMessageCount;
        /// <summary>
        /// Number of messages transferred to another queue, topic, or subscription.
        /// </summary>
        public readonly double TransferMessageCount;

        [OutputConstructor]
        private MessageCountDetailsResponse(
            double activeMessageCount,

            double deadLetterMessageCount,

            double scheduledMessageCount,

            double transferDeadLetterMessageCount,

            double transferMessageCount)
        {
            ActiveMessageCount = activeMessageCount;
            DeadLetterMessageCount = deadLetterMessageCount;
            ScheduledMessageCount = scheduledMessageCount;
            TransferDeadLetterMessageCount = transferDeadLetterMessageCount;
            TransferMessageCount = transferMessageCount;
        }
    }
}
