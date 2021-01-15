// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Attestation.Latest
{
    public static class GetAttestationProvider
    {
        public static Task<GetAttestationProviderResult> InvokeAsync(GetAttestationProviderArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAttestationProviderResult>("azure-nextgen:attestation/latest:getAttestationProvider", args ?? new GetAttestationProviderArgs(), options.WithVersion());
    }


    public sealed class GetAttestationProviderArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the attestation provider.
        /// </summary>
        [Input("providerName", required: true)]
        public string ProviderName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAttestationProviderArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAttestationProviderResult
    {
        /// <summary>
        /// Gets the uri of attestation service
        /// </summary>
        public readonly string? AttestUri;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of private endpoint connections associated with the attestation provider.
        /// </summary>
        public readonly ImmutableArray<Outputs.PrivateEndpointConnectionResponse> PrivateEndpointConnections;
        /// <summary>
        /// Status of attestation service.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The system metadata relating to this resource
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Trust model for the attestation provider.
        /// </summary>
        public readonly string? TrustModel;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAttestationProviderResult(
            string? attestUri,

            string id,

            string location,

            string name,

            ImmutableArray<Outputs.PrivateEndpointConnectionResponse> privateEndpointConnections,

            string? status,

            Outputs.SystemDataResponse systemData,

            ImmutableDictionary<string, string>? tags,

            string? trustModel,

            string type)
        {
            AttestUri = attestUri;
            Id = id;
            Location = location;
            Name = name;
            PrivateEndpointConnections = privateEndpointConnections;
            Status = status;
            SystemData = systemData;
            Tags = tags;
            TrustModel = trustModel;
            Type = type;
        }
    }
}
