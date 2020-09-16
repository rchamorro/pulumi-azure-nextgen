// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20200501.Inputs
{

    /// <summary>
    /// Describes the basic properties for encoding the input video.
    /// </summary>
    public sealed class VideoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting.
        /// </summary>
        [Input("keyFrameInterval")]
        public Input<string>? KeyFrameInterval { get; set; }

        /// <summary>
        /// An optional label for the codec. The label can be used to control muxing behavior.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        /// <summary>
        /// The discriminator for derived types.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        [Input("stretchMode")]
        public Input<string>? StretchMode { get; set; }

        /// <summary>
        /// The Video Sync Mode
        /// </summary>
        [Input("syncMode")]
        public Input<string>? SyncMode { get; set; }

        public VideoArgs()
        {
        }
    }
}