// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerRegistry.Latest.Inputs
{

    /// <summary>
    /// The properties of a timer trigger.
    /// </summary>
    public sealed class TimerTriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the trigger.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The CRON expression for the task schedule
        /// </summary>
        [Input("schedule", required: true)]
        public Input<string> Schedule { get; set; } = null!;

        /// <summary>
        /// The current status of trigger.
        /// </summary>
        [Input("status")]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerRegistry.Latest.TriggerStatus>? Status { get; set; }

        public TimerTriggerArgs()
        {
            Status = "Enabled";
        }
    }
}
