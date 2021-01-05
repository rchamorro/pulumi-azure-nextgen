// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.Latest.Inputs
{

    /// <summary>
    /// Information about the SKU of the IoT hub.
    /// </summary>
    public sealed class IotHubSkuInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of provisioned IoT Hub units. See: https://docs.microsoft.com/azure/azure-subscription-service-limits#iot-hub-limits.
        /// </summary>
        [Input("capacity")]
        public Input<double>? Capacity { get; set; }

        /// <summary>
        /// The name of the SKU.
        /// </summary>
        [Input("name", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.Devices.Latest.IotHubSku> Name { get; set; } = null!;

        public IotHubSkuInfoArgs()
        {
        }
    }
}
