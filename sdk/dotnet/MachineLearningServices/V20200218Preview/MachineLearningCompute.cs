// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200218Preview
{
    /// <summary>
    /// Machine Learning compute object wrapped into ARM resource envelope.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:machinelearningservices/v20200218preview:MachineLearningCompute")]
    public partial class MachineLearningCompute : Pulumi.CustomResource
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
        /// Compute properties
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
        /// Create a MachineLearningCompute resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MachineLearningCompute(string name, MachineLearningComputeArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200218preview:MachineLearningCompute", name, args ?? new MachineLearningComputeArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MachineLearningCompute(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:machinelearningservices/v20200218preview:MachineLearningCompute", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/latest:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20180301preview:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20181119:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20190501:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20190601:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20191101:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200101:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200301:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200401:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200501preview:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200515preview:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200601:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200801:MachineLearningCompute"},
                    new Pulumi.Alias { Type = "azure-nextgen:machinelearningservices/v20200901preview:MachineLearningCompute"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing MachineLearningCompute resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MachineLearningCompute Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new MachineLearningCompute(name, id, options);
        }
    }

    public sealed class MachineLearningComputeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the Azure Machine Learning compute.
        /// </summary>
        [Input("computeName", required: true)]
        public Input<string> ComputeName { get; set; } = null!;

        /// <summary>
        /// The identity of the resource.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.IdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Compute properties
        /// </summary>
        [Input("properties")]
        public Input<object>? Properties { get; set; }

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.SkuArgs>? Sku { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public Input<string> WorkspaceName { get; set; } = null!;

        public MachineLearningComputeArgs()
        {
        }
    }
}
