// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200801.Outputs
{

    [OutputType]
    public sealed class DailyScheduleResponse
    {
        /// <summary>
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// </summary>
        public readonly int? Hour;
        /// <summary>
        /// Indicates which minute snapshot should be taken
        /// </summary>
        public readonly int? Minute;
        /// <summary>
        /// Daily snapshot count to keep
        /// </summary>
        public readonly int? SnapshotsToKeep;
        /// <summary>
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// </summary>
        public readonly double? UsedBytes;

        [OutputConstructor]
        private DailyScheduleResponse(
            int? hour,

            int? minute,

            int? snapshotsToKeep,

            double? usedBytes)
        {
            Hour = hour;
            Minute = minute;
            SnapshotsToKeep = snapshotsToKeep;
            UsedBytes = usedBytes;
        }
    }
}
