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
    public sealed class LocalNetworkGatewayResponse
    {
        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        public readonly Outputs.BgpSettingsResponse? BgpSettings;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// FQDN of local network gateway.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        public readonly string? GatewayIpAddress;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Local network site address space.
        /// </summary>
        public readonly Outputs.AddressSpaceResponse? LocalNetworkAddressSpace;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the local network gateway resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource GUID property of the local network gateway resource.
        /// </summary>
        public readonly string ResourceGuid;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private LocalNetworkGatewayResponse(
            Outputs.BgpSettingsResponse? bgpSettings,

            string etag,

            string? fqdn,

            string? gatewayIpAddress,

            string? id,

            Outputs.AddressSpaceResponse? localNetworkAddressSpace,

            string? location,

            string name,

            string provisioningState,

            string resourceGuid,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            BgpSettings = bgpSettings;
            Etag = etag;
            Fqdn = fqdn;
            GatewayIpAddress = gatewayIpAddress;
            Id = id;
            LocalNetworkAddressSpace = localNetworkAddressSpace;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            Tags = tags;
            Type = type;
        }
    }
}
