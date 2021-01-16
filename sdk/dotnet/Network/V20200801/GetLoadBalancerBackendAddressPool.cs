// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801
{
    public static class GetLoadBalancerBackendAddressPool
    {
        public static Task<GetLoadBalancerBackendAddressPoolResult> InvokeAsync(GetLoadBalancerBackendAddressPoolArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLoadBalancerBackendAddressPoolResult>("azure-nextgen:network/v20200801:getLoadBalancerBackendAddressPool", args ?? new GetLoadBalancerBackendAddressPoolArgs(), options.WithVersion());
    }


    public sealed class GetLoadBalancerBackendAddressPoolArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the backend address pool.
        /// </summary>
        [Input("backendAddressPoolName", required: true)]
        public string BackendAddressPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the load balancer.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public string LoadBalancerName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetLoadBalancerBackendAddressPoolArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLoadBalancerBackendAddressPoolResult
    {
        /// <summary>
        /// An array of references to IP addresses defined in network interfaces.
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkInterfaceIPConfigurationResponse> BackendIPConfigurations;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// An array of backend addresses.
        /// </summary>
        public readonly ImmutableArray<Outputs.LoadBalancerBackendAddressResponse> LoadBalancerBackendAddresses;
        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> LoadBalancingRules;
        /// <summary>
        /// The location of the backend address pool.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// A reference to an outbound rule that uses this backend address pool.
        /// </summary>
        public readonly Outputs.SubResourceResponse OutboundRule;
        /// <summary>
        /// An array of references to outbound rules that use this backend address pool.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> OutboundRules;
        /// <summary>
        /// The provisioning state of the backend address pool resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetLoadBalancerBackendAddressPoolResult(
            ImmutableArray<Outputs.NetworkInterfaceIPConfigurationResponse> backendIPConfigurations,

            string etag,

            string? id,

            ImmutableArray<Outputs.LoadBalancerBackendAddressResponse> loadBalancerBackendAddresses,

            ImmutableArray<Outputs.SubResourceResponse> loadBalancingRules,

            string? location,

            string? name,

            Outputs.SubResourceResponse outboundRule,

            ImmutableArray<Outputs.SubResourceResponse> outboundRules,

            string provisioningState,

            string type)
        {
            BackendIPConfigurations = backendIPConfigurations;
            Etag = etag;
            Id = id;
            LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            LoadBalancingRules = loadBalancingRules;
            Location = location;
            Name = name;
            OutboundRule = outboundRule;
            OutboundRules = outboundRules;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
