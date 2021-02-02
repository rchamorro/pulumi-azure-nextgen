// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20210101
{
    public static class GetProtectedItem
    {
        public static Task<GetProtectedItemResult> InvokeAsync(GetProtectedItemArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProtectedItemResult>("azure-nextgen:recoveryservices/v20210101:getProtectedItem", args ?? new GetProtectedItemArgs(), options.WithVersion());
    }


    public sealed class GetProtectedItemArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Container name associated with the backed up item.
        /// </summary>
        [Input("containerName", required: true)]
        public string ContainerName { get; set; } = null!;

        /// <summary>
        /// Fabric name associated with the backed up item.
        /// </summary>
        [Input("fabricName", required: true)]
        public string FabricName { get; set; } = null!;

        /// <summary>
        /// OData filter options.
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Backed up item name whose details are to be fetched.
        /// </summary>
        [Input("protectedItemName", required: true)]
        public string ProtectedItemName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("vaultName", required: true)]
        public string VaultName { get; set; } = null!;

        public GetProtectedItemArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProtectedItemResult
    {
        /// <summary>
        /// Optional ETag.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// Resource Id represents the complete path to the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name associated with the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// ProtectedItemResource properties
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetProtectedItemResult(
            string? eTag,

            string id,

            string? location,

            string name,

            object properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ETag = eTag;
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
