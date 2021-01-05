// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200501.Inputs
{

    /// <summary>
    /// Daily Schedule properties
    /// </summary>
    public sealed class DailyScheduleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates which hour in UTC timezone a snapshot should be taken
        /// </summary>
        [Input("hour")]
        public Input<int>? Hour { get; set; }

        /// <summary>
        /// Indicates which minute snapshot should be taken
        /// </summary>
        [Input("minute")]
        public Input<int>? Minute { get; set; }

        /// <summary>
        /// Daily snapshot count to keep
        /// </summary>
        [Input("snapshotsToKeep")]
        public Input<int>? SnapshotsToKeep { get; set; }

        /// <summary>
        /// Resource size in bytes, current storage usage for the volume in bytes
        /// </summary>
        [Input("usedBytes")]
        public Input<double>? UsedBytes { get; set; }

        public DailyScheduleArgs()
        {
        }
    }
}
