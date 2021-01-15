// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest
{
    public static class GetJob
    {
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("azure-nextgen:media/latest:getJob", args ?? new GetJobArgs(), options.WithVersion());
    }


    public sealed class GetJobArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Media Services account name.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The Job name.
        /// </summary>
        [Input("jobName", required: true)]
        public string JobName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Transform name.
        /// </summary>
        [Input("transformName", required: true)]
        public string TransformName { get; set; } = null!;

        public GetJobArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJobResult
    {
        /// <summary>
        /// Customer provided key, value pairs that will be returned in Job and JobOutput state events.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? CorrelationData;
        /// <summary>
        /// The UTC date and time when the customer has created the Job, in 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        public readonly string Created;
        /// <summary>
        /// Optional customer supplied description of the Job.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The UTC date and time at which this Job finished processing.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The inputs for the Job.
        /// </summary>
        public readonly object Input;
        /// <summary>
        /// The UTC date and time when the customer has last updated the Job, in 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        public readonly string LastModified;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The outputs for the Job.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobOutputAssetResponse> Outputs;
        /// <summary>
        /// Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
        /// </summary>
        public readonly string? Priority;
        /// <summary>
        /// The UTC date and time at which this Job began processing.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// The current state of the job.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetJobResult(
            ImmutableDictionary<string, string>? correlationData,

            string created,

            string? description,

            string endTime,

            string id,

            object input,

            string lastModified,

            string name,

            ImmutableArray<Outputs.JobOutputAssetResponse> outputs,

            string? priority,

            string startTime,

            string state,

            string type)
        {
            CorrelationData = correlationData;
            Created = created;
            Description = description;
            EndTime = endTime;
            Id = id;
            Input = input;
            LastModified = lastModified;
            Name = name;
            Outputs = outputs;
            Priority = priority;
            StartTime = startTime;
            State = state;
            Type = type;
        }
    }
}
