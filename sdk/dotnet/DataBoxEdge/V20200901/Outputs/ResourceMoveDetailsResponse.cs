// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901.Outputs
{

    [OutputType]
    public sealed class ResourceMoveDetailsResponse
    {
        /// <summary>
        /// Denotes whether move operation is in progress
        /// </summary>
        public readonly string? OperationInProgress;
        /// <summary>
        /// Denotes the timeout of the operation to finish
        /// </summary>
        public readonly string? OperationInProgressLockTimeoutInUTC;

        [OutputConstructor]
        private ResourceMoveDetailsResponse(
            string? operationInProgress,

            string? operationInProgressLockTimeoutInUTC)
        {
            OperationInProgress = operationInProgress;
            OperationInProgressLockTimeoutInUTC = operationInProgressLockTimeoutInUTC;
        }
    }
}
