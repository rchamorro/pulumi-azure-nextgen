// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class MultiplePipelineTriggerResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the trigger.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// Trigger description.
        /// </summary>
        public readonly string? Description;
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
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private MultiplePipelineTriggerResponse(
            ImmutableArray<object> annotations,

            string? description,

            ImmutableArray<Outputs.TriggerPipelineReferenceResponse> pipelines,

            string runtimeState,

            string type)
        {
            Annotations = annotations;
            Description = description;
            Pipelines = pipelines;
            RuntimeState = runtimeState;
            Type = type;
        }
    }
}
