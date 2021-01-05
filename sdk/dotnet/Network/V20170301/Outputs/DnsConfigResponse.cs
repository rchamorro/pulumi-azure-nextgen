// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170301.Outputs
{

    [OutputType]
    public sealed class DnsConfigResponse
    {
        /// <summary>
        /// Gets or sets the fully-qualified domain name (FQDN) of the Traffic Manager profile.  This is formed from the concatenation of the RelativeName with the DNS domain used by Azure Traffic Manager.
        /// </summary>
        public readonly string? Fqdn;
        /// <summary>
        /// Gets or sets the relative DNS name provided by this Traffic Manager profile.  This value is combined with the DNS domain name used by Azure Traffic Manager to form the fully-qualified domain name (FQDN) of the profile.
        /// </summary>
        public readonly string? RelativeName;
        /// <summary>
        /// Gets or sets the DNS Time-To-Live (TTL), in seconds.  This informs the local DNS resolvers and DNS clients how long to cache DNS responses provided by this Traffic Manager profile.
        /// </summary>
        public readonly double? Ttl;

        [OutputConstructor]
        private DnsConfigResponse(
            string? fqdn,

            string? relativeName,

            double? ttl)
        {
            Fqdn = fqdn;
            RelativeName = relativeName;
            Ttl = ttl;
        }
    }
}
