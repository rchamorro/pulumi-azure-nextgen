// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.Latest
{
    public static class ListQueueKeys
    {
        public static Task<ListQueueKeysResult> InvokeAsync(ListQueueKeysArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<ListQueueKeysResult>("azure-nextgen:servicebus/latest:listQueueKeys", args ?? new ListQueueKeysArgs(), options.WithVersion());
    }


    public sealed class ListQueueKeysArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The authorization rule name.
        /// </summary>
        [Input("authorizationRuleName", required: true)]
        public string AuthorizationRuleName { get; set; } = null!;

        /// <summary>
        /// The namespace name
        /// </summary>
        [Input("namespaceName", required: true)]
        public string NamespaceName { get; set; } = null!;

        /// <summary>
        /// The queue name.
        /// </summary>
        [Input("queueName", required: true)]
        public string QueueName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public ListQueueKeysArgs()
        {
        }
    }


    [OutputType]
    public sealed class ListQueueKeysResult
    {
        /// <summary>
        /// Primary connection string of the alias if GEO DR is enabled
        /// </summary>
        public readonly string AliasPrimaryConnectionString;
        /// <summary>
        /// Secondary  connection string of the alias if GEO DR is enabled
        /// </summary>
        public readonly string AliasSecondaryConnectionString;
        /// <summary>
        /// A string that describes the authorization rule.
        /// </summary>
        public readonly string KeyName;
        /// <summary>
        /// Primary connection string of the created namespace authorization rule.
        /// </summary>
        public readonly string PrimaryConnectionString;
        /// <summary>
        /// A base64-encoded 256-bit primary key for signing and validating the SAS token.
        /// </summary>
        public readonly string PrimaryKey;
        /// <summary>
        /// Secondary connection string of the created namespace authorization rule.
        /// </summary>
        public readonly string SecondaryConnectionString;
        /// <summary>
        /// A base64-encoded 256-bit primary key for signing and validating the SAS token.
        /// </summary>
        public readonly string SecondaryKey;

        [OutputConstructor]
        private ListQueueKeysResult(
            string aliasPrimaryConnectionString,

            string aliasSecondaryConnectionString,

            string keyName,

            string primaryConnectionString,

            string primaryKey,

            string secondaryConnectionString,

            string secondaryKey)
        {
            AliasPrimaryConnectionString = aliasPrimaryConnectionString;
            AliasSecondaryConnectionString = aliasSecondaryConnectionString;
            KeyName = keyName;
            PrimaryConnectionString = primaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryConnectionString = secondaryConnectionString;
            SecondaryKey = secondaryKey;
        }
    }
}
