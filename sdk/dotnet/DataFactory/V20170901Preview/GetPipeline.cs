// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview
{
    public static class GetPipeline
    {
        public static Task<GetPipelineResult> InvokeAsync(GetPipelineArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPipelineResult>("azure-nextgen:datafactory/v20170901preview:getPipeline", args ?? new GetPipelineArgs(), options.WithVersion());
    }


    public sealed class GetPipelineArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The factory name.
        /// </summary>
        [Input("factoryName", required: true)]
        public string FactoryName { get; set; } = null!;

        /// <summary>
        /// The pipeline name.
        /// </summary>
        [Input("pipelineName", required: true)]
        public string PipelineName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPipelineArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPipelineResult
    {
        /// <summary>
        /// List of activities in pipeline.
        /// </summary>
        public readonly ImmutableArray<object> Activities;
        /// <summary>
        /// List of tags that can be used for describing the Pipeline.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The max number of concurrent runs for the pipeline.
        /// </summary>
        public readonly int? Concurrency;
        /// <summary>
        /// The description of the pipeline.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Etag identifies change in the resource.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// The resource identifier.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of parameters for pipeline.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// The resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPipelineResult(
            ImmutableArray<object> activities,

            ImmutableArray<object> annotations,

            int? concurrency,

            string? description,

            string etag,

            string id,

            string name,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            string type)
        {
            Activities = activities;
            Annotations = annotations;
            Concurrency = concurrency;
            Description = description;
            Etag = etag;
            Id = id;
            Name = name;
            Parameters = parameters;
            Type = type;
        }
    }
}
