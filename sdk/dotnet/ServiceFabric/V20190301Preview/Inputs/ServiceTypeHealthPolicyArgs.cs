// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20190301Preview.Inputs
{

    /// <summary>
    /// Represents the health policy used to evaluate the health of services belonging to a service type.
    /// </summary>
    public sealed class ServiceTypeHealthPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum percentage of services allowed to be unhealthy before your application is considered in error.
        /// </summary>
        [Input("maxPercentUnhealthyServices")]
        public Input<int>? MaxPercentUnhealthyServices { get; set; }

        public ServiceTypeHealthPolicyArgs()
        {
            MaxPercentUnhealthyServices = 0;
        }
    }
}
