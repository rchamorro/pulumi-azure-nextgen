// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.Latest.Inputs
{

    /// <summary>
    /// Represents the delta health policy used to evaluate the health of services belonging to a service type when upgrading the cluster.
    /// </summary>
    public sealed class ServiceTypeDeltaHealthPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum allowed percentage of services health degradation allowed during cluster upgrades.
        /// The delta is measured between the state of the services at the beginning of upgrade and the state of the services at the time of the health evaluation.
        /// The check is performed after every upgrade domain upgrade completion to make sure the global state of the cluster is within tolerated limits.
        /// </summary>
        [Input("maxPercentDeltaUnhealthyServices")]
        public Input<int>? MaxPercentDeltaUnhealthyServices { get; set; }

        public ServiceTypeDeltaHealthPolicyArgs()
        {
            MaxPercentDeltaUnhealthyServices = 0;
        }
    }
}
