// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class BlobTriggerResponse
    {
        /// <summary>
        /// Trigger description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The path of the container/folder that will trigger the pipeline.
        /// </summary>
        public readonly string FolderPath;
        /// <summary>
        /// The Azure Storage linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedService;
        /// <summary>
        /// The max number of parallel files to handle when it is triggered.
        /// </summary>
        public readonly int MaxConcurrency;
        /// <summary>
        /// Pipelines that need to be started.
        /// </summary>
        public readonly ImmutableArray<Outputs.TriggerPipelineReferenceResponse> Pipelines;
        /// <summary>
        /// Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger.
        /// </summary>
        public readonly string RuntimeState;
        /// <summary>
        /// Trigger type.
        /// Expected value is 'MultiplePipelineTrigger'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BlobTriggerResponse(
            string? description,

            string folderPath,

            Outputs.LinkedServiceReferenceResponse linkedService,

            int maxConcurrency,

            ImmutableArray<Outputs.TriggerPipelineReferenceResponse> pipelines,

            string runtimeState,

            string type)
        {
            Description = description;
            FolderPath = folderPath;
            LinkedService = linkedService;
            MaxConcurrency = maxConcurrency;
            Pipelines = pipelines;
            RuntimeState = runtimeState;
            Type = type;
        }
    }
}
