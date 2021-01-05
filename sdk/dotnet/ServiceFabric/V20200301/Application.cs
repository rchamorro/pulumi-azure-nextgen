// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabric.V20200301
{
    /// <summary>
    /// The application resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:servicefabric/v20200301:Application")]
    public partial class Application : Pulumi.CustomResource
    {
        /// <summary>
        /// Azure resource etag.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Describes the managed identities for an Azure resource.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.ManagedIdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// It will be deprecated in New API, resource location depends on the parent resource.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        [Output("managedIdentities")]
        public Output<ImmutableArray<Outputs.ApplicationUserAssignedIdentityResponse>> ManagedIdentities { get; private set; } = null!;

        /// <summary>
        /// The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node.
        /// </summary>
        [Output("maximumNodes")]
        public Output<double?> MaximumNodes { get; private set; } = null!;

        /// <summary>
        /// List of application capacity metric description.
        /// </summary>
        [Output("metrics")]
        public Output<ImmutableArray<Outputs.ApplicationMetricDescriptionResponse>> Metrics { get; private set; } = null!;

        /// <summary>
        /// The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property.
        /// </summary>
        [Output("minimumNodes")]
        public Output<double?> MinimumNodes { get; private set; } = null!;

        /// <summary>
        /// Azure resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The current deployment or provisioning state, which only appears in the response
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Remove the current application capacity settings.
        /// </summary>
        [Output("removeApplicationCapacity")]
        public Output<bool?> RemoveApplicationCapacity { get; private set; } = null!;

        /// <summary>
        /// Azure resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Azure resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The application type name as defined in the application manifest.
        /// </summary>
        [Output("typeName")]
        public Output<string?> TypeName { get; private set; } = null!;

        /// <summary>
        /// The version of the application type as defined in the application manifest.
        /// </summary>
        [Output("typeVersion")]
        public Output<string?> TypeVersion { get; private set; } = null!;

        /// <summary>
        /// Describes the policy for a monitored application upgrade.
        /// </summary>
        [Output("upgradePolicy")]
        public Output<Outputs.ApplicationUpgradePolicyResponse?> UpgradePolicy { get; private set; } = null!;


        /// <summary>
        /// Create a Application resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Application(string name, ApplicationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicefabric/v20200301:Application", name, args ?? new ApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Application(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:servicefabric/v20200301:Application", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/latest:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/v20170701preview:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/v20190301:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/v20190301preview:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/v20190601preview:Application"},
                    new Pulumi.Alias { Type = "azure-nextgen:servicefabric/v20191101preview:Application"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Application resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Application Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Application(name, id, options);
        }
    }

    public sealed class ApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the application resource.
        /// </summary>
        [Input("applicationName", required: true)]
        public Input<string> ApplicationName { get; set; } = null!;

        /// <summary>
        /// The name of the cluster resource.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// Describes the managed identities for an Azure resource.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.ManagedIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// It will be deprecated in New API, resource location depends on the parent resource.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("managedIdentities")]
        private InputList<Inputs.ApplicationUserAssignedIdentityArgs>? _managedIdentities;

        /// <summary>
        /// List of user assigned identities for the application, each mapped to a friendly name.
        /// </summary>
        public InputList<Inputs.ApplicationUserAssignedIdentityArgs> ManagedIdentities
        {
            get => _managedIdentities ?? (_managedIdentities = new InputList<Inputs.ApplicationUserAssignedIdentityArgs>());
            set => _managedIdentities = value;
        }

        /// <summary>
        /// The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. By default, the value of this property is zero and it means that the services can be placed on any node.
        /// </summary>
        [Input("maximumNodes")]
        public Input<double>? MaximumNodes { get; set; }

        [Input("metrics")]
        private InputList<Inputs.ApplicationMetricDescriptionArgs>? _metrics;

        /// <summary>
        /// List of application capacity metric description.
        /// </summary>
        public InputList<Inputs.ApplicationMetricDescriptionArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.ApplicationMetricDescriptionArgs>());
            set => _metrics = value;
        }

        /// <summary>
        /// The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property.
        /// </summary>
        [Input("minimumNodes")]
        public Input<double>? MinimumNodes { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// List of application parameters with overridden values from their default values specified in the application manifest.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        /// <summary>
        /// Remove the current application capacity settings.
        /// </summary>
        [Input("removeApplicationCapacity")]
        public Input<bool>? RemoveApplicationCapacity { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Azure resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The application type name as defined in the application manifest.
        /// </summary>
        [Input("typeName")]
        public Input<string>? TypeName { get; set; }

        /// <summary>
        /// The version of the application type as defined in the application manifest.
        /// </summary>
        [Input("typeVersion")]
        public Input<string>? TypeVersion { get; set; }

        /// <summary>
        /// Describes the policy for a monitored application upgrade.
        /// </summary>
        [Input("upgradePolicy")]
        public Input<Inputs.ApplicationUpgradePolicyArgs>? UpgradePolicy { get; set; }

        public ApplicationArgs()
        {
        }
    }
}
