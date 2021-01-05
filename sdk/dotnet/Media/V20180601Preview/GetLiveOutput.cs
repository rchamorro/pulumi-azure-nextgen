// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview
{
    public static class GetLiveOutput
    {
        public static Task<GetLiveOutputResult> InvokeAsync(GetLiveOutputArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLiveOutputResult>("azure-nextgen:media/v20180601preview:getLiveOutput", args ?? new GetLiveOutputArgs(), options.WithVersion());
    }


    public sealed class GetLiveOutputArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the Live Event.
        /// </summary>
        [Input("liveEventName", required: true)]
        public string LiveEventName { get; set; } = null!;

        /// <summary>
        /// The name of the Live Output.
        /// </summary>
        [Input("liveOutputName", required: true)]
        public string LiveOutputName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetLiveOutputArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetLiveOutputResult
    {
        /// <summary>
        /// ISO 8601 timespan duration of the archive window length. This is duration that customer want to retain the recorded content.
        /// </summary>
        public readonly string ArchiveWindowLength;
        /// <summary>
        /// The asset name.
        /// </summary>
        public readonly string AssetName;
        /// <summary>
        /// The exact time the Live Output was created.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// The description of the Live Output.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The HLS configuration.
        /// </summary>
        public readonly Outputs.HlsResponse? Hls;
        /// <summary>
        /// Fully qualified resource ID for the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The exact time the Live Output was last modified.
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// The manifest file name.
        /// </summary>
        public readonly string? ManifestName;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The output snapshot time.
        /// </summary>
        public readonly double? OutputSnapTime;
        /// <summary>
        /// The provisioning state of the Live Output.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource state of the Live Output.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetLiveOutputResult(
            string archiveWindowLength,

            string assetName,

            string created,

            string? description,

            Outputs.HlsResponse? hls,

            string id,

            string lastModified,

            string? manifestName,

            string name,

            double? outputSnapTime,

            string provisioningState,

            string resourceState,

            string type)
        {
            ArchiveWindowLength = archiveWindowLength;
            AssetName = assetName;
            Created = created;
            Description = description;
            Hls = hls;
            Id = id;
            LastModified = lastModified;
            ManifestName = manifestName;
            Name = name;
            OutputSnapTime = outputSnapTime;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            Type = type;
        }
    }
}
