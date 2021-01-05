// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200101.Outputs
{

    [OutputType]
    public sealed class IotDpsSkuInfoResponse
    {
        /// <summary>
        /// The number of units to provision
        /// </summary>
        public readonly double? Capacity;
        /// <summary>
        /// Sku name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Pricing tier name of the provisioning service.
        /// </summary>
        public readonly string Tier;

        [OutputConstructor]
        private IotDpsSkuInfoResponse(
            double? capacity,

            string? name,

            string tier)
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }
    }
}
