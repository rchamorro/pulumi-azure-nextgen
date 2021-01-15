// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20200301.Inputs
{

    /// <summary>
    /// Profile of network configuration.
    /// </summary>
    public sealed class ContainerServiceNetworkProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An IP address assigned to the Kubernetes DNS service. It must be within the Kubernetes service address range specified in serviceCidr.
        /// </summary>
        [Input("dnsServiceIP")]
        public Input<string>? DnsServiceIP { get; set; }

        /// <summary>
        /// A CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the Kubernetes service address range.
        /// </summary>
        [Input("dockerBridgeCidr")]
        public Input<string>? DockerBridgeCidr { get; set; }

        /// <summary>
        /// Profile of the cluster load balancer.
        /// </summary>
        [Input("loadBalancerProfile")]
        public Input<Inputs.ManagedClusterLoadBalancerProfileArgs>? LoadBalancerProfile { get; set; }

        /// <summary>
        /// The load balancer sku for the managed cluster.
        /// </summary>
        [Input("loadBalancerSku")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerService.V20200301.LoadBalancerSku>? LoadBalancerSku { get; set; }

        /// <summary>
        /// Network mode used for building Kubernetes network.
        /// </summary>
        [Input("networkMode")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerService.V20200301.NetworkMode>? NetworkMode { get; set; }

        /// <summary>
        /// Network plugin used for building Kubernetes network.
        /// </summary>
        [Input("networkPlugin")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerService.V20200301.NetworkPlugin>? NetworkPlugin { get; set; }

        /// <summary>
        /// Network policy used for building Kubernetes network.
        /// </summary>
        [Input("networkPolicy")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerService.V20200301.NetworkPolicy>? NetworkPolicy { get; set; }

        /// <summary>
        /// The outbound (egress) routing method.
        /// </summary>
        [Input("outboundType")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerService.V20200301.OutboundType>? OutboundType { get; set; }

        /// <summary>
        /// A CIDR notation IP range from which to assign pod IPs when kubenet is used.
        /// </summary>
        [Input("podCidr")]
        public Input<string>? PodCidr { get; set; }

        /// <summary>
        /// A CIDR notation IP range from which to assign service cluster IPs. It must not overlap with any Subnet IP ranges.
        /// </summary>
        [Input("serviceCidr")]
        public Input<string>? ServiceCidr { get; set; }

        public ContainerServiceNetworkProfileArgs()
        {
            DnsServiceIP = "10.0.0.10";
            DockerBridgeCidr = "172.17.0.1/16";
            NetworkPlugin = "kubenet";
            OutboundType = "loadBalancer";
            PodCidr = "10.244.0.0/16";
            ServiceCidr = "10.0.0.0/16";
        }
    }
}
