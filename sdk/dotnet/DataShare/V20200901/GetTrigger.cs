// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataShare.V20200901
{
    public static class GetTrigger
    {
        public static Task<GetTriggerResult> InvokeAsync(GetTriggerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTriggerResult>("azure-nextgen:datashare/v20200901:getTrigger", args ?? new GetTriggerArgs(), options.WithVersion());
    }


    public sealed class GetTriggerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the share account.
        /// </summary>
        [Input("accountName", required: true)]
        public string AccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the shareSubscription.
        /// </summary>
        [Input("shareSubscriptionName", required: true)]
        public string ShareSubscriptionName { get; set; } = null!;

        /// <summary>
        /// The name of the trigger.
        /// </summary>
        [Input("triggerName", required: true)]
        public string TriggerName { get; set; } = null!;

        public GetTriggerArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTriggerResult
    {
        /// <summary>
        /// The resource id of the azure resource
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Kind of synchronization
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Name of the azure resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// System Data of the Azure resource.
        /// </summary>
        public readonly Outputs.ProxyDtoResponseSystemData SystemData;
        /// <summary>
        /// Type of the azure resource
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetTriggerResult(
            string id,

            string kind,

            string name,

            Outputs.ProxyDtoResponseSystemData systemData,

            string type)
        {
            Id = id;
            Kind = kind;
            Name = name;
            SystemData = systemData;
            Type = type;
        }
    }
}
