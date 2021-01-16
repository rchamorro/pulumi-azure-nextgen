// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class CommonDataServiceForAppsSinkResponse
    {
        /// <summary>
        /// The logical name of the alternate key which will be used when upserting records. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? AlternateKeyName;
        /// <summary>
        /// The flag indicating whether to ignore null values from input dataset (except key fields) during write operation. Default is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? IgnoreNullValues;
        /// <summary>
        /// The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxConcurrentConnections;
        /// <summary>
        /// Sink retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SinkRetryCount;
        /// <summary>
        /// Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SinkRetryWait;
        /// <summary>
        /// Copy sink type.
        /// Expected value is 'CommonDataServiceForAppsSink'.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Write batch size. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        public readonly object? WriteBatchSize;
        /// <summary>
        /// Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? WriteBatchTimeout;
        /// <summary>
        /// The write behavior for the operation.
        /// </summary>
        public readonly string WriteBehavior;

        [OutputConstructor]
        private CommonDataServiceForAppsSinkResponse(
            object? alternateKeyName,

            object? ignoreNullValues,

            object? maxConcurrentConnections,

            object? sinkRetryCount,

            object? sinkRetryWait,

            string type,

            object? writeBatchSize,

            object? writeBatchTimeout,

            string writeBehavior)
        {
            AlternateKeyName = alternateKeyName;
            IgnoreNullValues = ignoreNullValues;
            MaxConcurrentConnections = maxConcurrentConnections;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            Type = type;
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
            WriteBehavior = writeBehavior;
        }
    }
}
