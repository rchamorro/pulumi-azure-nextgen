// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorageSync.Latest.Outputs
{

    [OutputType]
    public sealed class ServerEndpointSyncSessionStatusResponse
    {
        /// <summary>
        /// Array of per-item errors coming from the last sync session.
        /// </summary>
        public readonly ImmutableArray<Outputs.ServerEndpointFilesNotSyncingErrorResponse> FilesNotSyncingErrors;
        /// <summary>
        /// Last sync per item error count.
        /// </summary>
        public readonly double LastSyncPerItemErrorCount;
        /// <summary>
        /// Last sync result (HResult)
        /// </summary>
        public readonly int LastSyncResult;
        /// <summary>
        /// Last sync success timestamp
        /// </summary>
        public readonly string LastSyncSuccessTimestamp;
        /// <summary>
        /// Last sync timestamp
        /// </summary>
        public readonly string LastSyncTimestamp;
        /// <summary>
        /// Count of persistent files not syncing.
        /// </summary>
        public readonly double PersistentFilesNotSyncingCount;
        /// <summary>
        /// Count of transient files not syncing.
        /// </summary>
        public readonly double TransientFilesNotSyncingCount;

        [OutputConstructor]
        private ServerEndpointSyncSessionStatusResponse(
            ImmutableArray<Outputs.ServerEndpointFilesNotSyncingErrorResponse> filesNotSyncingErrors,

            double lastSyncPerItemErrorCount,

            int lastSyncResult,

            string lastSyncSuccessTimestamp,

            string lastSyncTimestamp,

            double persistentFilesNotSyncingCount,

            double transientFilesNotSyncingCount)
        {
            FilesNotSyncingErrors = filesNotSyncingErrors;
            LastSyncPerItemErrorCount = lastSyncPerItemErrorCount;
            LastSyncResult = lastSyncResult;
            LastSyncSuccessTimestamp = lastSyncSuccessTimestamp;
            LastSyncTimestamp = lastSyncTimestamp;
            PersistentFilesNotSyncingCount = persistentFilesNotSyncingCount;
            TransientFilesNotSyncingCount = transientFilesNotSyncingCount;
        }
    }
}
