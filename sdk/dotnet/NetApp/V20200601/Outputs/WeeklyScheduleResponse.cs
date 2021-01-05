// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200601.Outputs
{

    [OutputType]
    public sealed class WeeklyScheduleResponse
    {
        /// <summary>
        /// Indicates which weekdays snapshot should be taken, accepts a comma separated list of week day names in english
        /// </summary>
        public readonly string? Day;
        /// <summary>
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// </summary>
        public readonly int? Hour;
        /// <summary>
        /// Indicates which minute snapshot should be taken
        /// </summary>
        public readonly int? Minute;
        /// <summary>
        /// Weekly snapshot count to keep
        /// </summary>
        public readonly int? SnapshotsToKeep;
        /// <summary>
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// </summary>
        public readonly double? UsedBytes;

        [OutputConstructor]
        private WeeklyScheduleResponse(
            string? day,

            int? hour,

            int? minute,

            int? snapshotsToKeep,

            double? usedBytes)
        {
            Day = day;
            Hour = hour;
            Minute = minute;
            SnapshotsToKeep = snapshotsToKeep;
            UsedBytes = usedBytes;
        }
    }
}
