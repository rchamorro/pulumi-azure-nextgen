// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200601
{
    public static class GetVirtualHubBgpConnection
    {
        public static Task<GetVirtualHubBgpConnectionResult> InvokeAsync(GetVirtualHubBgpConnectionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualHubBgpConnectionResult>("azure-nextgen:network/v20200601:getVirtualHubBgpConnection", args ?? new GetVirtualHubBgpConnectionArgs(), options.WithVersion());
    }


    public sealed class GetVirtualHubBgpConnectionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the connection.
        /// </summary>
        [Input("connectionName", required: true)]
        public string ConnectionName { get; set; } = null!;

        /// <summary>
        /// The resource group name of the VirtualHub.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the VirtualHub.
        /// </summary>
        [Input("virtualHubName", required: true)]
        public string VirtualHubName { get; set; } = null!;

        public GetVirtualHubBgpConnectionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualHubBgpConnectionResult
    {
        /// <summary>
        /// The current state of the VirtualHub to Peer.
        /// </summary>
        public readonly string ConnectionState;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the connection.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Peer ASN.
        /// </summary>
        public readonly double? PeerAsn;
        /// <summary>
        /// Peer IP.
        /// </summary>
        public readonly string? PeerIp;
        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Connection type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetVirtualHubBgpConnectionResult(
            string connectionState,

            string etag,

            string? id,

            string? name,

            double? peerAsn,

            string? peerIp,

            string provisioningState,

            string type)
        {
            ConnectionState = connectionState;
            Etag = etag;
            Id = id;
            Name = name;
            PeerAsn = peerAsn;
            PeerIp = peerIp;
            ProvisioningState = provisioningState;
            Type = type;
        }
    }
}
