// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class BlobSourceResponse
    {
        /// <summary>
        /// If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? Recursive;
        /// <summary>
        /// Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SkipHeaderLineCount;
        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SourceRetryCount;
        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SourceRetryWait;
        /// <summary>
        /// Treat empty as null. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? TreatEmptyAsNull;
        /// <summary>
        /// Copy source type.
        /// Expected value is 'BlobSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private BlobSourceResponse(
            object? recursive,

            object? skipHeaderLineCount,

            object? sourceRetryCount,

            object? sourceRetryWait,

            object? treatEmptyAsNull,

            string type)
        {
            Recursive = recursive;
            SkipHeaderLineCount = skipHeaderLineCount;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            TreatEmptyAsNull = treatEmptyAsNull;
            Type = type;
        }
    }
}
