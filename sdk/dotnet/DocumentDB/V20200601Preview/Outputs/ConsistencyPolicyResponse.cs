// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class ConsistencyPolicyResponse
    {
        /// <summary>
        /// The default consistency level and configuration settings of the Cosmos DB account.
        /// </summary>
        public readonly string DefaultConsistencyLevel;
        /// <summary>
        /// When used with the Bounded Staleness consistency level, this value represents the time amount of staleness (in seconds) tolerated. Accepted range for this value is 5 - 86400. Required when defaultConsistencyPolicy is set to 'BoundedStaleness'.
        /// </summary>
        public readonly int? MaxIntervalInSeconds;
        /// <summary>
        /// When used with the Bounded Staleness consistency level, this value represents the number of stale requests tolerated. Accepted range for this value is 1 – 2,147,483,647. Required when defaultConsistencyPolicy is set to 'BoundedStaleness'.
        /// </summary>
        public readonly double? MaxStalenessPrefix;

        [OutputConstructor]
        private ConsistencyPolicyResponse(
            string defaultConsistencyLevel,

            int? maxIntervalInSeconds,

            double? maxStalenessPrefix)
        {
            DefaultConsistencyLevel = defaultConsistencyLevel;
            MaxIntervalInSeconds = maxIntervalInSeconds;
            MaxStalenessPrefix = maxStalenessPrefix;
        }
    }
}
