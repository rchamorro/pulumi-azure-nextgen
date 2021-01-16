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
    /// A copy activity Azure SQL source.
    /// </summary>
    public sealed class AzureSqlSourceArgs : Pulumi.ResourceArgs
    {
        [Input("additionalColumns")]
        private InputList<Inputs.AdditionalColumnsArgs>? _additionalColumns;

        /// <summary>
        /// Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects).
        /// </summary>
        public InputList<Inputs.AdditionalColumnsArgs> AdditionalColumns
        {
            get => _additionalColumns ?? (_additionalColumns = new InputList<Inputs.AdditionalColumnsArgs>());
            set => _additionalColumns = value;
        }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// The partition mechanism that will be used for Sql read in parallel. Possible values include: "None", "PhysicalPartitionsOfTable", "DynamicRange".
        /// </summary>
        [Input("partitionOption")]
        public Input<object>? PartitionOption { get; set; }

        /// <summary>
        /// The settings that will be leveraged for Sql source partitioning.
        /// </summary>
        [Input("partitionSettings")]
        public Input<Inputs.SqlPartitionSettingsArgs>? PartitionSettings { get; set; }

        /// <summary>
        /// Which additional types to produce.
        /// </summary>
        [Input("produceAdditionalTypes")]
        public Input<object>? ProduceAdditionalTypes { get; set; }

        /// <summary>
        /// Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("queryTimeout")]
        public Input<object>? QueryTimeout { get; set; }

        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sourceRetryCount")]
        public Input<object>? SourceRetryCount { get; set; }

        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sourceRetryWait")]
        public Input<object>? SourceRetryWait { get; set; }

        /// <summary>
        /// SQL reader query. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("sqlReaderQuery")]
        public Input<object>? SqlReaderQuery { get; set; }

        /// <summary>
        /// Name of the stored procedure for a SQL Database source. This cannot be used at the same time as SqlReaderQuery. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("sqlReaderStoredProcedureName")]
        public Input<object>? SqlReaderStoredProcedureName { get; set; }

        [Input("storedProcedureParameters")]
        private InputMap<Inputs.StoredProcedureParameterArgs>? _storedProcedureParameters;

        /// <summary>
        /// Value and type setting for stored procedure parameters. Example: "{Parameter1: {value: "1", type: "int"}}".
        /// </summary>
        public InputMap<Inputs.StoredProcedureParameterArgs> StoredProcedureParameters
        {
            get => _storedProcedureParameters ?? (_storedProcedureParameters = new InputMap<Inputs.StoredProcedureParameterArgs>());
            set => _storedProcedureParameters = value;
        }

        /// <summary>
        /// Copy source type.
        /// Expected value is 'TabularSource'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureSqlSourceArgs()
        {
        }
    }
}
