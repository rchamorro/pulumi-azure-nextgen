// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20190301.Outputs
{

    [OutputType]
    public sealed class ApplicationMetricDescriptionResponse
    {
        /// <summary>
        /// The maximum node capacity for Service Fabric application.
        /// This is the maximum Load for an instance of this application on a single node. Even if the capacity of node is greater than this value, Service Fabric will limit the total load of services within the application on each node to this value.
        /// If set to zero, capacity for this metric is unlimited on each node.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        /// When updating existing application with application capacity, the product of MaximumNodes and this value must always be smaller than or equal to TotalApplicationCapacity.
        /// </summary>
        public readonly double? MaximumCapacity;
        /// <summary>
        /// The name of the metric.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The node reservation capacity for Service Fabric application.
        /// This is the amount of load which is reserved on nodes which have instances of this application.
        /// If MinimumNodes is specified, then the product of these values will be the capacity reserved in the cluster for the application.
        /// If set to zero, no capacity is reserved for this metric.
        /// When setting application capacity or when updating application capacity; this value must be smaller than or equal to MaximumCapacity for each metric.
        /// </summary>
        public readonly double? ReservationCapacity;
        /// <summary>
        /// The total metric capacity for Service Fabric application.
        /// This is the total metric capacity for this application in the cluster. Service Fabric will try to limit the sum of loads of services within the application to this value.
        /// When creating a new application with application capacity defined, the product of MaximumNodes and MaximumCapacity must always be smaller than or equal to this value.
        /// </summary>
        public readonly double? TotalApplicationCapacity;

        [OutputConstructor]
        private ApplicationMetricDescriptionResponse(
            double? maximumCapacity,

            string? name,

            double? reservationCapacity,

            double? totalApplicationCapacity)
        {
            MaximumCapacity = maximumCapacity;
            Name = name;
            ReservationCapacity = reservationCapacity;
            TotalApplicationCapacity = totalApplicationCapacity;
        }
    }
}
