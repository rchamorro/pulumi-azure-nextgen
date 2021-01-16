// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Azure blob read settings.
    /// </summary>
    public sealed class AzureBlobStorageReadSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates whether the source files need to be deleted after copy completion. Default is false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("deleteFilesAfterCompletion")]
        public Input<object>? DeleteFilesAfterCompletion { get; set; }

        /// <summary>
        /// Indicates whether to enable partition discovery.
        /// </summary>
        [Input("enablePartitionDiscovery")]
        public Input<bool>? EnablePartitionDiscovery { get; set; }

        /// <summary>
        /// Point to a text file that lists each file (relative path to the path configured in the dataset) that you want to copy. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("fileListPath")]
        public Input<object>? FileListPath { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// The end of file's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("modifiedDatetimeEnd")]
        public Input<object>? ModifiedDatetimeEnd { get; set; }

        /// <summary>
        /// The start of file's modified datetime. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("modifiedDatetimeStart")]
        public Input<object>? ModifiedDatetimeStart { get; set; }

        /// <summary>
        /// Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("partitionRootPath")]
        public Input<object>? PartitionRootPath { get; set; }

        /// <summary>
        /// The prefix filter for the Azure Blob name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("prefix")]
        public Input<object>? Prefix { get; set; }

        /// <summary>
        /// If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("recursive")]
        public Input<object>? Recursive { get; set; }

        /// <summary>
        /// The read setting type.
        /// Expected value is 'AzureBlobStorageReadSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// Azure blob wildcardFileName. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("wildcardFileName")]
        public Input<object>? WildcardFileName { get; set; }

        /// <summary>
        /// Azure blob wildcardFolderPath. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("wildcardFolderPath")]
        public Input<object>? WildcardFolderPath { get; set; }

        public AzureBlobStorageReadSettingsArgs()
        {
        }
    }
}
