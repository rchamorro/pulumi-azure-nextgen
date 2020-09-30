// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class RetryPolicyResponse
    {
        /// <summary>
        /// Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        public readonly object? Count;
        /// <summary>
        /// Interval between retries in seconds. Default is 30.
        /// </summary>
        public readonly int? IntervalInSeconds;

        [OutputConstructor]
        private RetryPolicyResponse(
            object? count,

            int? intervalInSeconds)
        {
            Count = count;
            IntervalInSeconds = intervalInSeconds;
        }
    }
}
