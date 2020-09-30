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
    /// Excel dataset.
    /// </summary>
    public sealed class ExcelDatasetArgs : Pulumi.ResourceArgs
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
        /// The data compression method used for the json dataset.
        /// </summary>
        [Input("compression")]
        public InputUnion<Inputs.DatasetBZip2CompressionArgs, InputUnion<Inputs.DatasetDeflateCompressionArgs, InputUnion<Inputs.DatasetGZipCompressionArgs, InputUnion<Inputs.DatasetTarCompressionArgs, InputUnion<Inputs.DatasetTarGZipCompressionArgs, Inputs.DatasetZipDeflateCompressionArgs>>>>>? Compression { get; set; }

        /// <summary>
        /// Dataset description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// When used as input, treat the first row of data as headers. When used as output,write the headers into the output as the first row of data. The default value is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("firstRowAsHeader")]
        public Input<object>? FirstRowAsHeader { get; set; }

        /// <summary>
        /// The folder that this Dataset is in. If not specified, Dataset will appear at the root level.
        /// </summary>
        [Input("folder")]
        public Input<Inputs.DatasetFolderArgs>? Folder { get; set; }

        /// <summary>
        /// Linked service reference.
        /// </summary>
        [Input("linkedServiceName", required: true)]
        public Input<Inputs.LinkedServiceReferenceArgs> LinkedServiceName { get; set; } = null!;

        /// <summary>
        /// The location of the excel storage.
        /// </summary>
        [Input("location", required: true)]
        public InputUnion<Inputs.AmazonS3LocationArgs, InputUnion<Inputs.AzureBlobFSLocationArgs, InputUnion<Inputs.AzureBlobStorageLocationArgs, InputUnion<Inputs.AzureDataLakeStoreLocationArgs, InputUnion<Inputs.AzureFileStorageLocationArgs, InputUnion<Inputs.FileServerLocationArgs, InputUnion<Inputs.FtpServerLocationArgs, InputUnion<Inputs.GoogleCloudStorageLocationArgs, InputUnion<Inputs.HdfsLocationArgs, InputUnion<Inputs.HttpServerLocationArgs, Inputs.SftpLocationArgs>>>>>>>>>> Location { get; set; } = null!;

        /// <summary>
        /// The null value string. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("nullValue")]
        public Input<object>? NullValue { get; set; }

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
        /// The partial data of one sheet. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("range")]
        public Input<object>? Range { get; set; }

        /// <summary>
        /// Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement.
        /// </summary>
        [Input("schema")]
        public Input<object>? Schema { get; set; }

        /// <summary>
        /// The sheet of excel file. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("sheetName", required: true)]
        public Input<object> SheetName { get; set; } = null!;

        /// <summary>
        /// Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement.
        /// </summary>
        [Input("structure")]
        public Input<object>? Structure { get; set; }

        /// <summary>
        /// Type of dataset.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ExcelDatasetArgs()
        {
        }
    }
}
