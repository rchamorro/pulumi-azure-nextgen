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
    public sealed class ApplicationGatewaySslPolicyResponse
    {
        /// <summary>
        /// Ssl cipher suites to be enabled in the specified order to application gateway.
        /// </summary>
        public readonly ImmutableArray<string> CipherSuites;
        /// <summary>
        /// Ssl protocols to be disabled on application gateway.
        /// </summary>
        public readonly ImmutableArray<string> DisabledSslProtocols;
        /// <summary>
        /// Minimum version of Ssl protocol to be supported on application gateway.
        /// </summary>
        public readonly string? MinProtocolVersion;
        /// <summary>
        /// Name of Ssl predefined policy.
        /// </summary>
        public readonly string? PolicyName;
        /// <summary>
        /// Type of Ssl Policy.
        /// </summary>
        public readonly string? PolicyType;

        [OutputConstructor]
        private ApplicationGatewaySslPolicyResponse(
            ImmutableArray<string> cipherSuites,

            ImmutableArray<string> disabledSslProtocols,

            string? minProtocolVersion,

            string? policyName,

            string? policyType)
        {
            CipherSuites = cipherSuites;
            DisabledSslProtocols = disabledSslProtocols;
            MinProtocolVersion = minProtocolVersion;
            PolicyName = policyName;
            PolicyType = policyType;
        }
    }
}
