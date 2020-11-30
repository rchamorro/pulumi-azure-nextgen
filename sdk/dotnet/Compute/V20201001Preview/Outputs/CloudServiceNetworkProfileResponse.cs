// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201001Preview.Outputs
{

    [OutputType]
    public sealed class CloudServiceNetworkProfileResponse
    {
        /// <summary>
        /// The list of load balancer configurations for the cloud service.
        /// </summary>
        public readonly ImmutableArray<Outputs.LoadBalancerConfigurationResponse> LoadBalancerConfigurations;
        public readonly Outputs.SubResourceResponse? SwappableCloudService;

        [OutputConstructor]
        private CloudServiceNetworkProfileResponse(
            ImmutableArray<Outputs.LoadBalancerConfigurationResponse> loadBalancerConfigurations,

            Outputs.SubResourceResponse? swappableCloudService)
        {
            LoadBalancerConfigurations = loadBalancerConfigurations;
            SwappableCloudService = swappableCloudService;
        }
    }
}