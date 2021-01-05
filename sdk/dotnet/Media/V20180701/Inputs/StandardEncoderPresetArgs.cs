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
    /// Describes all the settings to be used when encoding the input video with the Standard Encoder.
    /// </summary>
    public sealed class StandardEncoderPresetArgs : Pulumi.ResourceArgs
    {
        [Input("codecs", required: true)]
        private InputList<object>? _codecs;

        /// <summary>
        /// The list of codecs to be used when encoding the input video.
        /// </summary>
        public InputList<object> Codecs
        {
            get => _codecs ?? (_codecs = new InputList<object>());
            set => _codecs = value;
        }

        /// <summary>
        /// One or more filtering operations that are applied to the input media before encoding.
        /// </summary>
        [Input("filters")]
        public Input<Inputs.FiltersArgs>? Filters { get; set; }

        [Input("formats", required: true)]
        private InputList<Union<Inputs.ImageFormatArgs, Inputs.MultiBitrateFormatArgs>>? _formats;

        /// <summary>
        /// The list of outputs to be produced by the encoder.
        /// </summary>
        public InputList<Union<Inputs.ImageFormatArgs, Inputs.MultiBitrateFormatArgs>> Formats
        {
            get => _formats ?? (_formats = new InputList<Union<Inputs.ImageFormatArgs, Inputs.MultiBitrateFormatArgs>>());
            set => _formats = value;
        }

        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.StandardEncoderPreset'.
        /// </summary>
        [Input("odataType", required: true)]
        public Input<string> OdataType { get; set; } = null!;

        public StandardEncoderPresetArgs()
        {
        }
    }
}
