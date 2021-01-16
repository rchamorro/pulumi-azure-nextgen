// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RedHatOpenShift.V20200430
{
    /// <summary>
    /// OpenShiftCluster represents an Azure Red Hat OpenShift cluster.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:redhatopenshift/v20200430:OpenShiftCluster")]
    public partial class OpenShiftCluster : Pulumi.CustomResource
    {
        /// <summary>
        /// The cluster API server profile.
        /// </summary>
        [Output("apiserverProfile")]
        public Output<Outputs.APIServerProfileResponse?> ApiserverProfile { get; private set; } = null!;

        /// <summary>
        /// The cluster profile.
        /// </summary>
        [Output("clusterProfile")]
        public Output<Outputs.ClusterProfileResponse?> ClusterProfile { get; private set; } = null!;

        /// <summary>
        /// The console profile.
        /// </summary>
        [Output("consoleProfile")]
        public Output<Outputs.ConsoleProfileResponse?> ConsoleProfile { get; private set; } = null!;

        /// <summary>
        /// The cluster ingress profiles.
        /// </summary>
        [Output("ingressProfiles")]
        public Output<ImmutableArray<Outputs.IngressProfileResponse>> IngressProfiles { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The cluster master profile.
        /// </summary>
        [Output("masterProfile")]
        public Output<Outputs.MasterProfileResponse?> MasterProfile { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The cluster network profile.
        /// </summary>
        [Output("networkProfile")]
        public Output<Outputs.NetworkProfileResponse?> NetworkProfile { get; private set; } = null!;

        /// <summary>
        /// The cluster provisioning state (immutable).
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The cluster service principal profile.
        /// </summary>
        [Output("servicePrincipalProfile")]
        public Output<Outputs.ServicePrincipalProfileResponse?> ServicePrincipalProfile { get; private set; } = null!;

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
        /// The cluster worker profiles.
        /// </summary>
        [Output("workerProfiles")]
        public Output<ImmutableArray<Outputs.WorkerProfileResponse>> WorkerProfiles { get; private set; } = null!;


        /// <summary>
        /// Create a OpenShiftCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OpenShiftCluster(string name, OpenShiftClusterArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:redhatopenshift/v20200430:OpenShiftCluster", name, args ?? new OpenShiftClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OpenShiftCluster(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:redhatopenshift/v20200430:OpenShiftCluster", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:redhatopenshift/latest:OpenShiftCluster"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing OpenShiftCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OpenShiftCluster Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new OpenShiftCluster(name, id, options);
        }
    }

    public sealed class OpenShiftClusterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The cluster API server profile.
        /// </summary>
        [Input("apiserverProfile")]
        public Input<Inputs.APIServerProfileArgs>? ApiserverProfile { get; set; }

        /// <summary>
        /// The cluster profile.
        /// </summary>
        [Input("clusterProfile")]
        public Input<Inputs.ClusterProfileArgs>? ClusterProfile { get; set; }

        /// <summary>
        /// The console profile.
        /// </summary>
        [Input("consoleProfile")]
        public Input<Inputs.ConsoleProfileArgs>? ConsoleProfile { get; set; }

        [Input("ingressProfiles")]
        private InputList<Inputs.IngressProfileArgs>? _ingressProfiles;

        /// <summary>
        /// The cluster ingress profiles.
        /// </summary>
        public InputList<Inputs.IngressProfileArgs> IngressProfiles
        {
            get => _ingressProfiles ?? (_ingressProfiles = new InputList<Inputs.IngressProfileArgs>());
            set => _ingressProfiles = value;
        }

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The cluster master profile.
        /// </summary>
        [Input("masterProfile")]
        public Input<Inputs.MasterProfileArgs>? MasterProfile { get; set; }

        /// <summary>
        /// The cluster network profile.
        /// </summary>
        [Input("networkProfile")]
        public Input<Inputs.NetworkProfileArgs>? NetworkProfile { get; set; }

        /// <summary>
        /// The cluster provisioning state (immutable).
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the OpenShift cluster resource.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        /// <summary>
        /// The cluster service principal profile.
        /// </summary>
        [Input("servicePrincipalProfile")]
        public Input<Inputs.ServicePrincipalProfileArgs>? ServicePrincipalProfile { get; set; }

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

        [Input("workerProfiles")]
        private InputList<Inputs.WorkerProfileArgs>? _workerProfiles;

        /// <summary>
        /// The cluster worker profiles.
        /// </summary>
        public InputList<Inputs.WorkerProfileArgs> WorkerProfiles
        {
            get => _workerProfiles ?? (_workerProfiles = new InputList<Inputs.WorkerProfileArgs>());
            set => _workerProfiles = value;
        }

        public OpenShiftClusterArgs()
        {
        }
    }
}
