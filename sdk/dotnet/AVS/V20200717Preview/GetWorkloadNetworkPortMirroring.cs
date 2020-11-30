// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AVS.V20200717Preview
{
    public static class GetWorkloadNetworkPortMirroring
    {
        public static Task<GetWorkloadNetworkPortMirroringResult> InvokeAsync(GetWorkloadNetworkPortMirroringArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWorkloadNetworkPortMirroringResult>("azure-nextgen:avs/v20200717preview:getWorkloadNetworkPortMirroring", args ?? new GetWorkloadNetworkPortMirroringArgs(), options.WithVersion());
    }


    public sealed class GetWorkloadNetworkPortMirroringArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// NSX Port Mirroring identifier. Generally the same as the Port Mirroring display name
        /// </summary>
        [Input("portMirroringId", required: true)]
        public string PortMirroringId { get; set; } = null!;

        /// <summary>
        /// Name of the private cloud
        /// </summary>
        [Input("privateCloudName", required: true)]
        public string PrivateCloudName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetWorkloadNetworkPortMirroringArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWorkloadNetworkPortMirroringResult
    {
        /// <summary>
        /// Destination VM Group.
        /// </summary>
        public readonly string? Destination;
        /// <summary>
        /// Direction of port mirroring profile.
        /// </summary>
        public readonly string? Direction;
        /// <summary>
        /// Display name of the port mirroring profile.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// NSX revision number.
        /// </summary>
        public readonly int? Revision;
        /// <summary>
        /// Source VM Group.
        /// </summary>
        public readonly string? Source;
        /// <summary>
        /// Port Mirroring Status.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetWorkloadNetworkPortMirroringResult(
            string? destination,

            string? direction,

            string? displayName,

            string name,

            string provisioningState,

            int? revision,

            string? source,

            string status,

            string type)
        {
            Destination = destination;
            Direction = direction;
            DisplayName = displayName;
            Name = name;
            ProvisioningState = provisioningState;
            Revision = revision;
            Source = source;
            Status = status;
            Type = type;
        }
    }
}