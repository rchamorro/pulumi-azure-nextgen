// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20180501.Outputs
{

    [OutputType]
    public sealed class NodeStateCountsResponse
    {
        /// <summary>
        /// Number of compute nodes in idle state.
        /// </summary>
        public readonly int IdleNodeCount;
        /// <summary>
        /// Number of compute nodes which are leaving the cluster.
        /// </summary>
        public readonly int LeavingNodeCount;
        /// <summary>
        /// Number of compute nodes which are being prepared.
        /// </summary>
        public readonly int PreparingNodeCount;
        /// <summary>
        /// Number of compute nodes which are running jobs.
        /// </summary>
        public readonly int RunningNodeCount;
        /// <summary>
        /// Number of compute nodes which are in unusable state.
        /// </summary>
        public readonly int UnusableNodeCount;

        [OutputConstructor]
        private NodeStateCountsResponse(
            int idleNodeCount,

            int leavingNodeCount,

            int preparingNodeCount,

            int runningNodeCount,

            int unusableNodeCount)
        {
            IdleNodeCount = idleNodeCount;
            LeavingNodeCount = leavingNodeCount;
            PreparingNodeCount = preparingNodeCount;
            RunningNodeCount = runningNodeCount;
            UnusableNodeCount = unusableNodeCount;
        }
    }
}