// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class ContentKeyPolicyRsaTokenKeyResponse
    {
        /// <summary>
        /// The RSA Parameter exponent
        /// </summary>
        public readonly string Exponent;
        /// <summary>
        /// The RSA Parameter modulus
        /// </summary>
        public readonly string Modulus;
        /// <summary>
        /// The discriminator for derived types.
        /// Expected value is '#Microsoft.Media.ContentKeyPolicyRsaTokenKey'.
        /// </summary>
        public readonly string OdataType;

        [OutputConstructor]
        private ContentKeyPolicyRsaTokenKeyResponse(
            string exponent,

            string modulus,

            string odataType)
        {
            Exponent = exponent;
            Modulus = modulus;
            OdataType = odataType;
        }
    }
}
