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
    /// Parquet write settings.
    /// </summary>
    public sealed class ParquetWriteSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("fileNamePrefix")]
        public Input<object>? FileNamePrefix { get; set; }

        /// <summary>
        /// Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxRowsPerFile")]
        public Input<object>? MaxRowsPerFile { get; set; }

        /// <summary>
        /// The write setting type.
        /// Expected value is 'ParquetWriteSettings'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ParquetWriteSettingsArgs()
        {
        }
    }
}
