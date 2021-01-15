// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.Latest
{
    public static class GetMyWorkbook
    {
        public static Task<GetMyWorkbookResult> InvokeAsync(GetMyWorkbookArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMyWorkbookResult>("azure-nextgen:insights/latest:getMyWorkbook", args ?? new GetMyWorkbookArgs(), options.WithVersion());
    }


    public sealed class GetMyWorkbookArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Application Insights component resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        public GetMyWorkbookArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMyWorkbookResult
    {
        /// <summary>
        /// Workbook category, as defined by the user at creation time.
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// The user-defined name of the private workbook.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// Resource etag
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Etag;
        /// <summary>
        /// Azure resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Identity used for BYOS
        /// </summary>
        public readonly Outputs.ManagedIdentityResponse? Identity;
        /// <summary>
        /// The kind of workbook. Choices are user and shared.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Azure resource name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Configuration of this particular private workbook. Configuration data is a string containing valid JSON
        /// </summary>
        public readonly string SerializedData;
        /// <summary>
        /// Optional resourceId for a source resource.
        /// </summary>
        public readonly string? SourceId;
        /// <summary>
        /// BYOS Storage Account URI
        /// </summary>
        public readonly string? StorageUri;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Date and time in UTC of the last modification that was made to this private workbook definition.
        /// </summary>
        public readonly string TimeModified;
        /// <summary>
        /// Azure resource type
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Unique user id of the specific user that owns this private workbook.
        /// </summary>
        public readonly string UserId;
        /// <summary>
        /// This instance's version of the data model. This can change as new features are added that can be marked private workbook.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private GetMyWorkbookResult(
            string category,

            string displayName,

            ImmutableDictionary<string, string>? etag,

            string? id,

            Outputs.ManagedIdentityResponse? identity,

            string? kind,

            string? location,

            string? name,

            string serializedData,

            string? sourceId,

            string? storageUri,

            ImmutableDictionary<string, string>? tags,

            string timeModified,

            string? type,

            string userId,

            string? version)
        {
            Category = category;
            DisplayName = displayName;
            Etag = etag;
            Id = id;
            Identity = identity;
            Kind = kind;
            Location = location;
            Name = name;
            SerializedData = serializedData;
            SourceId = sourceId;
            StorageUri = storageUri;
            Tags = tags;
            TimeModified = timeModified;
            Type = type;
            UserId = userId;
            Version = version;
        }
    }
}
