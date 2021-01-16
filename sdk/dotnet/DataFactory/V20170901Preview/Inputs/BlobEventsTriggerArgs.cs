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
    /// Trigger that runs every time a Blob event occurs.
    /// </summary>
    public sealed class BlobEventsTriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The blob path must begin with the pattern provided for trigger to fire. For example, '/records/blobs/december/' will only fire the trigger for blobs in the december folder under the records container. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith.
        /// </summary>
        [Input("blobPathBeginsWith")]
        public Input<string>? BlobPathBeginsWith { get; set; }

        /// <summary>
        /// The blob path must end with the pattern provided for trigger to fire. For example, 'december/boxes.csv' will only fire the trigger for blobs named boxes in a december folder. At least one of these must be provided: blobPathBeginsWith, blobPathEndsWith.
        /// </summary>
        [Input("blobPathEndsWith")]
        public Input<string>? BlobPathEndsWith { get; set; }

        /// <summary>
        /// Trigger description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("events", required: true)]
        private InputList<Union<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.BlobEventTypes>>? _events;

        /// <summary>
        /// The type of events that cause this trigger to fire.
        /// </summary>
        public InputList<Union<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.BlobEventTypes>> Events
        {
            get => _events ?? (_events = new InputList<Union<string, Pulumi.AzureNextGen.DataFactory.V20170901Preview.BlobEventTypes>>());
            set => _events = value;
        }

        /// <summary>
        /// If set to true, blobs with zero bytes will be ignored.
        /// </summary>
        [Input("ignoreEmptyBlobs")]
        public Input<bool>? IgnoreEmptyBlobs { get; set; }

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
        /// The ARM resource ID of the Storage Account.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// Trigger type.
        /// Expected value is 'MultiplePipelineTrigger'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public BlobEventsTriggerArgs()
        {
        }
    }
}
