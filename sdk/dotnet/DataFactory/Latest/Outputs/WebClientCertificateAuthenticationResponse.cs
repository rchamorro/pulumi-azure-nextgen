// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class WebClientCertificateAuthenticationResponse
    {
        /// <summary>
        /// Type of authentication used to connect to the web table source.
        /// </summary>
        public readonly string AuthenticationType;
        /// <summary>
        /// Password for the PFX file.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse> Password;
        /// <summary>
        /// Base64-encoded contents of a PFX file.
        /// </summary>
        public readonly Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse> Pfx;
        /// <summary>
        /// The URL of the web service endpoint, e.g. http://www.microsoft.com . Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object Url;

        [OutputConstructor]
        private WebClientCertificateAuthenticationResponse(
            string authenticationType,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse> password,

            Union<Outputs.AzureKeyVaultSecretReferenceResponse, Outputs.SecureStringResponse> pfx,

            object url)
        {
            AuthenticationType = authenticationType;
            Password = password;
            Pfx = pfx;
            Url = url;
        }
    }
}
