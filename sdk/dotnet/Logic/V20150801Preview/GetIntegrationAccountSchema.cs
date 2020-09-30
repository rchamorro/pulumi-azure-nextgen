// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20150801Preview
{
    public static class GetIntegrationAccountSchema
    {
        public static Task<GetIntegrationAccountSchemaResult> InvokeAsync(GetIntegrationAccountSchemaArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIntegrationAccountSchemaResult>("azure-nextgen:logic/v20150801preview:getIntegrationAccountSchema", args ?? new GetIntegrationAccountSchemaArgs(), options.WithVersion());
    }


    public sealed class GetIntegrationAccountSchemaArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The integration account name.
        /// </summary>
        [Input("integrationAccountName", required: true)]
        public string IntegrationAccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The integration account schema name.
        /// </summary>
        [Input("schemaName", required: true)]
        public string SchemaName { get; set; } = null!;

        public GetIntegrationAccountSchemaArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIntegrationAccountSchemaResult
    {
        /// <summary>
        /// The changed time.
        /// </summary>
        public readonly string ChangedTime;
        /// <summary>
        /// The content.
        /// </summary>
        public readonly object? Content;
        /// <summary>
        /// The content link.
        /// </summary>
        public readonly Outputs.IntegrationAccountContentLinkResponse ContentLink;
        /// <summary>
        /// The content type.
        /// </summary>
        public readonly string? ContentType;
        /// <summary>
        /// The created time.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// The resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The schema type.
        /// </summary>
        public readonly string? SchemaType;
        /// <summary>
        /// The resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The target namespace.
        /// </summary>
        public readonly string? TargetNamespace;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GetIntegrationAccountSchemaResult(
            string changedTime,

            object? content,

            Outputs.IntegrationAccountContentLinkResponse contentLink,

            string? contentType,

            string createdTime,

            string? location,

            object? metadata,

            string? name,

            string? schemaType,

            ImmutableDictionary<string, string>? tags,

            string? targetNamespace,

            string? type)
        {
            ChangedTime = changedTime;
            Content = content;
            ContentLink = contentLink;
            ContentType = contentType;
            CreatedTime = createdTime;
            Location = location;
            Metadata = metadata;
            Name = name;
            SchemaType = schemaType;
            Tags = tags;
            TargetNamespace = targetNamespace;
            Type = type;
        }
    }
}
