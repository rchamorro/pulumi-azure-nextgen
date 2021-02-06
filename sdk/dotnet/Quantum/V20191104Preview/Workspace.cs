// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Quantum.V20191104Preview
{
    /// <summary>
    /// The resource proxy definition object for quantum workspace.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:quantum/v20191104preview:Workspace")]
    public partial class Workspace : Pulumi.CustomResource
    {
        /// <summary>
        /// The URI of the workspace endpoint.
        /// </summary>
        [Output("endpointUri")]
        public Output<string> EndpointUri { get; private set; } = null!;

        /// <summary>
        /// Managed Identity information.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.QuantumWorkspaceResponseIdentity?> Identity { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of Providers selected for this Workspace
        /// </summary>
        [Output("providers")]
        public Output<ImmutableArray<Outputs.ProviderResponse>> Providers { get; private set; } = null!;

        /// <summary>
        /// Provisioning status field
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// ARM Resource Id of the storage account associated with this workspace.
        /// </summary>
        [Output("storageAccount")]
        public Output<string?> StorageAccount { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Whether the current workspace is ready to accept Jobs.
        /// </summary>
        [Output("usable")]
        public Output<string> Usable { get; private set; } = null!;


        /// <summary>
        /// Create a Workspace resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workspace(string name, WorkspaceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:quantum/v20191104preview:Workspace", name, args ?? new WorkspaceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workspace(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:quantum/v20191104preview:Workspace", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
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
        /// <summary>
        /// Managed Identity information.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.QuantumWorkspaceIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("providers")]
        private InputList<Inputs.ProviderArgs>? _providers;

        /// <summary>
        /// List of Providers selected for this Workspace
        /// </summary>
        public InputList<Inputs.ProviderArgs> Providers
        {
            get => _providers ?? (_providers = new InputList<Inputs.ProviderArgs>());
            set => _providers = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// ARM Resource Id of the storage account associated with this workspace.
        /// </summary>
        [Input("storageAccount")]
        public Input<string>? StorageAccount { get; set; }

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
        /// The name of the quantum workspace resource.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public WorkspaceArgs()
        {
        }
    }
}
