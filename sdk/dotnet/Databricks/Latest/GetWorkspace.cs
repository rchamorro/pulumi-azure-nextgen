// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Databricks.Latest
{
    public static class GetWorkspace
    {
        public static Task<GetWorkspaceResult> InvokeAsync(GetWorkspaceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetWorkspaceResult>("azure-nextgen:databricks/latest:getWorkspace", args ?? new GetWorkspaceArgs(), options.WithVersion());
    }


    public sealed class GetWorkspaceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetWorkspaceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetWorkspaceResult
    {
        /// <summary>
        /// The workspace provider authorizations.
        /// </summary>
        public readonly ImmutableArray<Outputs.WorkspaceProviderAuthorizationResponse> Authorizations;
        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that created the workspace.
        /// </summary>
        public readonly Outputs.CreatedByResponse? CreatedBy;
        /// <summary>
        /// Specifies the date and time when the workspace is created.
        /// </summary>
        public readonly string? CreatedDateTime;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        public readonly string ManagedResourceGroupId;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The workspace's custom parameters.
        /// </summary>
        public readonly Outputs.WorkspaceCustomParametersResponse? Parameters;
        /// <summary>
        /// The workspace provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// The details of Managed Identity of Storage Account
        /// </summary>
        public readonly Outputs.ManagedIdentityConfigurationResponse? StorageAccountIdentity;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        public readonly string? UiDefinitionUri;
        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that last updated the workspace.
        /// </summary>
        public readonly Outputs.CreatedByResponse? UpdatedBy;
        /// <summary>
        /// The unique identifier of the databricks workspace in databricks control plane.
        /// </summary>
        public readonly string WorkspaceId;
        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        public readonly string WorkspaceUrl;

        [OutputConstructor]
        private GetWorkspaceResult(
            ImmutableArray<Outputs.WorkspaceProviderAuthorizationResponse> authorizations,

            Outputs.CreatedByResponse? createdBy,

            string? createdDateTime,

            string location,

            string managedResourceGroupId,

            string name,

            Outputs.WorkspaceCustomParametersResponse? parameters,

            string provisioningState,

            Outputs.SkuResponse? sku,

            Outputs.ManagedIdentityConfigurationResponse? storageAccountIdentity,

            ImmutableDictionary<string, string>? tags,

            string type,

            string? uiDefinitionUri,

            Outputs.CreatedByResponse? updatedBy,

            string workspaceId,

            string workspaceUrl)
        {
            Authorizations = authorizations;
            CreatedBy = createdBy;
            CreatedDateTime = createdDateTime;
            Location = location;
            ManagedResourceGroupId = managedResourceGroupId;
            Name = name;
            Parameters = parameters;
            ProvisioningState = provisioningState;
            Sku = sku;
            StorageAccountIdentity = storageAccountIdentity;
            Tags = tags;
            Type = type;
            UiDefinitionUri = uiDefinitionUri;
            UpdatedBy = updatedBy;
            WorkspaceId = workspaceId;
            WorkspaceUrl = workspaceUrl;
        }
    }
}