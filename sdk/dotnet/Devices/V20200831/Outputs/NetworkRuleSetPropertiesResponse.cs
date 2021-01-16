// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831.Outputs
{

    [OutputType]
    public sealed class NetworkRuleSetPropertiesResponse
    {
        /// <summary>
        /// If True, then Network Rule Set is also applied to BuiltIn EventHub EndPoint of IotHub
        /// </summary>
        public readonly bool ApplyToBuiltInEventHubEndpoint;
        /// <summary>
        /// Default Action for Network Rule Set
        /// </summary>
        public readonly string? DefaultAction;
        /// <summary>
        /// List of IP Rules
        /// </summary>
        public readonly ImmutableArray<Outputs.NetworkRuleSetIpRuleResponse> IpRules;

        [OutputConstructor]
        private NetworkRuleSetPropertiesResponse(
            bool applyToBuiltInEventHubEndpoint,

            string? defaultAction,

            ImmutableArray<Outputs.NetworkRuleSetIpRuleResponse> ipRules)
        {
            ApplyToBuiltInEventHubEndpoint = applyToBuiltInEventHubEndpoint;
            DefaultAction = defaultAction;
            IpRules = ipRules;
        }
    }
}
