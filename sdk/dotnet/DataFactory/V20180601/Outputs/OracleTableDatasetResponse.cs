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
    public sealed class OracleTableDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        public readonly Outputs.DatasetResponseFolder? Folder;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        public readonly object? Schema;
        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public readonly object? Structure;
        /// <summary>
        /// The table name of the on-premises Oracle database. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Table;
        /// <summary>
        /// This property will be retired. Please consider using schema + table properties instead.
        /// </summary>
        public readonly object? TableName;
        /// <summary>
        /// Type of dataset.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private OracleTableDatasetResponse(
            ImmutableArray<object> annotations,

            string? description,

            Outputs.DatasetResponseFolder? folder,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? schema,

            object? structure,

            object? table,

            object? tableName,

            string type)
        {
            Annotations = annotations;
            Description = description;
            Folder = folder;
            LinkedServiceName = linkedServiceName;
            Parameters = parameters;
            Schema = schema;
            Structure = structure;
            Table = table;
            TableName = tableName;
            Type = type;
        }
    }
}
