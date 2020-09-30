// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Mapping data flow.
    /// </summary>
    public sealed class MappingDataFlowArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the data flow.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// The description of the data flow.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The folder that this data flow is in. If not specified, Data flow will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<Inputs.DataFlowFolderArgs>? Folder { get; set; }

        /// <summary>
        /// DataFlow script.
        /// </summary>
        [Input("script")]
        public Input<string>? Script { get; set; }

        [Input("sinks")]
        private InputList<Inputs.DataFlowSinkArgs>? _sinks;

        /// <summary>
        /// List of sinks in data flow.
        /// </summary>
        public InputList<Inputs.DataFlowSinkArgs> Sinks
        {
            get => _sinks ?? (_sinks = new InputList<Inputs.DataFlowSinkArgs>());
            set => _sinks = value;
        }

        [Input("sources")]
        private InputList<Inputs.DataFlowSourceArgs>? _sources;

        /// <summary>
        /// List of sources in data flow.
        /// </summary>
        public InputList<Inputs.DataFlowSourceArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.DataFlowSourceArgs>());
            set => _sources = value;
        }

        [Input("transformations")]
        private InputList<Inputs.TransformationArgs>? _transformations;

        /// <summary>
        /// List of transformations in data flow.
        /// </summary>
        public InputList<Inputs.TransformationArgs> Transformations
        {
            get => _transformations ?? (_transformations = new InputList<Inputs.TransformationArgs>());
            set => _transformations = value;
        }

        /// <summary>
        /// Type of data flow.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public MappingDataFlowArgs()
        {
        }
    }
}
