// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201
{
    public static class GetApiIssueComment
    {
        public static Task<GetApiIssueCommentResult> InvokeAsync(GetApiIssueCommentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiIssueCommentResult>("azure-nextgen:apimanagement/v20191201:getApiIssueComment", args ?? new GetApiIssueCommentArgs(), options.WithVersion());
    }


    public sealed class GetApiIssueCommentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// API identifier. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

        /// <summary>
        /// Comment identifier within an Issue. Must be unique in the current Issue.
        /// </summary>
        [Input("commentId", required: true)]
        public string CommentId { get; set; } = null!;

        /// <summary>
        /// Issue identifier. Must be unique in the current API Management service instance.
        /// </summary>
        [Input("issueId", required: true)]
        public string IssueId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management service.
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetApiIssueCommentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiIssueCommentResult
    {
        /// <summary>
        /// Date and time when the comment was created.
        /// </summary>
        public readonly string? CreatedDate;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Comment text.
        /// </summary>
        public readonly string Text;
        /// <summary>
        /// Resource type for API Management resource.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// A resource identifier for the user who left the comment.
        /// </summary>
        public readonly string UserId;

        [OutputConstructor]
        private GetApiIssueCommentResult(
            string? createdDate,

            string name,

            string text,

            string type,

            string userId)
        {
            CreatedDate = createdDate;
            Name = name;
            Text = text;
            Type = type;
            UserId = userId;
        }
    }
}