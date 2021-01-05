// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200601
{
    public static class GetMachineLearningCompute
    {
        public static Task<GetMachineLearningComputeResult> InvokeAsync(GetMachineLearningComputeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetMachineLearningComputeResult>("azure-nextgen:machinelearningservices/v20200601:getMachineLearningCompute", args ?? new GetMachineLearningComputeArgs(), options.WithVersion());
    }


    public sealed class GetMachineLearningComputeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the Azure Machine Learning compute.
        /// </summary>
        [Input("computeName", required: true)]
        public string ComputeName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group in which workspace is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Name of Azure Machine Learning workspace.
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetMachineLearningComputeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetMachineLearningComputeResult
    {
        /// <summary>
        /// Specifies the resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// Specifies the location of the resource.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Specifies the name of the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Compute properties
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// The sku of the workspace.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Contains resource tags defined as key/value pairs.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Specifies the type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetMachineLearningComputeResult(
            string id,

            Outputs.IdentityResponse? identity,

            string? location,

            string name,

            object properties,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Identity = identity;
            Location = location;
            Name = name;
            Properties = properties;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
