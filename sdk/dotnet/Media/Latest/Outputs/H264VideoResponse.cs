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
    public sealed class H264VideoResponse
    {
        /// <summary>
        /// Tells the encoder how to choose its encoding settings. The default value is Balanced.
        /// </summary>
        public readonly string? Complexity;
        /// <summary>
        /// The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting.
        /// </summary>
        public readonly string? KeyFrameInterval;
        /// <summary>
        /// An optional label for the codec. The label can be used to control muxing behavior.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// The collection of output H.264 layers to be produced by the encoder.
        /// </summary>
        public readonly ImmutableArray<Outputs.H264LayerResponse> Layers;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Video'.
        /// </summary>
        public readonly string OdataType;
        /// <summary>
        /// Whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video.
        /// </summary>
        public readonly bool? SceneChangeDetection;
        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        public readonly string? StretchMode;
        /// <summary>
        /// The Video Sync Mode
        /// </summary>
        public readonly string? SyncMode;

        [OutputConstructor]
        private H264VideoResponse(
            string? complexity,

            string? keyFrameInterval,

            string? label,

            ImmutableArray<Outputs.H264LayerResponse> layers,

            string odataType,

            bool? sceneChangeDetection,

            string? stretchMode,

            string? syncMode)
        {
            Complexity = complexity;
            KeyFrameInterval = keyFrameInterval;
            Label = label;
            Layers = layers;
            OdataType = odataType;
            SceneChangeDetection = sceneChangeDetection;
            StretchMode = stretchMode;
            SyncMode = syncMode;
        }
    }
}
