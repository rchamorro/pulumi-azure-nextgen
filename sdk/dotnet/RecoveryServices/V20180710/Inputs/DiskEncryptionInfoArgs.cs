// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Inputs
{

    /// <summary>
    /// Recovery disk encryption info (BEK and KEK).
    /// </summary>
    public sealed class DiskEncryptionInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The recovery KeyVault reference for secret.
        /// </summary>
        [Input("diskEncryptionKeyInfo")]
        public Input<Inputs.DiskEncryptionKeyInfoArgs>? DiskEncryptionKeyInfo { get; set; }

        /// <summary>
        /// The recovery KeyVault reference for key.
        /// </summary>
        [Input("keyEncryptionKeyInfo")]
        public Input<Inputs.KeyEncryptionKeyInfoArgs>? KeyEncryptionKeyInfo { get; set; }

        public DiskEncryptionInfoArgs()
        {
        }
    }
}