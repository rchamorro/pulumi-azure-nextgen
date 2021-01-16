// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// A copy activity Azure Blob source.
    /// </summary>
    public sealed class BlobSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("recursive")]
        public Input<object>? Recursive { get; set; }

        /// <summary>
        /// Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("skipHeaderLineCount")]
        public Input<object>? SkipHeaderLineCount { get; set; }

        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sourceRetryCount")]
        public Input<object>? SourceRetryCount { get; set; }

        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sourceRetryWait")]
        public Input<object>? SourceRetryWait { get; set; }

        /// <summary>
        /// Treat empty as null. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("treatEmptyAsNull")]
        public Input<object>? TreatEmptyAsNull { get; set; }

        /// <summary>
        /// Copy source type.
        /// Expected value is 'BlobSource'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public BlobSourceArgs()
        {
        }
    }
}
