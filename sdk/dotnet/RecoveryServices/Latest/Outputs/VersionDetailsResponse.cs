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
    public sealed class VersionDetailsResponse
    {
        /// <summary>
        /// Version expiry date.
        /// </summary>
        public readonly string? ExpiryDate;
        /// <summary>
        /// A value indicating whether security update required.
        /// </summary>
        public readonly string? Status;
        /// <summary>
        /// The agent version.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private VersionDetailsResponse(
            string? expiryDate,

            string? status,

            string? version)
        {
            ExpiryDate = expiryDate;
            Status = status;
            Version = version;
        }
    }
}