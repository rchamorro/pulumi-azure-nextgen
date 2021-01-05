// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20180710.Outputs
{

    [OutputType]
    public sealed class PolicyPropertiesResponse
    {
        /// <summary>
        /// The FriendlyName.
        /// </summary>
        public readonly string? FriendlyName;
        /// <summary>
        /// The ReplicationChannelSetting.
        /// </summary>
        public readonly object? ProviderSpecificDetails;

        [OutputConstructor]
        private PolicyPropertiesResponse(
            string? friendlyName,

            object? providerSpecificDetails)
        {
            FriendlyName = friendlyName;
            ProviderSpecificDetails = providerSpecificDetails;
        }
    }
}
