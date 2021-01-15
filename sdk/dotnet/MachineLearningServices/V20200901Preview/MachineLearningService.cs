// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200901Preview
{
    /// <summary>
    /// Machine Learning service object wrapped into ARM resource envelope.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:machinelearningservices/v20200901preview:MachineLearningService")]
    public partial class MachineLearningService : Pulumi.CustomResource
    {
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.IdentityResponse?> Identity { get; private set; } = null!;

        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Service properties
        /// </summary>
        [Output("properties")]
        public Output<object> Properties { get; private set; } = null!;

        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a MachineLearningService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MachineLearningService(string name, MachineLearningServiceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200901preview:MachineLearningService", name, args ?? new MachineLearningServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MachineLearningService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200901preview:MachineLearningService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200501preview:MachineLearningService"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200515preview:MachineLearningService"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MachineLearningService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MachineLearningService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MachineLearningService(name, id, options);
        }
    }

    public sealed class MachineLearningServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The compute environment type for the service.
        /// </summary>
        [Input("computeType", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.MachineLearningServices.V20200901Preview.ComputeEnvironmentType> ComputeType { get; set; } = null!;

        /// <summary>
        /// The description of the service.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The Environment, models and assets needed for inferencing.
        /// </summary>
        [Input("environmentImageRequest")]
        public Input<Inputs.CreateServiceRequestEnvironmentImageRequestArgs>? EnvironmentImageRequest { get; set; }

        /// <summary>
        /// The authentication keys.
        /// </summary>
        [Input("keys")]
        public Input<Inputs.CreateServiceRequestKeysArgs>? Keys { get; set; }

        [Input("kvTags")]
        private InputMap<string>? _kvTags;

        /// <summary>
        /// The service tag dictionary. Tags are mutable.
        /// </summary>
        public InputMap<string> KvTags
        {
            get => _kvTags ?? (_kvTags = new InputMap<string>());
            set => _kvTags = value;
        }

        /// <summary>
        /// The name of the Azure location/region.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// The service properties dictionary. Properties are immutable.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Machine Learning service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public MachineLearningServiceArgs()
        {
        }
    }
}
