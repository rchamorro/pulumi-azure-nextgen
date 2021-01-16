// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901.Outputs
{

    [OutputType]
    public sealed class AsymmetricEncryptedSecretResponse
    {
        /// <summary>
        /// The algorithm used to encrypt "Value".
        /// </summary>
        public readonly string EncryptionAlgorithm;
        /// <summary>
        /// Thumbprint certificate used to encrypt \"Value\". If the value is unencrypted, it will be null.
        /// </summary>
        public readonly string? EncryptionCertThumbprint;
        /// <summary>
        /// The value of the secret.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private AsymmetricEncryptedSecretResponse(
            string encryptionAlgorithm,

            string? encryptionCertThumbprint,

            string value)
        {
            EncryptionAlgorithm = encryptionAlgorithm;
            EncryptionCertThumbprint = encryptionCertThumbprint;
            Value = value;
        }
    }
}
