// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20151031
{
    /// <summary>
    /// Definition of the configuration type.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:automation/v20151031:DscConfiguration")]
    public partial class DscConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        [Output("creationTime")]
        public Output<string?> CreationTime { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the etag of the resource.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the job count of the configuration.
        /// </summary>
        [Output("jobCount")]
        public Output<int?> JobCount { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        [Output("lastModifiedTime")]
        public Output<string?> LastModifiedTime { get; private set; } = null!;

        /// <summary>
        /// The Azure Region where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Gets or sets verbose log option.
        /// </summary>
        [Output("logVerbose")]
        public Output<bool?> LogVerbose { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Gets the number of compiled node configurations.
        /// </summary>
        [Output("nodeConfigurationCount")]
        public Output<int?> NodeConfigurationCount { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the configuration parameters.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, Outputs.DscConfigurationParameterResponse>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the provisioning state of the configuration.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [Output("source")]
        public Output<Outputs.ContentSourceResponse?> Source { get; private set; } = null!;

        /// <summary>
        /// Gets or sets the state of the configuration.
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DscConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DscConfiguration(string name, DscConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/v20151031:DscConfiguration", name, args ?? new DscConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DscConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:automation/v20151031:DscConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:automation/latest:DscConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DscConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DscConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DscConfiguration(name, id, options);
        }
    }

    public sealed class DscConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The create or update parameters for configuration.
        /// </summary>
        [Input("configurationName", required: true)]
        public Input<string> ConfigurationName { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description of the configuration.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Gets or sets progress log option.
        /// </summary>
        [Input("logProgress")]
        public Input<bool>? LogProgress { get; set; }

        /// <summary>
        /// Gets or sets verbose log option.
        /// </summary>
        [Input("logVerbose")]
        public Input<bool>? LogVerbose { get; set; }

        /// <summary>
        /// Gets or sets name of the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.DscConfigurationParameterArgs>? _parameters;

        /// <summary>
        /// Gets or sets the configuration parameters.
        /// </summary>
        public InputMap<Inputs.DscConfigurationParameterArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.DscConfigurationParameterArgs>());
            set => _parameters = value;
        }

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

        public DscConfigurationArgs()
        {
        }
    }
}
