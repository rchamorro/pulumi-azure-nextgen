// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180701.Inputs
{

    /// <summary>
    /// Describes all the properties for encoding a video with the H.264 codec.
    /// </summary>
    public sealed class H264VideoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Tells the encoder how to choose its encoding settings. The default value is Balanced.
        /// </summary>
        [Input("complexity")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.V20180701.H264Complexity>? Complexity { get; set; }

        /// <summary>
        /// The distance between two key frames, thereby defining a group of pictures (GOP). The value should be a non-zero integer in the range [1, 30] seconds, specified in ISO 8601 format. The default is 2 seconds (PT2S).
        /// </summary>
        [Input("keyFrameInterval")]
        public Input<string>? KeyFrameInterval { get; set; }

        /// <summary>
        /// An optional label for the codec. The label can be used to control muxing behavior.
        /// </summary>
        [Input("label")]
        public Input<string>? Label { get; set; }

        [Input("layers")]
        private InputList<Inputs.H264LayerArgs>? _layers;

        /// <summary>
        /// The collection of output H.264 layers to be produced by the encoder.
        /// </summary>
        public InputList<Inputs.H264LayerArgs> Layers
        {
            get => _layers ?? (_layers = new InputList<Inputs.H264LayerArgs>());
            set => _layers = value;
        }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Video'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// Whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video.
        /// </summary>
        [Input("sceneChangeDetection")]
        public Input<bool>? SceneChangeDetection { get; set; }

        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        [Input("stretchMode")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.V20180701.StretchMode>? StretchMode { get; set; }

        public H264VideoArgs()
        {
        }
    }
}
