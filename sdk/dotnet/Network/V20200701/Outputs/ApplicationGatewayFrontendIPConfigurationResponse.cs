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
    public sealed class ApplicationGatewayFrontendIPConfigurationResponse
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the frontend IP configuration that is unique within an Application Gateway.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// PrivateIPAddress of the network interface IP Configuration.
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// The private IP address allocation method.
        /// </summary>
        public readonly string? PrivateIPAllocationMethod;
        /// <summary>
        /// Reference to the application gateway private link configuration.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PrivateLinkConfiguration;
        /// <summary>
        /// The provisioning state of the frontend IP configuration resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Reference to the PublicIP resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? PublicIPAddress;
        /// <summary>
        /// Reference to the subnet resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? Subnet;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ApplicationGatewayFrontendIPConfigurationResponse(
            string etag,

            string? id,

            string? name,

            string? privateIPAddress,

            string? privateIPAllocationMethod,

            Outputs.SubResourceResponse? privateLinkConfiguration,

            string provisioningState,

            Outputs.SubResourceResponse? publicIPAddress,

            Outputs.SubResourceResponse? subnet,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            PrivateLinkConfiguration = privateLinkConfiguration;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
            Type = type;
        }
    }
}
