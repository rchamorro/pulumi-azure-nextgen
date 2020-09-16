// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StreamAnalytics.V20170401Preview.Outputs
{

    [OutputType]
    public sealed class EventHubV2OutputDataSourceResponse
    {
        /// <summary>
        /// Authentication Mode.
        /// </summary>
        public readonly string? AuthenticationMode;
        /// <summary>
        /// The name of the Event Hub. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? EventHubName;
        /// <summary>
        /// The key/column that is used to determine to which partition to send event data.
        /// </summary>
        public readonly string? PartitionKey;
        public readonly ImmutableArray<string> PropertyColumns;
        /// <summary>
        /// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? ServiceBusNamespace;
        /// <summary>
        /// The shared access policy key for the specified shared access policy. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? SharedAccessPolicyKey;
        /// <summary>
        /// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string? SharedAccessPolicyName;
        /// <summary>
        /// Indicates the type of data source output will be written to. Required on PUT (CreateOrReplace) requests.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private EventHubV2OutputDataSourceResponse(
            string? authenticationMode,

            string? eventHubName,

            string? partitionKey,

            ImmutableArray<string> propertyColumns,

            string? serviceBusNamespace,

            string? sharedAccessPolicyKey,

            string? sharedAccessPolicyName,

            string type)
        {
            AuthenticationMode = authenticationMode;
            EventHubName = eventHubName;
            PartitionKey = partitionKey;
            PropertyColumns = propertyColumns;
            ServiceBusNamespace = serviceBusNamespace;
            SharedAccessPolicyKey = sharedAccessPolicyKey;
            SharedAccessPolicyName = sharedAccessPolicyName;
            Type = type;
        }
    }
}