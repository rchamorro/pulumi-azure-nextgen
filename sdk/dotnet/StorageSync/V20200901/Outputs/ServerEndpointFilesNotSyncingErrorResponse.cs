// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.V20200901.Outputs
{

    [OutputType]
    public sealed class ServerEndpointFilesNotSyncingErrorResponse
    {
        /// <summary>
        /// Error code (HResult)
        /// </summary>
        public readonly int ErrorCode;
        /// <summary>
        /// Count of persistent files not syncing with the specified error code
        /// </summary>
        public readonly double PersistentCount;
        /// <summary>
        /// Count of transient files not syncing with the specified error code
        /// </summary>
        public readonly double TransientCount;

        [OutputConstructor]
        private ServerEndpointFilesNotSyncingErrorResponse(
            int errorCode,

            double persistentCount,

            double transientCount)
        {
            ErrorCode = errorCode;
            PersistentCount = persistentCount;
            TransientCount = transientCount;
        }
    }
}
