// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerRegistry.V20201101Preview.Inputs
{

    public sealed class PipelineSourceTriggerPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The current status of the source trigger.
        /// </summary>
        [Input("status", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.ContainerRegistry.V20201101Preview.TriggerStatus> Status { get; set; } = null!;

        public PipelineSourceTriggerPropertiesArgs()
        {
            Status = "Enabled";
        }
    }
}
