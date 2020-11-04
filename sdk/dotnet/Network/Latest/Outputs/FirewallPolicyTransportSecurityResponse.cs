// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest.Outputs
{

    [OutputType]
    public sealed class FirewallPolicyTransportSecurityResponse
    {
        /// <summary>
        /// The CA used for intermediate CA generation.
        /// </summary>
        public readonly Outputs.FirewallPolicyCertificateAuthorityResponse? CertificateAuthority;

        [OutputConstructor]
        private FirewallPolicyTransportSecurityResponse(Outputs.FirewallPolicyCertificateAuthorityResponse? certificateAuthority)
        {
            CertificateAuthority = certificateAuthority;
        }
    }
}
