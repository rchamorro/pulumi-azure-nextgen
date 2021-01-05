// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview
{
    public static class GetStreamingEndpoint
    {
        public static Task<GetStreamingEndpointResult> InvokeAsync(GetStreamingEndpointArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStreamingEndpointResult>("azure-nextgen:media/v20180601preview:getStreamingEndpoint", args ?? new GetStreamingEndpointArgs(), options.WithVersion());
    }


    public sealed class GetStreamingEndpointArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the StreamingEndpoint.
        /// </summary>
        [Input("streamingEndpointName", required: true)]
        public string StreamingEndpointName { get; set; } = null!;

        public GetStreamingEndpointArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStreamingEndpointResult
    {
        /// <summary>
        /// The access control definition of the StreamingEndpoint.
        /// </summary>
        public readonly Outputs.StreamingEndpointAccessControlResponse? AccessControl;
        /// <summary>
        /// AvailabilitySet name
        /// </summary>
        public readonly string? AvailabilitySetName;
        /// <summary>
        /// The CDN enabled flag.
        /// </summary>
        public readonly bool? CdnEnabled;
        /// <summary>
        /// The CDN profile name.
        /// </summary>
        public readonly string? CdnProfile;
        /// <summary>
        /// The CDN provider name.
        /// </summary>
        public readonly string? CdnProvider;
        /// <summary>
        /// The exact time the StreamingEndpoint was created.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// The StreamingEndpoint access policies.
        /// </summary>
        public readonly Outputs.CrossSiteAccessPoliciesResponse? CrossSiteAccessPolicies;
        /// <summary>
        /// The custom host names of the StreamingEndpoint
        /// </summary>
        public readonly ImmutableArray<string> CustomHostNames;
        /// <summary>
        /// The StreamingEndpoint description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The free trial expiration time.
        /// </summary>
        public readonly string FreeTrialEndTime;
        /// <summary>
        /// The StreamingEndpoint host name.
        /// </summary>
        public readonly string HostName;
        /// <summary>
        /// Fully qualified resource ID for the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The exact time the StreamingEndpoint was last modified.
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// The Azure Region of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Max cache age
        /// </summary>
        public readonly double? MaxCacheAge;
        /// <summary>
        /// The name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the StreamingEndpoint.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The resource state of the StreamingEndpoint.
        /// </summary>
        public readonly string ResourceState;
        /// <summary>
        /// The number of scale units.
        /// </summary>
        public readonly int? ScaleUnits;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStreamingEndpointResult(
            Outputs.StreamingEndpointAccessControlResponse? accessControl,

            string? availabilitySetName,

            bool? cdnEnabled,

            string? cdnProfile,

            string? cdnProvider,

            string created,

            Outputs.CrossSiteAccessPoliciesResponse? crossSiteAccessPolicies,

            ImmutableArray<string> customHostNames,

            string? description,

            string freeTrialEndTime,

            string hostName,

            string id,

            string lastModified,

            string? location,

            double? maxCacheAge,

            string name,

            string provisioningState,

            string resourceState,

            int? scaleUnits,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            AccessControl = accessControl;
            AvailabilitySetName = availabilitySetName;
            CdnEnabled = cdnEnabled;
            CdnProfile = cdnProfile;
            CdnProvider = cdnProvider;
            Created = created;
            CrossSiteAccessPolicies = crossSiteAccessPolicies;
            CustomHostNames = customHostNames;
            Description = description;
            FreeTrialEndTime = freeTrialEndTime;
            HostName = hostName;
            Id = id;
            LastModified = lastModified;
            Location = location;
            MaxCacheAge = maxCacheAge;
            Name = name;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            ScaleUnits = scaleUnits;
            Tags = tags;
            Type = type;
        }
    }
}
