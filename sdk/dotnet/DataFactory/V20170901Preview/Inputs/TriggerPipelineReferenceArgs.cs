// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Inputs
{

    /// <summary>
    /// Pipeline that needs to be triggered with the given parameters.
    /// </summary>
    public sealed class TriggerPipelineReferenceArgs : Pulumi.ResourceArgs
    {
        [Input("parameters")]
        private InputMap<object>? _parameters;

        /// <summary>
        /// Pipeline parameters.
        /// </summary>
        public InputMap<object> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<object>());
            set => _parameters = value;
        }

        /// <summary>
        /// Pipeline reference.
        /// </summary>
        [Input("pipelineReference")]
        public Input<Inputs.PipelineReferenceArgs>? PipelineReference { get; set; }

        public TriggerPipelineReferenceArgs()
        {
        }
    }
}
