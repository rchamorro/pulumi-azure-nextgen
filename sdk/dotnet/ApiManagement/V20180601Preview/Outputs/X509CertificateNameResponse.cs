// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class X509CertificateNameResponse
    {
        /// <summary>
        /// Thumbprint for the Issuer of the Certificate.
        /// </summary>
        public readonly string? IssuerCertificateThumbprint;
        /// <summary>
        /// Common Name of the Certificate.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private X509CertificateNameResponse(
            string? issuerCertificateThumbprint,

            string? name)
        {
            IssuerCertificateThumbprint = issuerCertificateThumbprint;
            Name = name;
        }
    }
}