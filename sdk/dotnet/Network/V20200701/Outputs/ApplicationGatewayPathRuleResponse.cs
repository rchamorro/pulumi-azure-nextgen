// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayPathRuleResponse
    {
        /// <summary>
        /// Backend address pool resource of URL path map path rule.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BackendAddressPool;
        /// <summary>
        /// Backend http settings resource of URL path map path rule.
        /// </summary>
        public readonly Outputs.SubResourceResponse? BackendHttpSettings;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Reference to the FirewallPolicy resource.
        /// </summary>
        public readonly Outputs.SubResourceResponse? FirewallPolicy;
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of the path rule that is unique within an Application Gateway.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Path rules of URL path map.
        /// </summary>
        public readonly ImmutableArray<string> Paths;
        /// <summary>
        /// The provisioning state of the path rule resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Redirect configuration resource of URL path map path rule.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RedirectConfiguration;
        /// <summary>
        /// Rewrite rule set resource of URL path map path rule.
        /// </summary>
        public readonly Outputs.SubResourceResponse? RewriteRuleSet;
        /// <summary>
        /// Type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ApplicationGatewayPathRuleResponse(
            Outputs.SubResourceResponse? backendAddressPool,

            Outputs.SubResourceResponse? backendHttpSettings,

            string etag,

            Outputs.SubResourceResponse? firewallPolicy,

            string? id,

            string? name,

            ImmutableArray<string> paths,

            string provisioningState,

            Outputs.SubResourceResponse? redirectConfiguration,

            Outputs.SubResourceResponse? rewriteRuleSet,

            string type)
        {
            BackendAddressPool = backendAddressPool;
            BackendHttpSettings = backendHttpSettings;
            Etag = etag;
            FirewallPolicy = firewallPolicy;
            Id = id;
            Name = name;
            Paths = paths;
            ProvisioningState = provisioningState;
            RedirectConfiguration = redirectConfiguration;
            RewriteRuleSet = rewriteRuleSet;
            Type = type;
        }
    }
}
