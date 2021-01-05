// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ImportExport.V20200801.Inputs
{

    /// <summary>
    /// Provides information about the drive's status
    /// </summary>
    public sealed class DriveStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The BitLocker key used to encrypt the drive.
        /// </summary>
        [Input("bitLockerKey")]
        public Input<string>? BitLockerKey { get; set; }

        /// <summary>
        /// Bytes successfully transferred for the drive.
        /// </summary>
        [Input("bytesSucceeded")]
        public Input<double>? BytesSucceeded { get; set; }

        /// <summary>
        /// Detailed status about the data transfer process. This field is not returned in the response until the drive is in the Transferring state.
        /// </summary>
        [Input("copyStatus")]
        public Input<string>? CopyStatus { get; set; }

        /// <summary>
        /// The drive header hash value.
        /// </summary>
        [Input("driveHeaderHash")]
        public Input<string>? DriveHeaderHash { get; set; }

        /// <summary>
        /// The drive's hardware serial number, without spaces.
        /// </summary>
        [Input("driveId")]
        public Input<string>? DriveId { get; set; }

        /// <summary>
        /// A URI that points to the blob containing the error log for the data transfer operation.
        /// </summary>
        [Input("errorLogUri")]
        public Input<string>? ErrorLogUri { get; set; }

        /// <summary>
        /// The relative path of the manifest file on the drive. 
        /// </summary>
        [Input("manifestFile")]
        public Input<string>? ManifestFile { get; set; }

        /// <summary>
        /// The Base16-encoded MD5 hash of the manifest file on the drive.
        /// </summary>
        [Input("manifestHash")]
        public Input<string>? ManifestHash { get; set; }

        /// <summary>
        /// A URI that points to the blob containing the drive manifest file. 
        /// </summary>
        [Input("manifestUri")]
        public Input<string>? ManifestUri { get; set; }

        /// <summary>
        /// Percentage completed for the drive. 
        /// </summary>
        [Input("percentComplete")]
        public Input<int>? PercentComplete { get; set; }

        /// <summary>
        /// The drive's current state. 
        /// </summary>
        [Input("state")]
        public InputUnion<string, Pulumi.AzureNextGen.ImportExport.V20200801.DriveState>? State { get; set; }

        /// <summary>
        /// A URI that points to the blob containing the verbose log for the data transfer operation. 
        /// </summary>
        [Input("verboseLogUri")]
        public Input<string>? VerboseLogUri { get; set; }

        public DriveStatusArgs()
        {
        }
    }
}
