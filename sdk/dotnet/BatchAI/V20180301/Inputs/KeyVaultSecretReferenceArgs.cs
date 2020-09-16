// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.BatchAI.V20180301.Inputs
{

    /// <summary>
    /// Describes a reference to Key Vault Secret.
    /// </summary>
    public sealed class KeyVaultSecretReferenceArgs : Pulumi.ResourceArgs
    {
        [Input("secretUrl", required: true)]
        public Input<string> SecretUrl { get; set; } = null!;

        /// <summary>
        /// Represents a resource ID. For example, for a subnet, it is the resource URL for the subnet.
        /// </summary>
        [Input("sourceVault", required: true)]
        public Input<Inputs.ResourceIdArgs> SourceVault { get; set; } = null!;

        public KeyVaultSecretReferenceArgs()
        {
        }
    }
}