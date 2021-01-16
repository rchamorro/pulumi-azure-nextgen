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
    public sealed class AadAuthenticationParametersResponse
    {
        /// <summary>
        /// AAD Vpn authentication parameter AAD audience.
        /// </summary>
        public readonly string? AadAudience;
        /// <summary>
        /// AAD Vpn authentication parameter AAD issuer.
        /// </summary>
        public readonly string? AadIssuer;
        /// <summary>
        /// AAD Vpn authentication parameter AAD tenant.
        /// </summary>
        public readonly string? AadTenant;

        [OutputConstructor]
        private AadAuthenticationParametersResponse(
            string? aadAudience,

            string? aadIssuer,

            string? aadTenant)
        {
            AadAudience = aadAudience;
            AadIssuer = aadIssuer;
            AadTenant = aadTenant;
        }
    }
}
