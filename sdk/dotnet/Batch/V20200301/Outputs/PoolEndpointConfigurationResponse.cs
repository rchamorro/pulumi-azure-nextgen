// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Batch.V20200301.Outputs
{

    [OutputType]
    public sealed class PoolEndpointConfigurationResponse
    {
        /// <summary>
        /// The maximum number of inbound NAT pools per Batch pool is 5. If the maximum number of inbound NAT pools is exceeded the request fails with HTTP status code 400.
        /// </summary>
        public readonly ImmutableArray<Outputs.InboundNatPoolResponse> InboundNatPools;

        [OutputConstructor]
        private PoolEndpointConfigurationResponse(ImmutableArray<Outputs.InboundNatPoolResponse> inboundNatPools)
        {
            InboundNatPools = inboundNatPools;
        }
    }
}