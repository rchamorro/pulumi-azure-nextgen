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
    public sealed class NetworkInterfaceTapConfigurationResponse
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
        /// The provisioning state of the network interface tap configuration resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Sub Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The reference to the Virtual Network Tap resource.
        /// </summary>
        public readonly Outputs.VirtualNetworkTapResponse? VirtualNetworkTap;

        [OutputConstructor]
        private NetworkInterfaceTapConfigurationResponse(
            string etag,

            string? id,

            string? name,

            string provisioningState,

            string type,

            Outputs.VirtualNetworkTapResponse? virtualNetworkTap)
        {
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            Type = type;
            VirtualNetworkTap = virtualNetworkTap;
        }
    }
}
