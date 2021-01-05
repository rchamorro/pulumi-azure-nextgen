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
    public sealed class ExcelDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The data compression method used for the json dataset.
        /// </summary>
        public readonly object? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? FirstRowAsHeader;
        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        public readonly Outputs.DatasetResponseFolder? Folder;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// The location of the excel storage.
        /// </summary>
        public readonly object Location;
        /// <summary>
        /// The null value string. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? NullValue;
        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// The partial data of one sheet. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Range;
        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        public readonly object? Schema;
        /// <summary>
        /// The sheet of excel file. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object SheetName;
        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public readonly object? Structure;
        /// <summary>
        /// Type of dataset.
        /// Expected value is 'Excel'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ExcelDatasetResponse(
            ImmutableArray<object> annotations,

            object? compression,

            string? description,

            object? firstRowAsHeader,

            Outputs.DatasetResponseFolder? folder,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            object location,

            object? nullValue,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? range,

            object? schema,

            object sheetName,

            object? structure,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            FirstRowAsHeader = firstRowAsHeader;
            Folder = folder;
            LinkedServiceName = linkedServiceName;
            Location = location;
            NullValue = nullValue;
            Parameters = parameters;
            Range = range;
            Schema = schema;
            SheetName = sheetName;
            Structure = structure;
            Type = type;
        }
    }
}
