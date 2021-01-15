// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.Latest.Inputs
{

    /// <summary>
    /// Azure File Share mounting configuration.
    /// </summary>
    public sealed class AzureFileShareReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the Azure storage account.
        /// </summary>
        [Input("accountName", required: true)]
        public Input<string> AccountName { get; set; } = null!;

        /// <summary>
        /// URL to access the Azure File.
        /// </summary>
        [Input("azureFileUrl", required: true)]
        public Input<string> AzureFileUrl { get; set; } = null!;

        /// <summary>
        /// Information about the Azure storage credentials.
        /// </summary>
        [Input("credentials", required: true)]
        public Input<Inputs.AzureStorageCredentialsInfoArgs> Credentials { get; set; } = null!;

        /// <summary>
        /// File mode for directories on the mounted file share. Default value: 0777.
        /// </summary>
        [Input("directoryMode")]
        public Input<string>? DirectoryMode { get; set; }

        /// <summary>
        /// File mode for files on the mounted file share. Default value: 0777.
        /// </summary>
        [Input("fileMode")]
        public Input<string>? FileMode { get; set; }

        /// <summary>
        /// The relative path on the compute node where the Azure File share will be mounted. Note that all cluster level file shares will be mounted under $AZ_BATCHAI_MOUNT_ROOT location and all job level file shares will be mounted under $AZ_BATCHAI_JOB_MOUNT_ROOT.
        /// </summary>
        [Input("relativeMountPath", required: true)]
        public Input<string> RelativeMountPath { get; set; } = null!;

        public AzureFileShareReferenceArgs()
        {
            DirectoryMode = "0777";
            FileMode = "0777";
        }
    }
}
