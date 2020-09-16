// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20190501
{
    /// <summary>
    /// The integration service environment.
    /// </summary>
    public partial class IntegrationServiceEnvironment : Pulumi.CustomResource
    {
        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The integration service environment properties.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.IntegrationServiceEnvironmentPropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// The sku.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.IntegrationServiceEnvironmentSkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IntegrationServiceEnvironment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IntegrationServiceEnvironment(string name, IntegrationServiceEnvironmentArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20190501:IntegrationServiceEnvironment", name, args ?? new IntegrationServiceEnvironmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IntegrationServiceEnvironment(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/v20190501:IntegrationServiceEnvironment", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:logic/latest:IntegrationServiceEnvironment"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IntegrationServiceEnvironment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IntegrationServiceEnvironment Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IntegrationServiceEnvironment(name, id, options);
        }
    }

    public sealed class IntegrationServiceEnvironmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The integration service environment name.
        /// </summary>
        [Input("integrationServiceEnvironmentName", required: true)]
        public Input<string> IntegrationServiceEnvironmentName { get; set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The integration service environment properties.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.IntegrationServiceEnvironmentPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// The resource group.
        /// </summary>
        [Input("resourceGroup", required: true)]
        public Input<string> ResourceGroup { get; set; } = null!;

        /// <summary>
        /// The sku.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.IntegrationServiceEnvironmentSkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public IntegrationServiceEnvironmentArgs()
        {
        }
    }
}