// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201001.Inputs
{

    /// <summary>
    /// Mab container-specific backup policy.
    /// </summary>
    public sealed class MabProtectionPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// Expected value is 'MAB'.
        /// </summary>
        [Input("backupManagementType", required: true)]
        public Input<string> BackupManagementType { get; set; } = null!;

        /// <summary>
        /// Number of items associated with this policy.
        /// </summary>
        [Input("protectedItemsCount")]
        public Input<int>? ProtectedItemsCount { get; set; }

        /// <summary>
        /// Retention policy details.
        /// </summary>
        [Input("retentionPolicy")]
        public InputUnion<Inputs.LongTermRetentionPolicyArgs, Inputs.SimpleRetentionPolicyArgs>? RetentionPolicy { get; set; }

        /// <summary>
        /// Backup schedule of backup policy.
        /// </summary>
        [Input("schedulePolicy")]
        public Input<object>? SchedulePolicy { get; set; }

        public MabProtectionPolicyArgs()
        {
        }
    }
}
