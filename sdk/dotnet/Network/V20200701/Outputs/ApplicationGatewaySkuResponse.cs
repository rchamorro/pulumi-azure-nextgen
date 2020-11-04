// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewaySkuResponse
    {
        /// <summary>
        /// Capacity (instance count) of an application gateway.
        /// </summary>
        public readonly int? Capacity;
        /// <summary>
        /// Name of an application gateway SKU.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Tier of an application gateway.
        /// </summary>
        public readonly string? Tier;

        [OutputConstructor]
        private ApplicationGatewaySkuResponse(
            int? capacity,

            string? name,

            string? tier)
        {
            Capacity = capacity;
            Name = name;
            Tier = tier;
        }
    }
}
