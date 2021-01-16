// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201.Outputs
{

    [OutputType]
    public sealed class AzureIaaSVMProtectedItemExtendedInfoResponse
    {
        /// <summary>
        /// The oldest backup copy available for this backup item.
        /// </summary>
        public readonly string? OldestRecoveryPoint;
        /// <summary>
        /// Specifies if backup policy associated with the backup item is inconsistent.
        /// </summary>
        public readonly bool? PolicyInconsistent;
        /// <summary>
        /// Number of backup copies available for this backup item.
        /// </summary>
        public readonly int? RecoveryPointCount;

        [OutputConstructor]
        private AzureIaaSVMProtectedItemExtendedInfoResponse(
            string? oldestRecoveryPoint,

            bool? policyInconsistent,

            int? recoveryPointCount)
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            PolicyInconsistent = policyInconsistent;
            RecoveryPointCount = recoveryPointCount;
        }
    }
}
