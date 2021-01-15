// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.KubernetesConfiguration.V20201001Preview
{
    /// <summary>
    /// The SourceControl Configuration object returned in Get &amp; Put response.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:kubernetesconfiguration/v20201001preview:SourceControlConfiguration")]
    public partial class SourceControlConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Compliance Status of the Configuration
        /// </summary>
        [Output("complianceStatus")]
        public Output<Outputs.ComplianceStatusResponse> ComplianceStatus { get; private set; } = null!;

        /// <summary>
        /// Name-value pairs of protected configuration settings for the configuration
        /// </summary>
        [Output("configurationProtectedSettings")]
        public Output<ImmutableDictionary<string, string>?> ConfigurationProtectedSettings { get; private set; } = null!;

        /// <summary>
        /// Option to enable Helm Operator for this git configuration.
        /// </summary>
        [Output("enableHelmOperator")]
        public Output<bool?> EnableHelmOperator { get; private set; } = null!;

        /// <summary>
        /// Properties for Helm operator.
        /// </summary>
        [Output("helmOperatorProperties")]
        public Output<Outputs.HelmOperatorPropertiesResponse?> HelmOperatorProperties { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Instance name of the operator - identifying the specific configuration.
        /// </summary>
        [Output("operatorInstanceName")]
        public Output<string?> OperatorInstanceName { get; private set; } = null!;

        /// <summary>
        /// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
        /// </summary>
        [Output("operatorNamespace")]
        public Output<string?> OperatorNamespace { get; private set; } = null!;

        /// <summary>
        /// Any Parameters for the Operator instance in string format.
        /// </summary>
        [Output("operatorParams")]
        public Output<string?> OperatorParams { get; private set; } = null!;

        /// <summary>
        /// Scope at which the operator will be installed.
        /// </summary>
        [Output("operatorScope")]
        public Output<string?> OperatorScope { get; private set; } = null!;

        /// <summary>
        /// Type of the operator
        /// </summary>
        [Output("operatorType")]
        public Output<string?> OperatorType { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource provider.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Public Key associated with this SourceControl configuration (either generated within the cluster or provided by the user).
        /// </summary>
        [Output("repositoryPublicKey")]
        public Output<string> RepositoryPublicKey { get; private set; } = null!;

        /// <summary>
        /// Url of the SourceControl Repository.
        /// </summary>
        [Output("repositoryUrl")]
        public Output<string?> RepositoryUrl { get; private set; } = null!;

        /// <summary>
        /// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
        /// </summary>
        [Output("sshKnownHostsContents")]
        public Output<string?> SshKnownHostsContents { get; private set; } = null!;

        /// <summary>
        /// Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse?> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a SourceControlConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SourceControlConfiguration(string name, SourceControlConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:kubernetesconfiguration/v20201001preview:SourceControlConfiguration", name, args ?? new SourceControlConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SourceControlConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:kubernetesconfiguration/v20201001preview:SourceControlConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:kubernetesconfiguration/v20191101preview:SourceControlConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SourceControlConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SourceControlConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SourceControlConfiguration(name, id, options);
        }
    }

    public sealed class SourceControlConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the kubernetes cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        /// <summary>
        /// The Kubernetes cluster resource name - either managedClusters (for AKS clusters) or connectedClusters (for OnPrem K8S clusters).
        /// </summary>
        [Input("clusterResourceName", required: true)]
        public Input<string> ClusterResourceName { get; set; } = null!;

        /// <summary>
        /// The Kubernetes cluster RP - either Microsoft.ContainerService (for AKS clusters) or Microsoft.Kubernetes (for OnPrem K8S clusters).
        /// </summary>
        [Input("clusterRp", required: true)]
        public Input<string> ClusterRp { get; set; } = null!;

        [Input("configurationProtectedSettings")]
        private InputMap<string>? _configurationProtectedSettings;

        /// <summary>
        /// Name-value pairs of protected configuration settings for the configuration
        /// </summary>
        public InputMap<string> ConfigurationProtectedSettings
        {
            get => _configurationProtectedSettings ?? (_configurationProtectedSettings = new InputMap<string>());
            set => _configurationProtectedSettings = value;
        }

        /// <summary>
        /// Option to enable Helm Operator for this git configuration.
        /// </summary>
        [Input("enableHelmOperator")]
        public Input<bool>? EnableHelmOperator { get; set; }

        /// <summary>
        /// Properties for Helm operator.
        /// </summary>
        [Input("helmOperatorProperties")]
        public Input<Inputs.HelmOperatorPropertiesArgs>? HelmOperatorProperties { get; set; }

        /// <summary>
        /// Instance name of the operator - identifying the specific configuration.
        /// </summary>
        [Input("operatorInstanceName")]
        public Input<string>? OperatorInstanceName { get; set; }

        /// <summary>
        /// The namespace to which this operator is installed to. Maximum of 253 lower case alphanumeric characters, hyphen and period only.
        /// </summary>
        [Input("operatorNamespace")]
        public Input<string>? OperatorNamespace { get; set; }

        /// <summary>
        /// Any Parameters for the Operator instance in string format.
        /// </summary>
        [Input("operatorParams")]
        public Input<string>? OperatorParams { get; set; }

        /// <summary>
        /// Scope at which the operator will be installed.
        /// </summary>
        [Input("operatorScope")]
        public InputUnion<string, Pulumi.AzureNextGen.KubernetesConfiguration.V20201001Preview.OperatorScopeType>? OperatorScope { get; set; }

        /// <summary>
        /// Type of the operator
        /// </summary>
        [Input("operatorType")]
        public InputUnion<string, Pulumi.AzureNextGen.KubernetesConfiguration.V20201001Preview.OperatorType>? OperatorType { get; set; }

        /// <summary>
        /// Url of the SourceControl Repository.
        /// </summary>
        [Input("repositoryUrl")]
        public Input<string>? RepositoryUrl { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Source Control Configuration.
        /// </summary>
        [Input("sourceControlConfigurationName", required: true)]
        public Input<string> SourceControlConfigurationName { get; set; } = null!;

        /// <summary>
        /// Base64-encoded known_hosts contents containing public SSH keys required to access private Git instances
        /// </summary>
        [Input("sshKnownHostsContents")]
        public Input<string>? SshKnownHostsContents { get; set; }

        public SourceControlConfigurationArgs()
        {
            OperatorNamespace = "default";
        }
    }
}
