// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20180301.Inputs
{

    /// <summary>
    /// The system automatically scales the cluster up and down (within minimumNodeCount and maximumNodeCount) based on the pending and running jobs on the cluster.
    /// </summary>
    public sealed class AutoScaleSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("initialNodeCount")]
        public Input<int>? InitialNodeCount { get; set; }

        [Input("maximumNodeCount", required: true)]
        public Input<int> MaximumNodeCount { get; set; } = null!;

        [Input("minimumNodeCount", required: true)]
        public Input<int> MinimumNodeCount { get; set; } = null!;

        public AutoScaleSettingsArgs()
        {
            InitialNodeCount = 0;
        }
    }
}
