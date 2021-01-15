// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20190101.Inputs
{

    /// <summary>
    /// Properties controlling TLS Certificate Validation.
    /// </summary>
    public sealed class BackendTlsPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for this backend host.
        /// </summary>
        [Input("validateCertificateChain")]
        public Input<bool>? ValidateCertificateChain { get; set; }

        /// <summary>
        /// Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for this backend host.
        /// </summary>
        [Input("validateCertificateName")]
        public Input<bool>? ValidateCertificateName { get; set; }

        public BackendTlsPropertiesArgs()
        {
            ValidateCertificateChain = true;
            ValidateCertificateName = true;
        }
    }
}
