// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.Latest.Outputs
{

    [OutputType]
    public sealed class ManagedClusterAutoUpgradeProfileResponse
    {
        /// <summary>
        /// upgrade channel for auto upgrade.
        /// </summary>
        public readonly string? UpgradeChannel;

        [OutputConstructor]
        private ManagedClusterAutoUpgradeProfileResponse(string? upgradeChannel)
        {
            UpgradeChannel = upgradeChannel;
        }
    }
}
