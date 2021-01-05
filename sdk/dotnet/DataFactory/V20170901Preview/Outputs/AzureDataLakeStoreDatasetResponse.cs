// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class AzureDataLakeStoreDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The data compression method used for the item(s) in the Azure Data Lake Store.
        /// </summary>
        public readonly object? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The name of the file in the Azure Data Lake Store. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileName;
        /// <summary>
        /// Path to the folder in the Azure Data Lake Store. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object FolderPath;
        /// <summary>
        /// The format of the Data Lake Store.
        /// </summary>
        public readonly object? Format;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? Parameters;
        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        public readonly object? Structure;
        /// <summary>
        /// Type of dataset.
        /// Expected value is 'AzureDataLakeStoreFile'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureDataLakeStoreDatasetResponse(
            ImmutableArray<object> annotations,

            object? compression,

            string? description,

            object? fileName,

            object folderPath,

            object? format,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? structure,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            FileName = fileName;
            FolderPath = folderPath;
            Format = format;
            LinkedServiceName = linkedServiceName;
            Parameters = parameters;
            Structure = structure;
            Type = type;
        }
    }
}
