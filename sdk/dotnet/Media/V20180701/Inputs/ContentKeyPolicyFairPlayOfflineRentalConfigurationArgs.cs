// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180701.Inputs
{

    public sealed class ContentKeyPolicyFairPlayOfflineRentalConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Playback duration
        /// </summary>
        [Input("playbackDurationSeconds", required: true)]
        public Input<double> PlaybackDurationSeconds { get; set; } = null!;

        /// <summary>
        /// Storage duration
        /// </summary>
        [Input("storageDurationSeconds", required: true)]
        public Input<double> StorageDurationSeconds { get; set; } = null!;

        public ContentKeyPolicyFairPlayOfflineRentalConfigurationArgs()
        {
        }
    }
}
