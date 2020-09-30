// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ImportExport.V20200801
{
    public static class GetJob
    {
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("azure-nextgen:importexport/v20200801:getJob", args ?? new GetJobArgs(), options.WithVersion());
    }


    public sealed class GetJobArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the import/export job.
        /// </summary>
        [Input("jobName", required: true)]
        public string JobName { get; set; } = null!;

        /// <summary>
        /// The resource group name uniquely identifies the resource group within the user subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetJobArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJobResult
    {
        /// <summary>
        /// Specifies the job identity details
        /// </summary>
        public readonly Outputs.IdentityDetailsResponse? Identity;
        /// <summary>
        /// Specifies the Azure location where the job is created.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Specifies the name of the job.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the job properties
        /// </summary>
        public readonly Outputs.JobDetailsResponse Properties;
        /// <summary>
        /// Specifies the tags that are assigned to the job.
        /// </summary>
        public readonly object? Tags;
        /// <summary>
        /// Specifies the type of the job resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetJobResult(
            Outputs.IdentityDetailsResponse? identity,

            string? location,

            string name,

            Outputs.JobDetailsResponse properties,

            object? tags,

            string type)
        {
            Identity = identity;
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
