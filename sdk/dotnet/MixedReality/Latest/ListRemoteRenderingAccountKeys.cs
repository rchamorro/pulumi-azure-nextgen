// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MixedReality.Latest
{
    public static class ListRemoteRenderingAccountKeys
    {
        public static Task<ListRemoteRenderingAccountKeysResult> InvokeAsync(ListRemoteRenderingAccountKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListRemoteRenderingAccountKeysResult>("azure-nextgen:mixedreality/latest:listRemoteRenderingAccountKeys", args ?? new ListRemoteRenderingAccountKeysArgs(), options.WithVersion());
    }


    public sealed class ListRemoteRenderingAccountKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of an Mixed Reality Account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListRemoteRenderingAccountKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListRemoteRenderingAccountKeysResult
    {
        /// <summary>
        /// value of primary key.
        /// </summary>
        public readonly string PrimaryKey;
        /// <summary>
        /// value of secondary key.
        /// </summary>
        public readonly string SecondaryKey;

        [OutputConstructor]
        private ListRemoteRenderingAccountKeysResult(
            string primaryKey,

            string secondaryKey)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
        }
    }
}
