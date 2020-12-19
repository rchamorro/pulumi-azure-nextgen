// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180330Preview.Inputs
{

    /// <summary>
    /// Describes the basic properties for encoding the input video.
    /// </summary>
    public sealed class VideoArgs : Pulumi.ResourceArgs
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

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.Video'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        /// <summary>
        /// The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize
        /// </summary>
        [Input("stretchMode")]
        public InputUnion<string, Pulumi.AzureNextGen.Media.V20180330Preview.StretchMode>? StretchMode { get; set; }

        public VideoArgs()
        {
        }
    }
}
