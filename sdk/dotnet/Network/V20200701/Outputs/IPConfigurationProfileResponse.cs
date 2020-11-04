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
    public sealed class IPConfigurationProfileResponse
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
        /// The name of the resource. This name can be used to access the resource.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The provisioning state of the IP configuration profile resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        public readonly Outputs.SubnetResponse? Subnet;
        /// <summary>
        /// Sub Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private IPConfigurationProfileResponse(
            string etag,

            string? id,

            string? name,

            string provisioningState,

            Outputs.SubnetResponse? subnet,

            string type)
        {
            Etag = etag;
            Id = id;
            Name = name;
            ProvisioningState = provisioningState;
            Subnet = subnet;
            Type = type;
        }
    }
}
