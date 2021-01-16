// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class OutboundRuleResponse
    {
        /// <summary>
        /// The number of outbound ports to be used for NAT.
        /// </summary>
        public readonly int? AllocatedOutboundPorts;
        /// <summary>
        /// A reference to a pool of DIPs. Outbound traffic is randomly load balanced across IPs in the backend IPs.
        /// </summary>
        public readonly Outputs.SubResourceResponse BackendAddressPool;
        /// <summary>
        /// Receive bidirectional TCP Reset on TCP flow idle timeout or unexpected connection termination. This element is only used when the protocol is set to TCP.
        /// </summary>
        public readonly bool? EnableTcpReset;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The Frontend IP addresses of the load balancer.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> FrontendIPConfigurations;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The timeout for the TCP idle connection.
        /// </summary>
        public readonly int? IdleTimeoutInMinutes;
        /// <summary>
        /// The name of the resource that is unique within the set of outbound rules used by the load balancer. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The protocol for the outbound rule in load balancer.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// The provisioning state of the outbound rule resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private OutboundRuleResponse(
            int? allocatedOutboundPorts,

            Outputs.SubResourceResponse backendAddressPool,

            bool? enableTcpReset,

            string etag,

            ImmutableArray<Outputs.SubResourceResponse> frontendIPConfigurations,

            string? id,

            int? idleTimeoutInMinutes,

            string? name,

            string protocol,

            string provisioningState,

            string type)
        {
            AllocatedOutboundPorts = allocatedOutboundPorts;
            BackendAddressPool = backendAddressPool;
            EnableTcpReset = enableTcpReset;
            Etag = etag;
            FrontendIPConfigurations = frontendIPConfigurations;
            Id = id;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            Name = name;
            Protocol = protocol;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
