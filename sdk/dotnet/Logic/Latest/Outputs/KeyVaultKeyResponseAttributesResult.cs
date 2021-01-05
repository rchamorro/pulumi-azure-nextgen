// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.Latest.Outputs
{

    [OutputType]
    public sealed class KeyVaultKeyResponseAttributesResult
    {
        /// <summary>
        /// When the key was created.
        /// </summary>
        public readonly double? Created;
        /// <summary>
        /// Whether the key is enabled or not.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// When the key was updated.
        /// </summary>
        public readonly double? Updated;

        [OutputConstructor]
        private KeyVaultKeyResponseAttributesResult(
            double? created,

            bool? enabled,

            double? updated)
        {
            Created = created;
            Enabled = enabled;
            Updated = updated;
        }
    }
}
