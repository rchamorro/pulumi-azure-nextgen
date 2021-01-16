// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180330Preview.Outputs
{

    [OutputType]
    public sealed class JobInputHttpResponse
    {
        /// <summary>
        /// Base URI for HTTPS job input. It will be concatenated with provided file names.   If no base uri is given, then the provided file list is assumed to be fully qualified uris.
        /// </summary>
        public readonly string? BaseUri;
        /// <summary>
        /// List of files. Required for JobInputHttp.
        /// </summary>
        public readonly ImmutableArray<string> Files;
        /// <summary>
        /// A label that is assigned to a JobInput, that is used to satisfy a reference used in the Transform. For example, a Transform can be authored so as to take an image file with the label 'xyz' and apply it as an overlay onto the input video before it is encoded. When submitting a Job, exactly one of the JobInputs should be the image file, and it should have the label 'xyz'.
        /// </summary>
        public readonly string? Label;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.JobInputClip'.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private JobInputHttpResponse(
            string? baseUri,

            ImmutableArray<string> files,

            string? label,

            string odataType)
        {
            BaseUri = baseUri;
            Files = files;
            Label = label;
            OdataType = odataType;
        }
    }
}
