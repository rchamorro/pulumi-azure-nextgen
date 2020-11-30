// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.Latest.Inputs
{

    /// <summary>
    /// Azure VM (Mercury) workload-specific backup policy.
    /// </summary>
    public sealed class AzureVmWorkloadProtectionPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Input("backupManagementType", required: true)]
        public Input<string> BackupManagementType { get; set; } = null!;

        /// <summary>
        /// Fix the policy inconsistency
        /// </summary>
        [Input("makePolicyConsistent")]
        public Input<bool>? MakePolicyConsistent { get; set; }

        /// <summary>
        /// Number of items associated with this policy.
        /// </summary>
        [Input("protectedItemsCount")]
        public Input<int>? ProtectedItemsCount { get; set; }

        /// <summary>
        /// Common settings for the backup management
        /// </summary>
        [Input("settings")]
        public Input<Inputs.SettingsArgs>? Settings { get; set; }

        [Input("subProtectionPolicy")]
        private InputList<Inputs.SubProtectionPolicyArgs>? _subProtectionPolicy;

        /// <summary>
        /// List of sub-protection policies which includes schedule and retention
        /// </summary>
        public InputList<Inputs.SubProtectionPolicyArgs> SubProtectionPolicy
        {
            get => _subProtectionPolicy ?? (_subProtectionPolicy = new InputList<Inputs.SubProtectionPolicyArgs>());
            set => _subProtectionPolicy = value;
        }

        /// <summary>
        /// Type of workload for the backup management
        /// </summary>
        [Input("workLoadType")]
        public Input<string>? WorkLoadType { get; set; }

        public AzureVmWorkloadProtectionPolicyArgs()
        {
        }
    }
}