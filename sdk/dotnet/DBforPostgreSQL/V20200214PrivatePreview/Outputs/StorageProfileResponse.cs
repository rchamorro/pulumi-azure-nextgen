// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBForPostgreSql.V20200214PrivatePreview.Outputs
{

    [OutputType]
    public sealed class StorageProfileResponse
    {
        /// <summary>
        /// Backup retention days for the server.
        /// </summary>
        public readonly int? BackupRetentionDays;
        /// <summary>
        /// Max storage allowed for a server.
        /// </summary>
        public readonly int? StorageMB;

        [OutputConstructor]
        private StorageProfileResponse(
            int? backupRetentionDays,

            int? storageMB)
        {
            BackupRetentionDays = backupRetentionDays;
            StorageMB = storageMB;
        }
    }
}