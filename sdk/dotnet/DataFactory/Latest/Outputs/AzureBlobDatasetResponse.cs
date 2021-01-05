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
    public sealed class AzureBlobDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The data compression method used for the blob storage.
        /// </summary>
        public readonly object? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The name of the Azure Blob. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileName;
        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        public readonly Outputs.DatasetResponseFolder? Folder;
        /// <summary>
        /// The path of the Azure Blob storage. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FolderPath;
        /// <summary>
        /// The format of the Azure Blob storage.
        /// </summary>
        public readonly object? Format;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// The end of Azure Blob's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ModifiedDatetimeEnd;
        /// <summary>
        /// The start of Azure Blob's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? ModifiedDatetimeStart;
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
        /// The root of blob path. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? TableRootLocation;
        /// <summary>
        /// Type of dataset.
        /// Expected value is 'AzureBlob'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureBlobDatasetResponse(
            ImmutableArray<object> annotations,

            object? compression,

            string? description,

            object? fileName,

            Outputs.DatasetResponseFolder? folder,

            object? folderPath,

            object? format,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            object? modifiedDatetimeEnd,

            object? modifiedDatetimeStart,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? schema,

            object? structure,

            object? tableRootLocation,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            FileName = fileName;
            Folder = folder;
            FolderPath = folderPath;
            Format = format;
            LinkedServiceName = linkedServiceName;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            Parameters = parameters;
            Schema = schema;
            Structure = structure;
            TableRootLocation = tableRootLocation;
            Type = type;
        }
    }
}
