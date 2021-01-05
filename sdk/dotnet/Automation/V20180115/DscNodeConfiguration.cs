// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20180115
{
    /// <summary>
    /// Definition of the dsc node configuration.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:automation/v20180115:DscNodeConfiguration")]
    public partial class DscNodeConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets or sets the configuration of the node.
        /// </summary>
        [Output("configuration")]
        public Output<Outputs.DscConfigurationAssociationPropertyResponse?> Configuration { get; private set; } = null!;

        /// <summary>
        /// Gets or sets creation time.
        /// </summary>
        [Output("creationTime")]
        public Output<string?> CreationTime { get; private set; } = null!;

        /// <summary>
        /// If a new build version of NodeConfiguration is required.
        /// </summary>
        [Output("incrementNodeConfigurationBuild")]
        public Output<bool?> IncrementNodeConfigurationBuild { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string?> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Number of nodes with this node configuration assigned
        /// </summary>
        [Output("nodeCount")]
        public Output<double?> NodeCount { get; private set; } = null!;

        /// <summary>
        /// Source of node configuration.
        /// </summary>
        [Output("source")]
        public Output<string?> Source { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DscNodeConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DscNodeConfiguration(string name, DscNodeConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/v20180115:DscNodeConfiguration", name, args ?? new DscNodeConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DscNodeConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/v20180115:DscNodeConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:automation/latest:DscNodeConfiguration"},
                    new Pulumi.Alias { Type = "azure-nextgen:automation/v20151031:DscNodeConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DscNodeConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DscNodeConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DscNodeConfiguration(name, id, options);
        }
    }

    public sealed class DscNodeConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the configuration of the node.
        /// </summary>
        [Input("configuration", required: true)]
        public Input<Inputs.DscConfigurationAssociationPropertyArgs> Configuration { get; set; } = null!;

        /// <summary>
        /// If a new build version of NodeConfiguration is required.
        /// </summary>
        [Input("incrementNodeConfigurationBuild")]
        public Input<bool>? IncrementNodeConfigurationBuild { get; set; }

        /// <summary>
        /// Name of the node configuration.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Dsc node configuration name.
        /// </summary>
        [Input("nodeConfigurationName", required: true)]
        public Input<string> NodeConfigurationName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [Input("source", required: true)]
        public Input<Inputs.ContentSourceArgs> Source { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Gets or sets the tags attached to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public DscNodeConfigurationArgs()
        {
        }
    }
}
