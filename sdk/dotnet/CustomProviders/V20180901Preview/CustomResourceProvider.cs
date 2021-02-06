// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomProviders.V20180901Preview
{
    /// <summary>
    /// A manifest file that defines the custom resource provider resources.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:customproviders/v20180901preview:CustomResourceProvider")]
    public partial class CustomResourceProvider : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of actions that the custom resource provider implements.
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<Outputs.CustomRPActionRouteDefinitionResponse>> Actions { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource provider.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// A list of resource types that the custom resource provider implements.
        /// </summary>
        [Output("resourceTypes")]
        public Output<ImmutableArray<Outputs.CustomRPResourceTypeRouteDefinitionResponse>> ResourceTypes { get; private set; } = null!;

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
        /// A list of validations to run on the custom resource provider's requests.
        /// </summary>
        [Output("validations")]
        public Output<ImmutableArray<Outputs.CustomRPValidationsResponse>> Validations { get; private set; } = null!;


        /// <summary>
        /// Create a CustomResourceProvider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomResourceProvider(string name, CustomResourceProviderArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:customproviders/v20180901preview:CustomResourceProvider", name, args ?? new CustomResourceProviderArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomResourceProvider(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:customproviders/v20180901preview:CustomResourceProvider", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing CustomResourceProvider resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomResourceProvider Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new CustomResourceProvider(name, id, options);
        }
    }

    public sealed class CustomResourceProviderArgs : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<Inputs.CustomRPActionRouteDefinitionArgs>? _actions;

        /// <summary>
        /// A list of actions that the custom resource provider implements.
        /// </summary>
        public InputList<Inputs.CustomRPActionRouteDefinitionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.CustomRPActionRouteDefinitionArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource provider.
        /// </summary>
        [Input("resourceProviderName", required: true)]
        public Input<string> ResourceProviderName { get; set; } = null!;

        [Input("resourceTypes")]
        private InputList<Inputs.CustomRPResourceTypeRouteDefinitionArgs>? _resourceTypes;

        /// <summary>
        /// A list of resource types that the custom resource provider implements.
        /// </summary>
        public InputList<Inputs.CustomRPResourceTypeRouteDefinitionArgs> ResourceTypes
        {
            get => _resourceTypes ?? (_resourceTypes = new InputList<Inputs.CustomRPResourceTypeRouteDefinitionArgs>());
            set => _resourceTypes = value;
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

        [Input("validations")]
        private InputList<Inputs.CustomRPValidationsArgs>? _validations;

        /// <summary>
        /// A list of validations to run on the custom resource provider's requests.
        /// </summary>
        public InputList<Inputs.CustomRPValidationsArgs> Validations
        {
            get => _validations ?? (_validations = new InputList<Inputs.CustomRPValidationsArgs>());
            set => _validations = value;
        }

        public CustomResourceProviderArgs()
        {
        }
    }
}
