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
    public sealed class IPConfigurationResponse
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
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The private IP address of the IP configuration.
        /// </summary>
        public readonly string? PrivateIPAddress;
        /// <summary>
        /// The private IP address allocation method.
        /// </summary>
        public readonly string? PrivateIPAllocationMethod;
        /// <summary>
        /// The provisioning state of the IP configuration resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The reference to the public IP resource.
        /// </summary>
        public readonly Outputs.PublicIPAddressResponse? PublicIPAddress;
        /// <summary>
        /// The reference to the subnet resource.
        /// </summary>
        public readonly Outputs.SubnetResponse? Subnet;

        [OutputConstructor]
        private IPConfigurationResponse(
            string etag,

            string? id,

            string? name,

            string? privateIPAddress,

            string? privateIPAllocationMethod,

            string provisioningState,

            Outputs.PublicIPAddressResponse? publicIPAddress,

            Outputs.SubnetResponse? subnet)
        {
            Etag = etag;
            Id = id;
            Name = name;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            ProvisioningState = provisioningState;
            PublicIPAddress = publicIPAddress;
            Subnet = subnet;
        }
    }
}
