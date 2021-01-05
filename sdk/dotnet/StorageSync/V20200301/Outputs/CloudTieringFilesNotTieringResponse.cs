// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.V20200301.Outputs
{

    [OutputType]
    public sealed class CloudTieringFilesNotTieringResponse
    {
        /// <summary>
        /// Array of tiering errors
        /// </summary>
        public readonly ImmutableArray<Outputs.FilesNotTieringErrorResponse> Errors;
        /// <summary>
        /// Last updated timestamp
        /// </summary>
        public readonly string LastUpdatedTimestamp;
        /// <summary>
        /// Last cloud tiering result (HResult)
        /// </summary>
        public readonly double TotalFileCount;

        [OutputConstructor]
        private CloudTieringFilesNotTieringResponse(
            ImmutableArray<Outputs.FilesNotTieringErrorResponse> errors,

            string lastUpdatedTimestamp,

            double totalFileCount)
        {
            Errors = errors;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            TotalFileCount = totalFileCount;
        }
    }
}
