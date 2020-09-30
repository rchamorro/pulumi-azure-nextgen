// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// Trigger that schedules pipeline reruns for all fixed time interval windows from a requested start time to requested end time.
    /// </summary>
    public sealed class RerunTumblingWindowTriggerArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the trigger.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// Trigger description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The parent trigger reference.
        /// </summary>
        [Input("parentTrigger", required: true)]
        public Input<object> ParentTrigger { get; set; } = null!;

        /// <summary>
        /// The end time for the time period for which restatement is initiated. Only UTC time is currently supported.
        /// </summary>
        [Input("requestedEndTime", required: true)]
        public Input<string> RequestedEndTime { get; set; } = null!;

        /// <summary>
        /// The start time for the time period for which restatement is initiated. Only UTC time is currently supported.
        /// </summary>
        [Input("requestedStartTime", required: true)]
        public Input<string> RequestedStartTime { get; set; } = null!;

        /// <summary>
        /// The max number of parallel time windows (ready for execution) for which a rerun is triggered.
        /// </summary>
        [Input("rerunConcurrency", required: true)]
        public Input<int> RerunConcurrency { get; set; } = null!;

        /// <summary>
        /// Trigger type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public RerunTumblingWindowTriggerArgs()
        {
        }
    }
}
