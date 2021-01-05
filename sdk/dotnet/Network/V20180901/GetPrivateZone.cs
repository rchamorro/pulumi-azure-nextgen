// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180901
{
    public static class GetPrivateZone
    {
        public static Task<GetPrivateZoneResult> InvokeAsync(GetPrivateZoneArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrivateZoneResult>("azure-nextgen:network/v20180901:getPrivateZone", args ?? new GetPrivateZoneArgs(), options.WithVersion());
    }


    public sealed class GetPrivateZoneArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Private DNS zone (without a terminating dot).
        /// </summary>
        [Input("privateZoneName", required: true)]
        public string PrivateZoneName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPrivateZoneArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPrivateZoneResult
    {
        /// <summary>
        /// The ETag of the zone.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Fully qualified resource Id for the resource. Example - '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/privateDnsZones/{privateDnsZoneName}'.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The Azure Region where the resource lives
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The maximum number of record sets that can be created in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double MaxNumberOfRecordSets;
        /// <summary>
        /// The maximum number of virtual networks that can be linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double MaxNumberOfVirtualNetworkLinks;
        /// <summary>
        /// The maximum number of virtual networks that can be linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double MaxNumberOfVirtualNetworkLinksWithRegistration;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The current number of record sets in this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double NumberOfRecordSets;
        /// <summary>
        /// The current number of virtual networks that are linked to this Private DNS zone. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double NumberOfVirtualNetworkLinks;
        /// <summary>
        /// The current number of virtual networks that are linked to this Private DNS zone with registration enabled. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly double NumberOfVirtualNetworkLinksWithRegistration;
        /// <summary>
        /// The provisioning state of the resource. This is a read-only property and any attempt to set this value will be ignored.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. Example - 'Microsoft.Network/privateDnsZones'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPrivateZoneResult(
            string? etag,

            string id,

            string? location,

            double maxNumberOfRecordSets,

            double maxNumberOfVirtualNetworkLinks,

            double maxNumberOfVirtualNetworkLinksWithRegistration,

            string name,

            double numberOfRecordSets,

            double numberOfVirtualNetworkLinks,

            double numberOfVirtualNetworkLinksWithRegistration,

            string provisioningState,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Etag = etag;
            Id = id;
            Location = location;
            MaxNumberOfRecordSets = maxNumberOfRecordSets;
            MaxNumberOfVirtualNetworkLinks = maxNumberOfVirtualNetworkLinks;
            MaxNumberOfVirtualNetworkLinksWithRegistration = maxNumberOfVirtualNetworkLinksWithRegistration;
            Name = name;
            NumberOfRecordSets = numberOfRecordSets;
            NumberOfVirtualNetworkLinks = numberOfVirtualNetworkLinks;
            NumberOfVirtualNetworkLinksWithRegistration = numberOfVirtualNetworkLinksWithRegistration;
            ProvisioningState = provisioningState;
            Tags = tags;
            Type = type;
        }
    }
}
