// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview.Inputs
{

    /// <summary>
    /// Describes the properties for producing a series of JPEG images from the input video.
    /// </summary>
    public sealed class JpgImageArgs : Pulumi.ResourceArgs
    {
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
        private InputList<Inputs.JpgLayerArgs>? _layers;

        /// <summary>
        /// A collection of output JPEG image layers to be produced by the encoder.
        /// </summary>
        public InputList<Inputs.JpgLayerArgs> Layers
        {
            get => _layers ?? (_layers = new InputList<Inputs.JpgLayerArgs>());
            set => _layers = value;
        }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Video'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The position in the input video at which to stop generating thumbnails. The value can be in absolute timestamp (ISO 8601, e.g: PT5M30S to stop at 5 minutes and 30 seconds), or a frame count (For example, 300 to stop at the 300th frame), or a relative value (For example, 100%).
        /// </summary>
        [Input("range")]
        public Input<string>? Range { get; set; }

        /// <summary>
        /// The position in the input video from where to start generating thumbnails. The value can be in absolute timestamp (ISO 8601, e.g: PT05S), or a frame count (For example, 10 for the 10th frame), or a relative value (For example, 1%). Also supports a macro {Best}, which tells the encoder to select the best thumbnail from the first few seconds of the video.
        /// </summary>
        [Input("start")]
        public Input<string>? Start { get; set; }

        /// <summary>
        /// The intervals at which thumbnails are generated. The value can be in absolute timestamp (ISO 8601, e.g: PT05S for one image every 5 seconds), or a frame count (For example, 30 for every 30 frames), or a relative value (For example, 1%).
        /// </summary>
        [Input("step")]
        public Input<string>? Step { get; set; }

        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        [Input("stretchMode")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.V20180601Preview.StretchMode>? StretchMode { get; set; }

        public JpgImageArgs()
        {
        }
    }
}
