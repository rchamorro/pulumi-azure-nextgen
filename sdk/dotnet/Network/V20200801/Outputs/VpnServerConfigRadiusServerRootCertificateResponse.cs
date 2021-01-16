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
    public sealed class VpnServerConfigRadiusServerRootCertificateResponse
    {
        /// <summary>
        /// The certificate name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The certificate public data.
        /// </summary>
        public readonly string? PublicCertData;

        [OutputConstructor]
        private VpnServerConfigRadiusServerRootCertificateResponse(
            string? name,

            string? publicCertData)
        {
            Name = name;
            PublicCertData = publicCertData;
        }
    }
}
