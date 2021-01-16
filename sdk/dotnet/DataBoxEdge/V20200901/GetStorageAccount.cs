// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901
{
    public static class GetStorageAccount
    {
        public static Task<GetStorageAccountResult> InvokeAsync(GetStorageAccountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStorageAccountResult>("azure-nextgen:databoxedge/v20200901:getStorageAccount", args ?? new GetStorageAccountArgs(), options.WithVersion());
    }


    public sealed class GetStorageAccountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The storage account name.
        /// </summary>
        [Input("storageAccountName", required: true)]
        public string StorageAccountName { get; set; } = null!;

        public GetStorageAccountArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStorageAccountResult
    {
        /// <summary>
        /// BlobEndpoint of Storage Account
        /// </summary>
        public readonly string BlobEndpoint;
        /// <summary>
        /// The Container Count. Present only for Storage Accounts with DataPolicy set to Cloud.
        /// </summary>
        public readonly int ContainerCount;
        /// <summary>
        /// Data policy of the storage Account.
        /// </summary>
        public readonly string DataPolicy;
        /// <summary>
        /// Description for the storage Account.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The path ID that uniquely identifies the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The object name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Storage Account Credential Id
        /// </summary>
        public readonly string? StorageAccountCredentialId;
        /// <summary>
        /// Current status of the storage account
        /// </summary>
        public readonly string? StorageAccountStatus;
        /// <summary>
        /// StorageAccount object on ASE device
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStorageAccountResult(
            string blobEndpoint,

            int containerCount,

            string dataPolicy,

            string? description,

            string id,

            string name,

            string? storageAccountCredentialId,

            string? storageAccountStatus,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            BlobEndpoint = blobEndpoint;
            ContainerCount = containerCount;
            DataPolicy = dataPolicy;
            Description = description;
            Id = id;
            Name = name;
            StorageAccountCredentialId = storageAccountCredentialId;
            StorageAccountStatus = storageAccountStatus;
            SystemData = systemData;
            Type = type;
        }
    }
}
