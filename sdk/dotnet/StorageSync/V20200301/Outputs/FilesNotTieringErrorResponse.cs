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
    public sealed class FilesNotTieringErrorResponse
    {
        /// <summary>
        /// Error code (HResult)
        /// </summary>
        public readonly int ErrorCode;
        /// <summary>
        /// Count of files with this error
        /// </summary>
        public readonly double FileCount;

        [OutputConstructor]
        private FilesNotTieringErrorResponse(
            int errorCode,

            double fileCount)
        {
            ErrorCode = errorCode;
            FileCount = fileCount;
        }
    }
}
