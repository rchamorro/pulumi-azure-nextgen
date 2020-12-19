// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Databricks.Latest
{
    /// <summary>
    /// Information about workspace.
    /// Latest API Version: 2018-04-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:databricks/latest:Workspace")]
    public partial class Workspace : Pulumi.CustomResource
    {
        /// <summary>
        /// The workspace provider authorizations.
        /// </summary>
        [Output("authorizations")]
        public Output<ImmutableArray<Outputs.WorkspaceProviderAuthorizationResponse>> Authorizations { get; private set; } = null!;

        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that created the workspace.
        /// </summary>
        [Output("createdBy")]
        public Output<Outputs.CreatedByResponse?> CreatedBy { get; private set; } = null!;

        /// <summary>
        /// Specifies the date and time when the workspace is created.
        /// </summary>
        [Output("createdDateTime")]
        public Output<string> CreatedDateTime { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Output("managedResourceGroupId")]
        public Output<string> ManagedResourceGroupId { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The workspace's custom parameters.
        /// </summary>
        [Output("parameters")]
        public Output<Outputs.WorkspaceCustomParametersResponse?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The workspace provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// The details of Managed Identity of Storage Account
        /// </summary>
        [Output("storageAccountIdentity")]
        public Output<Outputs.ManagedIdentityConfigurationResponse?> StorageAccountIdentity { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        [Output("uiDefinitionUri")]
        public Output<string?> UiDefinitionUri { get; private set; } = null!;

        /// <summary>
        /// Indicates the Object ID, PUID and Application ID of entity that last updated the workspace.
        /// </summary>
        [Output("updatedBy")]
        public Output<Outputs.CreatedByResponse?> UpdatedBy { get; private set; } = null!;

        /// <summary>
        /// The unique identifier of the databricks workspace in databricks control plane.
        /// </summary>
        [Output("workspaceId")]
        public Output<string> WorkspaceId { get; private set; } = null!;

        /// <summary>
        /// The workspace URL which is of the format 'adb-{workspaceId}.{random}.azuredatabricks.net'
        /// </summary>
        [Output("workspaceUrl")]
        public Output<string> WorkspaceUrl { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:databricks/latest:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:databricks/latest:Workspace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:databricks/v20180401:Workspace"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workspace resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workspace Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workspace(name, id, options);
        }
    }

    public sealed class WorkspaceArgs : Pulumi.ResourceArgs
    {
        [Input("authorizations")]
        private InputList<Inputs.WorkspaceProviderAuthorizationArgs>? _authorizations;

        /// <summary>
        /// The workspace provider authorizations.
        /// </summary>
        public InputList<Inputs.WorkspaceProviderAuthorizationArgs> Authorizations
        {
            get => _authorizations ?? (_authorizations = new InputList<Inputs.WorkspaceProviderAuthorizationArgs>());
            set => _authorizations = value;
        }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The managed resource group Id.
        /// </summary>
        [Input("managedResourceGroupId", required: true)]
        public Input<string> ManagedResourceGroupId { get; set; } = null!;

        /// <summary>
        /// The workspace's custom parameters.
        /// </summary>
        [Input("parameters")]
        public Input<Inputs.WorkspaceCustomParametersArgs>? Parameters { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The SKU of the resource.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The blob URI where the UI definition file is located.
        /// </summary>
        [Input("uiDefinitionUri")]
        public Input<string>? UiDefinitionUri { get; set; }

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public WorkspaceArgs()
        {
        }
    }
}
