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
    public sealed class OrcWriteSettingsResponse
    {
        /// <summary>
        /// Specifies the file name pattern &lt;fileNamePrefix&gt;_&lt;fileIndex&gt;.&lt;fileExtension&gt; when copy from non-file based store without partitionOptions. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileNamePrefix;
        /// <summary>
        /// Limit the written file's row count to be smaller than or equal to the specified count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxRowsPerFile;
        /// <summary>
        /// The write setting type.
        /// Expected value is 'OrcWriteSettings'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private OrcWriteSettingsResponse(
            object? fileNamePrefix,

            object? maxRowsPerFile,

            string type)
        {
            FileNamePrefix = fileNamePrefix;
            MaxRowsPerFile = maxRowsPerFile;
            Type = type;
        }
    }
}
