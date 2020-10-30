// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20201101.Outputs
{

    [OutputType]
    public sealed class PreferencesResponse
    {
        /// <summary>
        /// Preferences related to the Encryption.
        /// </summary>
        public readonly Outputs.EncryptionPreferencesResponse? EncryptionPreferences;
        /// <summary>
        /// Preferred data center region.
        /// </summary>
        public readonly ImmutableArray<string> PreferredDataCenterRegion;
        /// <summary>
        /// Preferences related to the shipment logistics of the sku.
        /// </summary>
        public readonly Outputs.TransportPreferencesResponse? TransportPreferences;

        [OutputConstructor]
        private PreferencesResponse(
            Outputs.EncryptionPreferencesResponse? encryptionPreferences,

            ImmutableArray<string> preferredDataCenterRegion,

            Outputs.TransportPreferencesResponse? transportPreferences)
        {
            EncryptionPreferences = encryptionPreferences;
            PreferredDataCenterRegion = preferredDataCenterRegion;
            TransportPreferences = transportPreferences;
        }
    }
}