// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest.Outputs
{

    [OutputType]
    public sealed class ContentKeyPolicyFairPlayOfflineRentalConfigurationResponse
    {
        /// <summary>
        /// Playback duration
        /// </summary>
        public readonly double PlaybackDurationSeconds;
        /// <summary>
        /// Storage duration
        /// </summary>
        public readonly double StorageDurationSeconds;

        [OutputConstructor]
        private ContentKeyPolicyFairPlayOfflineRentalConfigurationResponse(
            double playbackDurationSeconds,

            double storageDurationSeconds)
        {
            PlaybackDurationSeconds = playbackDurationSeconds;
            StorageDurationSeconds = storageDurationSeconds;
        }
    }
}
