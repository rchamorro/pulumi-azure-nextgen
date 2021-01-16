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
    /// A copy activity SQL server sink.
    /// </summary>
    public sealed class SqlServerSinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// SQL pre-copy script. Type: string (or Expression with resultType string).
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
        /// SQL writer stored procedure name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("sqlWriterStoredProcedureName")]
        public Input<object>? SqlWriterStoredProcedureName { get; set; }

        /// <summary>
        /// SQL writer table type. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("sqlWriterTableType")]
        public Input<object>? SqlWriterTableType { get; set; }

        [Input("storedProcedureParameters")]
        private InputMap<Inputs.StoredProcedureParameterArgs>? _storedProcedureParameters;

        /// <summary>
        /// SQL stored procedure parameters.
        /// </summary>
        public InputMap<Inputs.StoredProcedureParameterArgs> StoredProcedureParameters
        {
            get => _storedProcedureParameters ?? (_storedProcedureParameters = new InputMap<Inputs.StoredProcedureParameterArgs>());
            set => _storedProcedureParameters = value;
        }

        /// <summary>
        /// The stored procedure parameter name of the table type. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("storedProcedureTableTypeParameterName")]
        public Input<object>? StoredProcedureTableTypeParameterName { get; set; }

        /// <summary>
        /// The option to handle sink table, such as autoCreate. For now only 'autoCreate' value is supported. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("tableOption")]
        public Input<object>? TableOption { get; set; }

        /// <summary>
        /// Copy sink type.
        /// Expected value is 'SqlServerSink'.
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

        public SqlServerSinkArgs()
        {
        }
    }
}
