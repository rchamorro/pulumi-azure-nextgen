// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20200601.Outputs
{

    [OutputType]
    public sealed class AutomaticRepairsPolicyResponse
    {
        /// <summary>
        /// Specifies whether automatic repairs should be enabled on the virtual machine scale set. The default value is false.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// The amount of time for which automatic repairs are suspended due to a state change on VM. The grace time starts after the state change has completed. This helps avoid premature or accidental repairs. The time duration should be specified in ISO 8601 format. The minimum allowed grace period is 30 minutes (PT30M), which is also the default value. The maximum allowed grace period is 90 minutes (PT90M).
        /// </summary>
        public readonly string? GracePeriod;

        [OutputConstructor]
        private AutomaticRepairsPolicyResponse(
            bool? enabled,

            string? gracePeriod)
        {
            Enabled = enabled;
            GracePeriod = gracePeriod;
        }
    }
}