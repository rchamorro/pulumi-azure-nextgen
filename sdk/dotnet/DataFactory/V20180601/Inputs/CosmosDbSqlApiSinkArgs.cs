// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// A copy activity Azure CosmosDB (SQL API) Collection sink.
    /// </summary>
    public sealed class CosmosDbSqlApiSinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Sink retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sinkRetryCount")]
        public Input<object>? SinkRetryCount { get; set; }

        /// <summary>
        /// Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sinkRetryWait")]
        public Input<object>? SinkRetryWait { get; set; }

        /// <summary>
        /// Copy sink type.
        /// Expected value is 'CosmosDbSqlApiSink'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Write batch size. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Input("writeBatchSize")]
        public Input<object>? WriteBatchSize { get; set; }

        /// <summary>
        /// Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("writeBatchTimeout")]
        public Input<object>? WriteBatchTimeout { get; set; }

        /// <summary>
        /// Describes how to write data to Azure Cosmos DB. Type: string (or Expression with resultType string). Allowed values: insert and upsert.
        /// </summary>
        [Input("writeBehavior")]
        public Input<object>? WriteBehavior { get; set; }

        public CosmosDbSqlApiSinkArgs()
        {
        }
    }
}
