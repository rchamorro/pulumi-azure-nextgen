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
    public sealed class TriggerPipelineReferenceResponse
    {
        /// <summary>
        /// Pipeline parameters.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Parameters;
        /// <summary>
        /// Pipeline reference.
        /// </summary>
        public readonly Outputs.PipelineReferenceResponse? PipelineReference;

        [OutputConstructor]
        private TriggerPipelineReferenceResponse(
            ImmutableDictionary<string, object>? parameters,

            Outputs.PipelineReferenceResponse? pipelineReference)
        {
            Parameters = parameters;
            PipelineReference = pipelineReference;
        }
    }
}
