// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20190501.Inputs
{

    /// <summary>
    /// scale settings for AML Compute
    /// </summary>
    public sealed class ScaleSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Max number of nodes to use
        /// </summary>
        [Input("maxNodeCount", required: true)]
        public Input<int> MaxNodeCount { get; set; } = null!;

        /// <summary>
        /// Min number of nodes to use
        /// </summary>
        [Input("minNodeCount")]
        public Input<int>? MinNodeCount { get; set; }

        /// <summary>
        /// Node Idle Time before scaling down amlCompute
        /// </summary>
        [Input("nodeIdleTimeBeforeScaleDown")]
        public Input<string>? NodeIdleTimeBeforeScaleDown { get; set; }

        public ScaleSettingsArgs()
        {
            MinNodeCount = 0;
        }
    }
}
