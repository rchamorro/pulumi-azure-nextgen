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
    public sealed class ServerEndpointRecallErrorResponse
    {
        /// <summary>
        /// Count of occurences of the error
        /// </summary>
        public readonly double Count;
        /// <summary>
        /// Error code (HResult)
        /// </summary>
        public readonly int ErrorCode;

        [OutputConstructor]
        private ServerEndpointRecallErrorResponse(
            double count,

            int errorCode)
        {
            Count = count;
            ErrorCode = errorCode;
        }
    }
}
