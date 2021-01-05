// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20180401.Outputs
{

    [OutputType]
    public sealed class IotHubSkuInfoResponse
    {
        /// <summary>
        /// The number of provisioned IoT Hub units. See: https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits.
        /// </summary>
        public readonly double? Capacity;
        /// <summary>
        /// The name of the SKU.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The billing tier for the IoT hub.
        /// </summary>
        public readonly string Tier;

        [OutputConstructor]
        private IotHubSkuInfoResponse(
            double? capacity,

            string name,

            string tier)
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }
    }
}
