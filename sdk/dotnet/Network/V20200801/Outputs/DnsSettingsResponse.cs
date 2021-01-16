// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class DnsSettingsResponse
    {
        /// <summary>
        /// Enable DNS Proxy on Firewalls attached to the Firewall Policy.
        /// </summary>
        public readonly bool? EnableProxy;
        /// <summary>
        /// FQDNs in Network Rules are supported when set to true.
        /// </summary>
        public readonly bool? RequireProxyForNetworkRules;
        /// <summary>
        /// List of Custom DNS Servers.
        /// </summary>
        public readonly ImmutableArray<string> Servers;

        [OutputConstructor]
        private DnsSettingsResponse(
            bool? enableProxy,

            bool? requireProxyForNetworkRules,

            ImmutableArray<string> servers)
        {
            EnableProxy = enableProxy;
            RequireProxyForNetworkRules = requireProxyForNetworkRules;
            Servers = servers;
        }
    }
}
