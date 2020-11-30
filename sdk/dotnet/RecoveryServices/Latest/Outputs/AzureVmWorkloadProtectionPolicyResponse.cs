// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.Latest.Outputs
{

    [OutputType]
    public sealed class AzureVmWorkloadProtectionPolicyResponse
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        public readonly string BackupManagementType;
        /// <summary>
        /// Fix the policy inconsistency
        /// </summary>
        public readonly bool? MakePolicyConsistent;
        /// <summary>
        /// Number of items associated with this policy.
        /// </summary>
        public readonly int? ProtectedItemsCount;
        /// <summary>
        /// Common settings for the backup management
        /// </summary>
        public readonly Outputs.SettingsResponse? Settings;
        /// <summary>
        /// List of sub-protection policies which includes schedule and retention
        /// </summary>
        public readonly ImmutableArray<Outputs.SubProtectionPolicyResponse> SubProtectionPolicy;
        /// <summary>
        /// Type of workload for the backup management
        /// </summary>
        public readonly string? WorkLoadType;

        [OutputConstructor]
        private AzureVmWorkloadProtectionPolicyResponse(
            string backupManagementType,

            bool? makePolicyConsistent,

            int? protectedItemsCount,

            Outputs.SettingsResponse? settings,

            ImmutableArray<Outputs.SubProtectionPolicyResponse> subProtectionPolicy,

            string? workLoadType)
        {
            BackupManagementType = backupManagementType;
            MakePolicyConsistent = makePolicyConsistent;
            ProtectedItemsCount = protectedItemsCount;
            Settings = settings;
            SubProtectionPolicy = subProtectionPolicy;
            WorkLoadType = workLoadType;
        }
    }
}