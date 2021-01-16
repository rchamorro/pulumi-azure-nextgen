// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// Trusted Root certificates properties for tls.
    /// </summary>
    public sealed class FirewallPolicyCertificateAuthorityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Secret Id of (base-64 encoded unencrypted pfx) 'Secret' or 'Certificate' object stored in KeyVault.
        /// </summary>
        [Input("keyVaultSecretId")]
        public Input<string>? KeyVaultSecretId { get; set; }

        /// <summary>
        /// Name of the CA certificate.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public FirewallPolicyCertificateAuthorityArgs()
        {
        }
    }
}
