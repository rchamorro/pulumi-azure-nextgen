// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest
{
    public static class GetPolicy
    {
        public static Task<GetPolicyResult> InvokeAsync(GetPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicyResult>("azure-nextgen:network/latest:getPolicy", args ?? new GetPolicyArgs(), options.WithVersion());
    }


    public sealed class GetPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Web Application Firewall Policy.
        /// </summary>
        [Input("policyName", required: true)]
        public string PolicyName { get; set; } = null!;

        /// <summary>
        /// Name of the Resource group within the Azure subscription.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicyResult
    {
        /// <summary>
        /// Describes custom rules inside the policy.
        /// </summary>
        public readonly Outputs.CustomRuleListResponse? CustomRules;
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// Describes Frontend Endpoints associated with this Web Application Firewall policy.
        /// </summary>
        public readonly ImmutableArray<Outputs.FrontendEndpointLinkResponse> FrontendEndpointLinks;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Describes managed rules inside the policy.
        /// </summary>
        public readonly Outputs.ManagedRuleSetListResponse? ManagedRules;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Describes settings for the policy.
        /// </summary>
        public readonly Outputs.PolicySettingsResponse? PolicySettings;
        /// <summary>
        /// Provisioning state of the policy.
        /// </summary>
        public readonly string ProvisioningState;
        public readonly string ResourceState;
        /// <summary>
        /// Describes Routing Rules associated with this Web Application Firewall policy.
        /// </summary>
        public readonly ImmutableArray<Outputs.RoutingRuleLinkResponse> RoutingRuleLinks;
        /// <summary>
        /// Describes Security Policy associated with this Web Application Firewall policy.
        /// </summary>
        public readonly ImmutableArray<Outputs.SecurityPolicyLinkResponse> SecurityPolicyLinks;
        /// <summary>
        /// The pricing tier of web application firewall policy. Defaults to Classic_AzureFrontDoor if not specified.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPolicyResult(
            Outputs.CustomRuleListResponse? customRules,

            string? etag,

            ImmutableArray<Outputs.FrontendEndpointLinkResponse> frontendEndpointLinks,

            string id,

            string? location,

            Outputs.ManagedRuleSetListResponse? managedRules,

            string name,

            Outputs.PolicySettingsResponse? policySettings,

            string provisioningState,

            string resourceState,

            ImmutableArray<Outputs.RoutingRuleLinkResponse> routingRuleLinks,

            ImmutableArray<Outputs.SecurityPolicyLinkResponse> securityPolicyLinks,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CustomRules = customRules;
            Etag = etag;
            FrontendEndpointLinks = frontendEndpointLinks;
            Id = id;
            Location = location;
            ManagedRules = managedRules;
            Name = name;
            PolicySettings = policySettings;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            RoutingRuleLinks = routingRuleLinks;
            SecurityPolicyLinks = securityPolicyLinks;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
