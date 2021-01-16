// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.Latest.Outputs
{

    [OutputType]
    public sealed class KeyForDiskEncryptionSetResponse
    {
        /// <summary>
        /// Fully versioned Key Url pointing to a key in KeyVault
        /// </summary>
        public readonly string KeyUrl;
        /// <summary>
        /// Resource id of the KeyVault containing the key or secret. This property is optional and cannot be used if the KeyVault subscription is not the same as the Disk Encryption Set subscription.
        /// </summary>
        public readonly Outputs.SourceVaultResponse? SourceVault;

        [OutputConstructor]
        private KeyForDiskEncryptionSetResponse(
            string keyUrl,

            Outputs.SourceVaultResponse? sourceVault)
        {
            KeyUrl = keyUrl;
            SourceVault = sourceVault;
        }
    }
}
