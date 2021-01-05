// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Insights.V20170501Preview
{
    public static class GetSubscriptionDiagnosticSetting
    {
        public static Task<GetSubscriptionDiagnosticSettingResult> InvokeAsync(GetSubscriptionDiagnosticSettingArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSubscriptionDiagnosticSettingResult>("azure-nextgen:insights/v20170501preview:getSubscriptionDiagnosticSetting", args ?? new GetSubscriptionDiagnosticSettingArgs(), options.WithVersion());
    }


    public sealed class GetSubscriptionDiagnosticSettingArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the diagnostic setting.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The subscription id.
        /// </summary>
        [Input("subscriptionId")]
        public string? SubscriptionId { get; set; }

        public GetSubscriptionDiagnosticSettingArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSubscriptionDiagnosticSettingResult
    {
        /// <summary>
        /// The resource Id for the event hub authorization rule.
        /// </summary>
        public readonly string? EventHubAuthorizationRuleId;
        /// <summary>
        /// The name of the event hub. If none is specified, the default event hub will be selected.
        /// </summary>
        public readonly string? EventHubName;
        /// <summary>
        /// Azure resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Location of the resource
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The list of logs settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubscriptionLogSettingsResponse> Logs;
        /// <summary>
        /// Azure resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The service bus rule Id of the diagnostic setting. This is here to maintain backwards compatibility.
        /// </summary>
        public readonly string? ServiceBusRuleId;
        /// <summary>
        /// The resource ID of the storage account to which you would like to send Diagnostic Logs.
        /// </summary>
        public readonly string? StorageAccountId;
        /// <summary>
        /// Azure resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The full ARM resource ID of the Log Analytics workspace to which you would like to send Diagnostic Logs. Example: /subscriptions/4b9e8510-67ab-4e9a-95a9-e2f1e570ea9c/resourceGroups/insights-integration/providers/Microsoft.OperationalInsights/workspaces/viruela2
        /// </summary>
        public readonly string? WorkspaceId;

        [OutputConstructor]
        private GetSubscriptionDiagnosticSettingResult(
            string? eventHubAuthorizationRuleId,

            string? eventHubName,

            string id,

            string? location,

            ImmutableArray<Outputs.SubscriptionLogSettingsResponse> logs,

            string name,

            string? serviceBusRuleId,

            string? storageAccountId,

            string type,

            string? workspaceId)
        {
            EventHubAuthorizationRuleId = eventHubAuthorizationRuleId;
            EventHubName = eventHubName;
            Id = id;
            Location = location;
            Logs = logs;
            Name = name;
            ServiceBusRuleId = serviceBusRuleId;
            StorageAccountId = storageAccountId;
            Type = type;
            WorkspaceId = workspaceId;
        }
    }
}
