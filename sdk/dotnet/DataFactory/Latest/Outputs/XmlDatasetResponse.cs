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
    public sealed class XmlDatasetResponse
    {
        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public readonly ImmutableArray<object> Annotations;
        /// <summary>
        /// The data compression method used for the json dataset.
        /// </summary>
        public readonly Union<Outputs.DatasetBZip2CompressionResponse, Union<Outputs.DatasetDeflateCompressionResponse, Union<Outputs.DatasetGZipCompressionResponse, Union<Outputs.DatasetTarCompressionResponse, Union<Outputs.DatasetTarGZipCompressionResponse, Outputs.DatasetZipDeflateCompressionResponse>>>>>? Compression;
        /// <summary>
        /// Dataset description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The code page name of the preferred encoding. If not specified, the default value is UTF-8, unless BOM denotes another Unicode encoding. Refer to the name column of the table in the following link to set supported values: https://msdn.microsoft.com/library/system.text.encoding.aspx. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? EncodingName;
        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        public readonly Outputs.DatasetResponseFolder? Folder;
        /// <summary>
        /// Linked service reference.
        /// </summary>
        public readonly Outputs.LinkedServiceReferenceResponse LinkedServiceName;
        /// <summary>
        /// The location of the json data storage.
        /// </summary>
        public readonly Union<Outputs.AmazonS3LocationResponse, Union<Outputs.AzureBlobFSLocationResponse, Union<Outputs.AzureBlobStorageLocationResponse, Union<Outputs.AzureDataLakeStoreLocationResponse, Union<Outputs.AzureFileStorageLocationResponse, Union<Outputs.FileServerLocationResponse, Union<Outputs.FtpServerLocationResponse, Union<Outputs.GoogleCloudStorageLocationResponse, Union<Outputs.HdfsLocationResponse, Union<Outputs.HttpServerLocationResponse, Outputs.SftpLocationResponse>>>>>>>>>> Location;
        /// <summary>
        /// The null value string. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? NullValue;
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
        /// Type of dataset.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private XmlDatasetResponse(
            ImmutableArray<object> annotations,

            Union<Outputs.DatasetBZip2CompressionResponse, Union<Outputs.DatasetDeflateCompressionResponse, Union<Outputs.DatasetGZipCompressionResponse, Union<Outputs.DatasetTarCompressionResponse, Union<Outputs.DatasetTarGZipCompressionResponse, Outputs.DatasetZipDeflateCompressionResponse>>>>>? compression,

            string? description,

            object? encodingName,

            Outputs.DatasetResponseFolder? folder,

            Outputs.LinkedServiceReferenceResponse linkedServiceName,

            Union<Outputs.AmazonS3LocationResponse, Union<Outputs.AzureBlobFSLocationResponse, Union<Outputs.AzureBlobStorageLocationResponse, Union<Outputs.AzureDataLakeStoreLocationResponse, Union<Outputs.AzureFileStorageLocationResponse, Union<Outputs.FileServerLocationResponse, Union<Outputs.FtpServerLocationResponse, Union<Outputs.GoogleCloudStorageLocationResponse, Union<Outputs.HdfsLocationResponse, Union<Outputs.HttpServerLocationResponse, Outputs.SftpLocationResponse>>>>>>>>>> location,

            object? nullValue,

            ImmutableDictionary<string, Outputs.ParameterSpecificationResponse>? parameters,

            object? schema,

            object? structure,

            string type)
        {
            Annotations = annotations;
            Compression = compression;
            Description = description;
            EncodingName = encodingName;
            Folder = folder;
            LinkedServiceName = linkedServiceName;
            Location = location;
            NullValue = nullValue;
            Parameters = parameters;
            Schema = schema;
            Structure = structure;
            Type = type;
        }
    }
}
