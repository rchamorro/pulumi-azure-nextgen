// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20180401.Inputs
{

    /// <summary>
    /// The properties of the provisioned Event Hub-compatible endpoint used by the IoT hub.
    /// </summary>
    public sealed class EventHubPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of partitions for receiving device-to-cloud messages in the Event Hub-compatible endpoint. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages.
        /// </summary>
        [Input("partitionCount")]
        public Input<int>? PartitionCount { get; set; }

        /// <summary>
        /// The retention time for device-to-cloud messages in days. See: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-messaging#device-to-cloud-messages
        /// </summary>
        [Input("retentionTimeInDays")]
        public Input<double>? RetentionTimeInDays { get; set; }

        public EventHubPropertiesArgs()
        {
        }
    }
}
