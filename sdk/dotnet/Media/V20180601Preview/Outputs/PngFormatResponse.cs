// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class PngFormatResponse
    {
        /// <summary>
        /// The pattern of the file names for the generated output files. The following macros are supported in the file name: {Basename} - The base name of the input video {Extension} - The appropriate extension for this format. {Label} - The label assigned to the codec/layer. {Index} - A unique index for thumbnails. Only applicable to thumbnails. {Bitrate} - The audio/video bitrate. Not applicable to thumbnails. {Codec} - The type of the audio/video codec. Any unsubstituted macros will be collapsed and removed from the filename.
        /// </summary>
        public readonly string? FilenamePattern;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.ImageFormat'.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private PngFormatResponse(
            string? filenamePattern,

            string odataType)
        {
            FilenamePattern = filenamePattern;
            OdataType = odataType;
        }
    }
}
