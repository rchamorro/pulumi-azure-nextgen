// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20161201.Outputs
{

    [OutputType]
    public sealed class DistributedNodesInfoResponse
    {
        /// <summary>
        /// Error Details if the Status is non-success.
        /// </summary>
        public readonly Outputs.ErrorDetailResponse? ErrorDetail;
        /// <summary>
        /// Name of the node under a distributed container.
        /// </summary>
        public readonly string? NodeName;
        /// <summary>
        /// Status of this Node.
        /// Failed | Succeeded
        /// </summary>
        public readonly string? Status;

        [OutputConstructor]
        private DistributedNodesInfoResponse(
            Outputs.ErrorDetailResponse? errorDetail,

            string? nodeName,

            string? status)
        {
            ErrorDetail = errorDetail;
            NodeName = nodeName;
            Status = status;
        }
    }
}