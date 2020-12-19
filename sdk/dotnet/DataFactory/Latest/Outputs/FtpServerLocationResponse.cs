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
    public sealed class FtpServerLocationResponse
    {
        /// <summary>
        /// Specify the file name of dataset. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? FileName;
        /// <summary>
        /// Specify the folder path of dataset. Type: string (or Expression with resultType string)
        /// </summary>
        public readonly object? FolderPath;
        /// <summary>
        /// Type of dataset storage location.
        /// Expected value is 'FtpServerLocation'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private FtpServerLocationResponse(
            object? fileName,

            object? folderPath,

            string type)
        {
            FileName = fileName;
            FolderPath = folderPath;
            Type = type;
        }
    }
}
