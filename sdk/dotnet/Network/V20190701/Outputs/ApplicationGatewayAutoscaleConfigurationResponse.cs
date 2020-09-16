// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayAutoscaleConfigurationResponse
    {
        /// <summary>
        /// Upper bound on number of Application Gateway capacity.
        /// </summary>
        public readonly int? MaxCapacity;
        /// <summary>
        /// Lower bound on number of Application Gateway capacity.
        /// </summary>
        public readonly int MinCapacity;

        [OutputConstructor]
        private ApplicationGatewayAutoscaleConfigurationResponse(
            int? maxCapacity,

            int minCapacity)
        {
            MaxCapacity = maxCapacity;
            MinCapacity = minCapacity;
        }
    }
}