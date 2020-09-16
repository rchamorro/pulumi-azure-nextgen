// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.NotificationHubs.V20160301
{
    public static class ListNamespaceKeys
    {
        public static Task<ListNamespaceKeysResult> InvokeAsync(ListNamespaceKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListNamespaceKeysResult>("azure-nextgen:notificationhubs/v20160301:listNamespaceKeys", args ?? new ListNamespaceKeysArgs(), options.WithVersion());
    }


    public sealed class ListNamespaceKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The connection string of the namespace for the specified authorizationRule.
        /// </summary>
        [Input("authorizationRuleName", required: true)]
        public string AuthorizationRuleName { get; set; } = null!;

        /// <summary>
        /// The namespace name.
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListNamespaceKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListNamespaceKeysResult
    {
        /// <summary>
        /// KeyName of the created AuthorizationRule
        /// </summary>
        public readonly string? KeyName;
        /// <summary>
        /// PrimaryConnectionString of the AuthorizationRule.
        /// </summary>
        public readonly string? PrimaryConnectionString;
        /// <summary>
        /// PrimaryKey of the created AuthorizationRule.
        /// </summary>
        public readonly string? PrimaryKey;
        /// <summary>
        /// SecondaryConnectionString of the created AuthorizationRule
        /// </summary>
        public readonly string? SecondaryConnectionString;
        /// <summary>
        /// SecondaryKey of the created AuthorizationRule
        /// </summary>
        public readonly string? SecondaryKey;

        [OutputConstructor]
        private ListNamespaceKeysResult(
            string? keyName,

            string? primaryConnectionString,

            string? primaryKey,

            string? secondaryConnectionString,

            string? secondaryKey)
        {
            KeyName = keyName;
            PrimaryConnectionString = primaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryConnectionString = secondaryConnectionString;
            SecondaryKey = secondaryKey;
        }
    }
}