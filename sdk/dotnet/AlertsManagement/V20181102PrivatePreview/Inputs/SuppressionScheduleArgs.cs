// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.V20181102PrivatePreview.Inputs
{

    /// <summary>
    /// Schedule for a given suppression configuration.
    /// </summary>
    public sealed class SuppressionScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// End date for suppression
        /// </summary>
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        /// <summary>
        /// End date for suppression
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        [Input("recurrenceValues")]
        private InputList<int>? _recurrenceValues;

        /// <summary>
        /// Specifies the values for recurrence pattern
        /// </summary>
        public InputList<int> RecurrenceValues
        {
            get => _recurrenceValues ?? (_recurrenceValues = new InputList<int>());
            set => _recurrenceValues = value;
        }

        /// <summary>
        /// Start date for suppression
        /// </summary>
        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        /// <summary>
        /// Start time for suppression
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        public SuppressionScheduleArgs()
        {
        }
    }
}