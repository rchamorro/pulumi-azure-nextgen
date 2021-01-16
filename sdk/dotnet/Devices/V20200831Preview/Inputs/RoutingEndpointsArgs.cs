// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831Preview.Inputs
{

    /// <summary>
    /// The properties related to the custom endpoints to which your IoT hub routes messages based on the routing rules. A maximum of 10 custom endpoints are allowed across all endpoint types for paid hubs and only 1 custom endpoint is allowed across all endpoint types for free hubs.
    /// </summary>
    public sealed class RoutingEndpointsArgs : Pulumi.ResourceArgs
    {
        [Input("eventHubs")]
        private InputList<Inputs.RoutingEventHubPropertiesArgs>? _eventHubs;

        /// <summary>
        /// The list of Event Hubs endpoints that IoT hub routes messages to, based on the routing rules. This list does not include the built-in Event Hubs endpoint.
        /// </summary>
        public InputList<Inputs.RoutingEventHubPropertiesArgs> EventHubs
        {
            get => _eventHubs ?? (_eventHubs = new InputList<Inputs.RoutingEventHubPropertiesArgs>());
            set => _eventHubs = value;
        }

        [Input("serviceBusQueues")]
        private InputList<Inputs.RoutingServiceBusQueueEndpointPropertiesArgs>? _serviceBusQueues;

        /// <summary>
        /// The list of Service Bus queue endpoints that IoT hub routes the messages to, based on the routing rules.
        /// </summary>
        public InputList<Inputs.RoutingServiceBusQueueEndpointPropertiesArgs> ServiceBusQueues
        {
            get => _serviceBusQueues ?? (_serviceBusQueues = new InputList<Inputs.RoutingServiceBusQueueEndpointPropertiesArgs>());
            set => _serviceBusQueues = value;
        }

        [Input("serviceBusTopics")]
        private InputList<Inputs.RoutingServiceBusTopicEndpointPropertiesArgs>? _serviceBusTopics;

        /// <summary>
        /// The list of Service Bus topic endpoints that the IoT hub routes the messages to, based on the routing rules.
        /// </summary>
        public InputList<Inputs.RoutingServiceBusTopicEndpointPropertiesArgs> ServiceBusTopics
        {
            get => _serviceBusTopics ?? (_serviceBusTopics = new InputList<Inputs.RoutingServiceBusTopicEndpointPropertiesArgs>());
            set => _serviceBusTopics = value;
        }

        [Input("storageContainers")]
        private InputList<Inputs.RoutingStorageContainerPropertiesArgs>? _storageContainers;

        /// <summary>
        /// The list of storage container endpoints that IoT hub routes messages to, based on the routing rules.
        /// </summary>
        public InputList<Inputs.RoutingStorageContainerPropertiesArgs> StorageContainers
        {
            get => _storageContainers ?? (_storageContainers = new InputList<Inputs.RoutingStorageContainerPropertiesArgs>());
            set => _storageContainers = value;
        }

        public RoutingEndpointsArgs()
        {
        }
    }
}
