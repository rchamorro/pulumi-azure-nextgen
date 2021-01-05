// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NetApp.V20200201
{
    public static class GetPool
    {
        public static Task<GetPoolResult> InvokeAsync(GetPoolArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPoolResult>("azure-nextgen:netapp/v20200201:getPool", args ?? new GetPoolArgs(), options.WithVersion());
    }


    public sealed class GetPoolArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the NetApp account
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The name of the capacity pool
        /// </summary>
        [Input("poolName", required: true)]
        public string PoolName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPoolArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPoolResult
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// UUID v4 used to identify the Pool
        /// </summary>
        public readonly string PoolId;
        /// <summary>
        /// Azure lifecycle management
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The service level of the file system
        /// </summary>
        public readonly string ServiceLevel;
        /// <summary>
        /// Provisioned size of the pool (in bytes). Allowed values are in 4TiB chunks (value must be multiply of 4398046511104).
        /// </summary>
        public readonly double Size;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPoolResult(
            string id,

            string location,

            string name,

            string poolId,

            string provisioningState,

            string serviceLevel,

            double size,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Id = id;
            Location = location;
            Name = name;
            PoolId = poolId;
            ProvisioningState = provisioningState;
            ServiceLevel = serviceLevel;
            Size = size;
            Tags = tags;
            Type = type;
        }
    }
}
