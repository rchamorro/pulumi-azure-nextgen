// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200301.Outputs
{

    [OutputType]
    public sealed class EventHubPropertiesResponse
    {
        /// <summary>
        /// The Event Hub-compatible endpoint.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages.
        /// </summary>
        public readonly int? PartitionCount;
        /// <summary>
        /// The partition ids in the Event Hub-compatible endpoint.
        /// </summary>
        public readonly ImmutableArray<string> PartitionIds;
        /// <summary>
        /// The Event Hub-compatible name.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// The retention time for device-to-cloud messages in days. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages
        /// </summary>
        public readonly double? RetentionTimeInDays;

        [OutputConstructor]
        private EventHubPropertiesResponse(
            string endpoint,

            int? partitionCount,

            ImmutableArray<string> partitionIds,

            string path,

            double? retentionTimeInDays)
        {
            Endpoint = endpoint;
            PartitionCount = partitionCount;
            PartitionIds = partitionIds;
            Path = path;
            RetentionTimeInDays = retentionTimeInDays;
        }
    }
}
