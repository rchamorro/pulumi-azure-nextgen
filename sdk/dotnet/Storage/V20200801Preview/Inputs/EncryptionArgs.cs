// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Storage.V20200801Preview.Inputs
{

    /// <summary>
    /// The encryption settings on the storage account.
    /// </summary>
    public sealed class EncryptionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage, Microsoft.Keyvault
        /// </summary>
        [Input("keySource", required: true)]
        public InputUnion<string, Pulumi.AzureNextGen.Storage.V20200801Preview.KeySource> KeySource { get; set; } = null!;

        /// <summary>
        /// Properties provided by key vault.
        /// </summary>
        [Input("keyVaultProperties")]
        public Input<Inputs.KeyVaultPropertiesArgs>? KeyVaultProperties { get; set; }

        /// <summary>
        /// A boolean indicating whether or not the service applies a secondary layer of encryption with platform managed keys for data at rest.
        /// </summary>
        [Input("requireInfrastructureEncryption")]
        public Input<bool>? RequireInfrastructureEncryption { get; set; }

        /// <summary>
        /// List of services which support encryption.
        /// </summary>
        [Input("services")]
        public Input<Inputs.EncryptionServicesArgs>? Services { get; set; }

        public EncryptionArgs()
        {
            KeySource = "Microsoft.Storage";
        }
    }
}
