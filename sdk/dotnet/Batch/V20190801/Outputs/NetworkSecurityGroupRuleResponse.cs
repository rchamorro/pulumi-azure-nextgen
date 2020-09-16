// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Batch.V20190801.Outputs
{

    [OutputType]
    public sealed class NetworkSecurityGroupRuleResponse
    {
        public readonly string Access;
        /// <summary>
        /// Priorities within a pool must be unique and are evaluated in order of priority. The lower the number the higher the priority. For example, rules could be specified with order numbers of 150, 250, and 350. The rule with the order number of 150 takes precedence over the rule that has an order of 250. Allowed priorities are 150 to 3500. If any reserved or duplicate values are provided the request fails with HTTP status code 400.
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// Valid values are a single IP address (i.e. 10.10.10.10), IP subnet (i.e. 192.168.1.0/24), default tag, or * (for all addresses).  If any other values are provided the request fails with HTTP status code 400.
        /// </summary>
        public readonly string SourceAddressPrefix;
        /// <summary>
        /// Valid values are '*' (for all ports 0 - 65535) or arrays of ports or port ranges (i.e. 100-200). The ports should in the range of 0 to 65535 and the port ranges or ports can't overlap. If any other values are provided the request fails with HTTP status code 400. Default value will be *.
        /// </summary>
        public readonly ImmutableArray<string> SourcePortRanges;

        [OutputConstructor]
        private NetworkSecurityGroupRuleResponse(
            string access,

            int priority,

            string sourceAddressPrefix,

            ImmutableArray<string> sourcePortRanges)
        {
            Access = access;
            Priority = priority;
            SourceAddressPrefix = sourceAddressPrefix;
            SourcePortRanges = sourcePortRanges;
        }
    }
}