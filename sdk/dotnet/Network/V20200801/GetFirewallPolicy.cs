// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801
{
    public static class GetFirewallPolicy
    {
        public static Task<GetFirewallPolicyResult> InvokeAsync(GetFirewallPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFirewallPolicyResult>("azure-nextgen:network/v20200801:getFirewallPolicy", args ?? new GetFirewallPolicyArgs(), options.WithVersion());
    }


    public sealed class GetFirewallPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Expands referenced resources.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the Firewall Policy.
        /// </summary>
        [Input("firewallPolicyName", required: true)]
        public string FirewallPolicyName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetFirewallPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFirewallPolicyResult
    {
        /// <summary>
        /// The parent firewall policy from which rules are inherited.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BasePolicy;
        /// <summary>
        /// List of references to Child Firewall Policies.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> ChildPolicies;
        /// <summary>
        /// DNS Proxy Settings definition.
        /// </summary>
        public readonly Outputs.DnsSettingsResponse? DnsSettings;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// List of references to Azure Firewalls that this Firewall Policy is associated with.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> Firewalls;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// The identity of the firewall policy.
        /// </summary>
        public readonly Outputs.ManagedServiceIdentityResponse? Identity;
        /// <summary>
        /// The configuration for Intrusion detection.
        /// </summary>
        public readonly Outputs.FirewallPolicyIntrusionDetectionResponse? IntrusionDetection;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the firewall policy resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// List of references to FirewallPolicyRuleCollectionGroups.
        /// </summary>
        public readonly ImmutableArray<Outputs.SubResourceResponse> RuleCollectionGroups;
        /// <summary>
        /// The Firewall Policy SKU.
        /// </summary>
        public readonly Outputs.FirewallPolicySkuResponse? Sku;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// The operation mode for Threat Intelligence.
        /// </summary>
        public readonly string? ThreatIntelMode;
        /// <summary>
        /// ThreatIntel Whitelist for Firewall Policy.
        /// </summary>
        public readonly Outputs.FirewallPolicyThreatIntelWhitelistResponse? ThreatIntelWhitelist;
        /// <summary>
        /// TLS Configuration definition.
        /// </summary>
        public readonly Outputs.FirewallPolicyTransportSecurityResponse? TransportSecurity;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetFirewallPolicyResult(
            Outputs.SubResourceResponse? basePolicy,

            ImmutableArray<Outputs.SubResourceResponse> childPolicies,

            Outputs.DnsSettingsResponse? dnsSettings,

            string etag,

            ImmutableArray<Outputs.SubResourceResponse> firewalls,

            string? id,

            Outputs.ManagedServiceIdentityResponse? identity,

            Outputs.FirewallPolicyIntrusionDetectionResponse? intrusionDetection,

            string? location,

            string name,

            string provisioningState,

            ImmutableArray<Outputs.SubResourceResponse> ruleCollectionGroups,

            Outputs.FirewallPolicySkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string? threatIntelMode,

            Outputs.FirewallPolicyThreatIntelWhitelistResponse? threatIntelWhitelist,

            Outputs.FirewallPolicyTransportSecurityResponse? transportSecurity,

            string type)
        {
            BasePolicy = basePolicy;
            ChildPolicies = childPolicies;
            DnsSettings = dnsSettings;
            Etag = etag;
            Firewalls = firewalls;
            Id = id;
            Identity = identity;
            IntrusionDetection = intrusionDetection;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            RuleCollectionGroups = ruleCollectionGroups;
            Sku = sku;
            Tags = tags;
            ThreatIntelMode = threatIntelMode;
            ThreatIntelWhitelist = threatIntelWhitelist;
            TransportSecurity = transportSecurity;
            Type = type;
        }
    }
}
