// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ChangeAnalysis.V20200401Preview.Outputs
{

    [OutputType]
    public sealed class NotificationSettingsResponse
    {
        /// <summary>
        /// The state of notifications feature.
        /// </summary>
        public readonly string? ActivationState;
        /// <summary>
        /// Configuration properties of an Azure Monitor workspace that receives change notifications.
        /// </summary>
        public readonly Outputs.AzureMonitorWorkspacePropertiesResponse? AzureMonitorWorkspaceProperties;

        [OutputConstructor]
        private NotificationSettingsResponse(
            string? activationState,

            Outputs.AzureMonitorWorkspacePropertiesResponse? azureMonitorWorkspaceProperties)
        {
            ActivationState = activationState;
            AzureMonitorWorkspaceProperties = azureMonitorWorkspaceProperties;
        }
    }
}