// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Migrate.V20191001
{
    public static class GetHyperVCollector
    {
        public static Task<GetHyperVCollectorResult> InvokeAsync(GetHyperVCollectorArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetHyperVCollectorResult>("azure-nextgen:migrate/v20191001:getHyperVCollector", args ?? new GetHyperVCollectorArgs(), options.WithVersion());
    }


    public sealed class GetHyperVCollectorArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique name of a Hyper-V collector within a project.
        /// </summary>
        [Input("hyperVCollectorName", required: true)]
        public string HyperVCollectorName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Migrate project.
        /// </summary>
        [Input("projectName", required: true)]
        public string ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Resource Group that project is part of.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetHyperVCollectorArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetHyperVCollectorResult
    {
        public readonly string? ETag;
        public readonly string Name;
        public readonly Outputs.CollectorPropertiesResponse Properties;
        public readonly string Type;

        [OutputConstructor]
        private GetHyperVCollectorResult(
            string? eTag,

            string name,

            Outputs.CollectorPropertiesResponse properties,

            string type)
        {
            ETag = eTag;
            Name = name;
            Properties = properties;
            Type = type;
        }
    }
}