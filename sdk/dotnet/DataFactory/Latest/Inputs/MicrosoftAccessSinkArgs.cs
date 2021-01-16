// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// A copy activity Microsoft Access sink.
    /// </summary>
    public sealed class MicrosoftAccessSinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// A query to execute before starting the copy. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("preCopyScript")]
        public Input<object>? PreCopyScript { get; set; }

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
        /// Expected value is 'MicrosoftAccessSink'.
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

        public MicrosoftAccessSinkArgs()
        {
        }
    }
}
