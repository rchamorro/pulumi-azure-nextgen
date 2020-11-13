// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Aad.V20170101
{
    public static class GetDomainService
    {
        public static Task<GetDomainServiceResult> InvokeAsync(GetDomainServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDomainServiceResult>("azure-nextgen:aad/v20170101:getDomainService", args ?? new GetDomainServiceArgs(), options.WithVersion());
    }


    public sealed class GetDomainServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the domain service.
        /// </summary>
        [Input("domainServiceName", required: true)]
        public string DomainServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group within the user's subscription. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetDomainServiceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDomainServiceResult
    {
        /// <summary>
        /// Deployment Id
        /// </summary>
        public readonly string DeploymentId;
        /// <summary>
        /// List of Domain Controller IP Address
        /// </summary>
        public readonly ImmutableArray<string> DomainControllerIpAddress;
        /// <summary>
        /// The name of the Azure domain that the user would like to deploy Domain Services to.
        /// </summary>
        public readonly string? DomainName;
        /// <summary>
        /// DomainSecurity Settings
        /// </summary>
        public readonly Outputs.DomainSecuritySettingsResponse? DomainSecuritySettings;
        /// <summary>
        /// Resource etag
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Enabled or Disabled flag to turn on Group-based filtered sync
        /// </summary>
        public readonly string? FilteredSync;
        /// <summary>
        /// List of Domain Health Alerts
        /// </summary>
        public readonly ImmutableArray<Outputs.HealthAlertResponse> HealthAlerts;
        /// <summary>
        /// Last domain evaluation run DateTime
        /// </summary>
        public readonly string HealthLastEvaluated;
        /// <summary>
        /// List of Domain Health Monitors
        /// </summary>
        public readonly ImmutableArray<Outputs.HealthMonitorResponse> HealthMonitors;
        /// <summary>
        /// Secure LDAP Settings
        /// </summary>
        public readonly Outputs.LdapsSettingsResponse? LdapsSettings;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Notification Settings
        /// </summary>
        public readonly Outputs.NotificationSettingsResponse? NotificationSettings;
        /// <summary>
        /// the current deployment or provisioning state, which only appears in the response.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Status of Domain Service instance
        /// </summary>
        public readonly string ServiceStatus;
        /// <summary>
        /// The name of the virtual network that Domain Services will be deployed on. The id of the subnet that Domain Services will be deployed on. /virtualNetwork/vnetName/subnets/subnetName.
        /// </summary>
        public readonly string? SubnetId;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Azure Active Directory tenant id
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Virtual network site id
        /// </summary>
        public readonly string VnetSiteId;

        [OutputConstructor]
        private GetDomainServiceResult(
            string deploymentId,

            ImmutableArray<string> domainControllerIpAddress,

            string? domainName,

            Outputs.DomainSecuritySettingsResponse? domainSecuritySettings,

            string? etag,

            string? filteredSync,

            ImmutableArray<Outputs.HealthAlertResponse> healthAlerts,

            string healthLastEvaluated,

            ImmutableArray<Outputs.HealthMonitorResponse> healthMonitors,

            Outputs.LdapsSettingsResponse? ldapsSettings,

            string? location,

            string name,

            Outputs.NotificationSettingsResponse? notificationSettings,

            string provisioningState,

            string serviceStatus,

            string? subnetId,

            ImmutableDictionary<string, string>? tags,

            string tenantId,

            string type,

            string vnetSiteId)
        {
            DeploymentId = deploymentId;
            DomainControllerIpAddress = domainControllerIpAddress;
            DomainName = domainName;
            DomainSecuritySettings = domainSecuritySettings;
            Etag = etag;
            FilteredSync = filteredSync;
            HealthAlerts = healthAlerts;
            HealthLastEvaluated = healthLastEvaluated;
            HealthMonitors = healthMonitors;
            LdapsSettings = ldapsSettings;
            Location = location;
            Name = name;
            NotificationSettings = notificationSettings;
            ProvisioningState = provisioningState;
            ServiceStatus = serviceStatus;
            SubnetId = subnetId;
            Tags = tags;
            TenantId = tenantId;
            Type = type;
            VnetSiteId = vnetSiteId;
        }
    }
}
