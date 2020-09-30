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
    /// The Azure Blob storage.
    /// </summary>
    public sealed class AzureBlobDatasetArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputList<object>? _annotations;

        /// <summary>
        /// List of tags that can be used for describing the Dataset.
        /// </summary>
        public InputList<object> Annotations
        {
            get => _annotations ?? (_annotations = new InputList<object>());
            set => _annotations = value;
        }

        /// <summary>
        /// The data compression method used for the blob storage.
        /// </summary>
        [Input("compression")]
        public InputUnion<Inputs.DatasetBZip2CompressionArgs, InputUnion<Inputs.DatasetDeflateCompressionArgs, InputUnion<Inputs.DatasetGZipCompressionArgs, InputUnion<Inputs.DatasetTarCompressionArgs, InputUnion<Inputs.DatasetTarGZipCompressionArgs, Inputs.DatasetZipDeflateCompressionArgs>>>>>? Compression { get; set; }

        /// <summary>
        /// Dataset description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the Azure Blob. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("fileName")]
        public Input<object>? FileName { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<Inputs.DatasetFolderArgs>? Folder { get; set; }

        /// <summary>
        /// The path of the Azure Blob storage. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("folderPath")]
        public Input<object>? FolderPath { get; set; }

        /// <summary>
        /// The format of the Azure Blob storage.
        /// </summary>
        [Input("format")]
        public InputUnion<Inputs.AvroFormatArgs, InputUnion<Inputs.JsonFormatArgs, InputUnion<Inputs.OrcFormatArgs, InputUnion<Inputs.ParquetFormatArgs, Inputs.TextFormatArgs>>>>? Format { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// The end of Azure Blob's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("modifiedDatetimeEnd")]
        public Input<object>? ModifiedDatetimeEnd { get; set; }

        /// <summary>
        /// The start of Azure Blob's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("modifiedDatetimeStart")]
        public Input<object>? ModifiedDatetimeStart { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.ParameterSpecificationArgs>? _parameters;

        /// <summary>
        /// Parameters for dataset.
        /// </summary>
        public InputMap<Inputs.ParameterSpecificationArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.ParameterSpecificationArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        [Input("schema")]
        public Input<object>? Schema { get; set; }

        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        [Input("structure")]
        public Input<object>? Structure { get; set; }

        /// <summary>
        /// The root of blob path. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("tableRootLocation")]
        public Input<object>? TableRootLocation { get; set; }

        /// <summary>
        /// Type of dataset.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureBlobDatasetArgs()
        {
        }
    }
}
