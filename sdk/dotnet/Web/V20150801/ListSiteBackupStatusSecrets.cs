// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801
{
    public static class ListSiteBackupStatusSecrets
    {
        public static Task<ListSiteBackupStatusSecretsResult> InvokeAsync(ListSiteBackupStatusSecretsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListSiteBackupStatusSecretsResult>("azure-nextgen:web/v20150801:listSiteBackupStatusSecrets", args ?? new ListSiteBackupStatusSecretsArgs(), options.WithVersion());
    }


    public sealed class ListSiteBackupStatusSecretsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Id of backup
        /// </summary>
        [Input("backupId", required: true)]
        public string BackupId { get; set; } = null!;

        /// <summary>
        /// Schedule for the backup if it is executed periodically
        /// </summary>
        [Input("backupSchedule")]
        public Inputs.BackupScheduleArgs? BackupSchedule { get; set; }

        [Input("databases")]
        private List<Inputs.DatabaseBackupSettingArgs>? _databases;

        /// <summary>
        /// Databases included in the backup
        /// </summary>
        public List<Inputs.DatabaseBackupSettingArgs> Databases
        {
            get => _databases ?? (_databases = new List<Inputs.DatabaseBackupSettingArgs>());
            set => _databases = value;
        }

        /// <summary>
        /// True if the backup schedule is enabled (must be included in that case), false if the backup schedule should be disabled
        /// </summary>
        [Input("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [Input("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Resource Location
        /// </summary>
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Resource Name
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Name of resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// SAS URL to the container
        /// </summary>
        [Input("storageAccountUrl")]
        public string? StorageAccountUrl { get; set; }

        [Input("tags")]
        private Dictionary<string, string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        /// <summary>
        /// Resource type
        /// </summary>
        [Input("type", required: true)]
        public string Type { get; set; } = null!;

        public ListSiteBackupStatusSecretsArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListSiteBackupStatusSecretsResult
    {
        /// <summary>
        /// Name of the blob which contains data for this backup
        /// </summary>
        public readonly string? BlobName;
        /// <summary>
        /// Unique correlation identifier. Please use this along with the timestamp while communicating with Azure support.
        /// </summary>
        public readonly string? CorrelationId;
        /// <summary>
        /// Timestamp of the backup creation
        /// </summary>
        public readonly string? Created;
        /// <summary>
        /// List of databases included in the backup
        /// </summary>
        public readonly ImmutableArray<Outputs.DatabaseBackupSettingResponseResult> Databases;
        /// <summary>
        /// Timestamp when this backup finished.
        /// </summary>
        public readonly string? FinishedTimeStamp;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Kind of resource
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Timestamp of a last restore operation which used this backup.
        /// </summary>
        public readonly string? LastRestoreTimeStamp;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Details regarding this backup. Might contain an error message.
        /// </summary>
        public readonly string? Log;
        /// <summary>
        /// Resource Name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// True if this backup has been created due to a schedule being triggered.
        /// </summary>
        public readonly bool? Scheduled;
        /// <summary>
        /// Size of the backup in bytes
        /// </summary>
        public readonly double? SizeInBytes;
        /// <summary>
        /// Backup status
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// SAS URL for the storage account container which contains this backup
        /// </summary>
        public readonly string? StorageAccountUrl;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Size of the original web app which has been backed up
        /// </summary>
        public readonly double? WebsiteSizeInBytes;

        [OutputConstructor]
        private ListSiteBackupStatusSecretsResult(
            string? blobName,

            string? correlationId,

            string? created,

            ImmutableArray<Outputs.DatabaseBackupSettingResponseResult> databases,

            string? finishedTimeStamp,

            string? id,

            string? kind,

            string? lastRestoreTimeStamp,

            string location,

            string? log,

            string? name,

            bool? scheduled,

            double? sizeInBytes,

            string status,

            string? storageAccountUrl,

            ImmutableDictionary<string, string>? tags,

            string? type,

            double? websiteSizeInBytes)
        {
            BlobName = blobName;
            CorrelationId = correlationId;
            Created = created;
            Databases = databases;
            FinishedTimeStamp = finishedTimeStamp;
            Id = id;
            Kind = kind;
            LastRestoreTimeStamp = lastRestoreTimeStamp;
            Location = location;
            Log = log;
            Name = name;
            Scheduled = scheduled;
            SizeInBytes = sizeInBytes;
            Status = status;
            StorageAccountUrl = storageAccountUrl;
            Tags = tags;
            Type = type;
            WebsiteSizeInBytes = websiteSizeInBytes;
        }
    }
}
