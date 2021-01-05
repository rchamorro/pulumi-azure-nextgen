// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Synapse.V20190601Preview
{
    public static class GetSqlPool
    {
        public static Task<GetSqlPoolResult> InvokeAsync(GetSqlPoolArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSqlPoolResult>("azure-nextgen:synapse/v20190601preview:getSqlPool", args ?? new GetSqlPoolArgs(), options.WithVersion());
    }


    public sealed class GetSqlPoolArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// SQL pool name
        /// </summary>
        [Input("sqlPoolName", required: true)]
        public string SqlPoolName { get; set; } = null!;

        /// <summary>
        /// The name of the workspace
        /// </summary>
        [Input("workspaceName", required: true)]
        public string WorkspaceName { get; set; } = null!;

        public GetSqlPoolArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSqlPoolResult
    {
        /// <summary>
        /// Collation mode
        /// </summary>
        public readonly string? Collation;
        /// <summary>
        /// What is this?
        /// </summary>
        public readonly string? CreateMode;
        /// <summary>
        /// Date the SQL pool was created
        /// </summary>
        public readonly string? CreationDate;
        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Maximum size in bytes
        /// </summary>
        public readonly double? MaxSizeBytes;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Resource state
        /// </summary>
        public readonly string? ProvisioningState;
        /// <summary>
        /// Backup database to restore from
        /// </summary>
        public readonly string? RecoverableDatabaseId;
        /// <summary>
        /// Snapshot time to restore
        /// </summary>
        public readonly string? RestorePointInTime;
        /// <summary>
        /// SQL pool SKU
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Source database to create from
        /// </summary>
        public readonly string? SourceDatabaseId;
        /// <summary>
        /// Resource status
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSqlPoolResult(
            string? collation,

            string? createMode,

            string? creationDate,

            string id,

            string location,

            double? maxSizeBytes,

            string name,

            string? provisioningState,

            string? recoverableDatabaseId,

            string? restorePointInTime,

            Outputs.SkuResponse? sku,

            string? sourceDatabaseId,

            string? status,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Collation = collation;
            CreateMode = createMode;
            CreationDate = creationDate;
            Id = id;
            Location = location;
            MaxSizeBytes = maxSizeBytes;
            Name = name;
            ProvisioningState = provisioningState;
            RecoverableDatabaseId = recoverableDatabaseId;
            RestorePointInTime = restorePointInTime;
            Sku = sku;
            SourceDatabaseId = sourceDatabaseId;
            Status = status;
            Tags = tags;
            Type = type;
        }
    }
}
