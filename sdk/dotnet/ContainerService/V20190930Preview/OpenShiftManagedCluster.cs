// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20190930Preview
{
    /// <summary>
    /// OpenShift Managed cluster.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:containerservice/v20190930preview:OpenShiftManagedCluster")]
    public partial class OpenShiftManagedCluster : Pulumi.CustomResource
    {
        /// <summary>
        /// Configuration of OpenShift cluster VMs.
        /// </summary>
        [Output("agentPoolProfiles")]
        public Output<ImmutableArray<Outputs.OpenShiftManagedClusterAgentPoolProfileResponse>> AgentPoolProfiles { get; private set; } = null!;

        /// <summary>
        /// Configures OpenShift authentication.
        /// </summary>
        [Output("authProfile")]
        public Output<Outputs.OpenShiftManagedClusterAuthProfileResponse?> AuthProfile { get; private set; } = null!;

        /// <summary>
        /// Version of OpenShift specified when creating the cluster.
        /// </summary>
        [Output("clusterVersion")]
        public Output<string> ClusterVersion { get; private set; } = null!;

        /// <summary>
        /// Service generated FQDN for OpenShift API server loadbalancer internal hostname.
        /// </summary>
        [Output("fqdn")]
        public Output<string> Fqdn { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Configuration for OpenShift master VMs.
        /// </summary>
        [Output("masterPoolProfile")]
        public Output<Outputs.OpenShiftManagedClusterMasterPoolProfileResponse?> MasterPoolProfile { get; private set; } = null!;

        /// <summary>
        /// Configures Log Analytics integration.
        /// </summary>
        [Output("monitorProfile")]
        public Output<Outputs.OpenShiftManagedClusterMonitorProfileResponse?> MonitorProfile { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configuration for OpenShift networking.
        /// </summary>
        [Output("networkProfile")]
        public Output<Outputs.NetworkProfileResponse?> NetworkProfile { get; private set; } = null!;

        /// <summary>
        /// Version of OpenShift specified when creating the cluster.
        /// </summary>
        [Output("openShiftVersion")]
        public Output<string> OpenShiftVersion { get; private set; } = null!;

        /// <summary>
        /// Define the resource plan as required by ARM for billing purposes
        /// </summary>
        [Output("plan")]
        public Output<Outputs.PurchasePlanResponse?> Plan { get; private set; } = null!;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Service generated FQDN for OpenShift API server.
        /// </summary>
        [Output("publicHostname")]
        public Output<string> PublicHostname { get; private set; } = null!;

        /// <summary>
        /// Configuration for OpenShift router(s).
        /// </summary>
        [Output("routerProfiles")]
        public Output<ImmutableArray<Outputs.OpenShiftRouterProfileResponse>> RouterProfiles { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a OpenShiftManagedCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OpenShiftManagedCluster(string name, OpenShiftManagedClusterArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:containerservice/v20190930preview:OpenShiftManagedCluster", name, args ?? new OpenShiftManagedClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OpenShiftManagedCluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:containerservice/v20190930preview:OpenShiftManagedCluster", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:containerservice/latest:OpenShiftManagedCluster"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerservice/v20180930preview:OpenShiftManagedCluster"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerservice/v20190430:OpenShiftManagedCluster"},
                    new Pulumi.Alias { Type = "azure-nextgen:containerservice/v20191027preview:OpenShiftManagedCluster"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing OpenShiftManagedCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OpenShiftManagedCluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new OpenShiftManagedCluster(name, id, options);
        }
    }

    public sealed class OpenShiftManagedClusterArgs : Pulumi.ResourceArgs
    {
        [Input("agentPoolProfiles")]
        private InputList<Inputs.OpenShiftManagedClusterAgentPoolProfileArgs>? _agentPoolProfiles;

        /// <summary>
        /// Configuration of OpenShift cluster VMs.
        /// </summary>
        public InputList<Inputs.OpenShiftManagedClusterAgentPoolProfileArgs> AgentPoolProfiles
        {
            get => _agentPoolProfiles ?? (_agentPoolProfiles = new InputList<Inputs.OpenShiftManagedClusterAgentPoolProfileArgs>());
            set => _agentPoolProfiles = value;
        }

        /// <summary>
        /// Configures OpenShift authentication.
        /// </summary>
        [Input("authProfile")]
        public Input<Inputs.OpenShiftManagedClusterAuthProfileArgs>? AuthProfile { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Configuration for OpenShift master VMs.
        /// </summary>
        [Input("masterPoolProfile")]
        public Input<Inputs.OpenShiftManagedClusterMasterPoolProfileArgs>? MasterPoolProfile { get; set; }

        /// <summary>
        /// Configures Log Analytics integration.
        /// </summary>
        [Input("monitorProfile")]
        public Input<Inputs.OpenShiftManagedClusterMonitorProfileArgs>? MonitorProfile { get; set; }

        /// <summary>
        /// Configuration for OpenShift networking.
        /// </summary>
        [Input("networkProfile")]
        public Input<Inputs.NetworkProfileArgs>? NetworkProfile { get; set; }

        /// <summary>
        /// Version of OpenShift specified when creating the cluster.
        /// </summary>
        [Input("openShiftVersion", required: true)]
        public Input<string> OpenShiftVersion { get; set; } = null!;

        /// <summary>
        /// Define the resource plan as required by ARM for billing purposes
        /// </summary>
        [Input("plan")]
        public Input<Inputs.PurchasePlanArgs>? Plan { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the OpenShift managed cluster resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        [Input("routerProfiles")]
        private InputList<Inputs.OpenShiftRouterProfileArgs>? _routerProfiles;

        /// <summary>
        /// Configuration for OpenShift router(s).
        /// </summary>
        public InputList<Inputs.OpenShiftRouterProfileArgs> RouterProfiles
        {
            get => _routerProfiles ?? (_routerProfiles = new InputList<Inputs.OpenShiftRouterProfileArgs>());
            set => _routerProfiles = value;
        }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public OpenShiftManagedClusterArgs()
        {
        }
    }
}
