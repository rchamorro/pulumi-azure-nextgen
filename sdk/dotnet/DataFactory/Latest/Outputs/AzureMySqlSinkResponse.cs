// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class AzureMySqlSinkResponse
    {
        /// <summary>
        /// The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxConcurrentConnections;
        /// <summary>
        /// A query to execute before starting the copy. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? PreCopyScript;
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
        /// Expected value is 'AzureMySqlSink'.
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

        [OutputConstructor]
        private AzureMySqlSinkResponse(
            object? maxConcurrentConnections,

            object? preCopyScript,

            object? sinkRetryCount,

            object? sinkRetryWait,

            string type,

            object? writeBatchSize,

            object? writeBatchTimeout)
        {
            MaxConcurrentConnections = maxConcurrentConnections;
            PreCopyScript = preCopyScript;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            Type = type;
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
        }
    }
}
