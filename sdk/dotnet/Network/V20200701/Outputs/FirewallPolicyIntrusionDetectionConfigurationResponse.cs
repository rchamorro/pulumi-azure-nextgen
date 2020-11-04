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
    public sealed class FirewallPolicyIntrusionDetectionConfigurationResponse
    {
        /// <summary>
        /// List of rules for traffic to bypass.
        /// </summary>
        public readonly ImmutableArray<Outputs.FirewallPolicyIntrusionDetectionBypassTrafficSpecificationsResponse> BypassTrafficSettings;
        /// <summary>
        /// List of specific signatures states.
        /// </summary>
        public readonly ImmutableArray<Outputs.FirewallPolicyIntrusionDetectionSignatureSpecificationResponse> SignatureOverrides;

        [OutputConstructor]
        private FirewallPolicyIntrusionDetectionConfigurationResponse(
            ImmutableArray<Outputs.FirewallPolicyIntrusionDetectionBypassTrafficSpecificationsResponse> bypassTrafficSettings,

            ImmutableArray<Outputs.FirewallPolicyIntrusionDetectionSignatureSpecificationResponse> signatureOverrides)
        {
            BypassTrafficSettings = bypassTrafficSettings;
            SignatureOverrides = signatureOverrides;
        }
    }
}
