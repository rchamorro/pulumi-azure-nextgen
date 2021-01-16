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
    /// Trigger that runs every time the selected Blob container changes.
    /// </summary>
    public sealed class BlobTriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Trigger description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The path of the container/folder that will trigger the pipeline.
        /// </summary>
        [Input("folderPath", required: true)]
        public Input<string> FolderPath { get; set; } = null!;

        /// <summary>
        /// The Azure Storage linked service reference.
        /// </summary>
        [Input("linkedService", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedService { get; set; } = null!;

        /// <summary>
        /// The max number of parallel files to handle when it is triggered.
        /// </summary>
        [Input("maxConcurrency", required: true)]
        public Input<int> MaxConcurrency { get; set; } = null!;

        [Input("pipelines")]
        private InputList<Inputs.TriggerPipelineReferenceArgs>? _pipelines;

        /// <summary>
        /// Pipelines that need to be started.
        /// </summary>
        public InputList<Inputs.TriggerPipelineReferenceArgs> Pipelines
        {
            get => _pipelines ?? (_pipelines = new InputList<Inputs.TriggerPipelineReferenceArgs>());
            set => _pipelines = value;
        }

        /// <summary>
        /// Trigger type.
        /// Expected value is 'MultiplePipelineTrigger'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public BlobTriggerArgs()
        {
        }
    }
}
