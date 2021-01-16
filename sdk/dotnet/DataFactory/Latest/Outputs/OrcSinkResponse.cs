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
    public sealed class OrcSinkResponse
    {
        /// <summary>
        /// ORC format settings.
        /// </summary>
        public readonly Outputs.OrcWriteSettingsResponse? FormatSettings;
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
        /// ORC store settings.
        /// </summary>
        public readonly object? StoreSettings;
        /// <summary>
        /// Copy sink type.
        /// Expected value is 'OrcSink'.
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
        private OrcSinkResponse(
            Outputs.OrcWriteSettingsResponse? formatSettings,

            object? maxConcurrentConnections,

            object? sinkRetryCount,

            object? sinkRetryWait,

            object? storeSettings,

            string type,

            object? writeBatchSize,

            object? writeBatchTimeout)
        {
            FormatSettings = formatSettings;
            MaxConcurrentConnections = maxConcurrentConnections;
            SinkRetryCount = sinkRetryCount;
            SinkRetryWait = sinkRetryWait;
            StoreSettings = storeSettings;
            Type = type;
            WriteBatchSize = writeBatchSize;
            WriteBatchTimeout = writeBatchTimeout;
        }
    }
}
