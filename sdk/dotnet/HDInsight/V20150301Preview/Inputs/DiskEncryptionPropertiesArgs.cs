// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HDInsight.V20150301Preview.Inputs
{

    /// <summary>
    /// The disk encryption properties
    /// </summary>
    public sealed class DiskEncryptionPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Algorithm identifier for encryption, default RSA-OAEP.
        /// </summary>
        [Input("encryptionAlgorithm")]
        public InputUnion<string, Pulumi.AzureNextGen.HDInsight.V20150301Preview.JsonWebKeyEncryptionAlgorithm>? EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Indicates whether or not resource disk encryption is enabled.
        /// </summary>
        [Input("encryptionAtHost")]
        public Input<bool>? EncryptionAtHost { get; set; }

        /// <summary>
        /// Key name that is used for enabling disk encryption.
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        /// <summary>
        /// Specific key version that is used for enabling disk encryption.
        /// </summary>
        [Input("keyVersion")]
        public Input<string>? KeyVersion { get; set; }

        /// <summary>
        /// Resource ID of Managed Identity that is used to access the key vault.
        /// </summary>
        [Input("msiResourceId")]
        public Input<string>? MsiResourceId { get; set; }

        /// <summary>
        /// Base key vault URI where the customers key is located eg. https://myvault.vault.azure.net
        /// </summary>
        [Input("vaultUri")]
        public Input<string>? VaultUri { get; set; }

        public DiskEncryptionPropertiesArgs()
        {
            EncryptionAtHost = false;
        }
    }
}
