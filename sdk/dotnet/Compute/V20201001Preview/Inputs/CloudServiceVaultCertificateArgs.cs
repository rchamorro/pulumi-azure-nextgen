// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201001Preview.Inputs
{

    /// <summary>
    /// Describes a single certificate reference in a Key Vault, and where the certificate should reside on the role instance.
    /// </summary>
    public sealed class CloudServiceVaultCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This is the URL of a certificate that has been uploaded to Key Vault as a secret.
        /// </summary>
        [Input("certificateUrl")]
        public Input<string>? CertificateUrl { get; set; }

        public CloudServiceVaultCertificateArgs()
        {
        }
    }
}