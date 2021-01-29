// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AppConfiguration.V20190201Preview
{
    public static class ListConfigurationStoreKeys
    {
        public static Task<ListConfigurationStoreKeysResult> InvokeAsync(ListConfigurationStoreKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListConfigurationStoreKeysResult>("azure-nextgen:appconfiguration/v20190201preview:listConfigurationStoreKeys", args ?? new ListConfigurationStoreKeysArgs(), options.WithVersion());
    }


    public sealed class ListConfigurationStoreKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the configuration store.
        /// </summary>
        [Input("configStoreName", required: true)]
        public string ConfigStoreName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group to which the container registry belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.
        /// </summary>
        [Input("skipToken")]
        public string? SkipToken { get; set; }

        public ListConfigurationStoreKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListConfigurationStoreKeysResult
    {
        /// <summary>
        /// The URI that can be used to request the next set of paged results.
        /// </summary>
        public readonly string? NextLink;
        /// <summary>
        /// The collection value.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApiKeyResponseResult> Value;

        [OutputConstructor]
        private ListConfigurationStoreKeysResult(
            string? nextLink,

            ImmutableArray<Outputs.ApiKeyResponseResult> value)
        {
            NextLink = nextLink;
            Value = value;
        }
    }
}
