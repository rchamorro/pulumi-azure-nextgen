// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20160810.Outputs
{

    [OutputType]
    public sealed class DiskDetailsResponse
    {
        /// <summary>
        /// The hard disk max size in MB.
        /// </summary>
        public readonly double? MaxSizeMB;
        /// <summary>
        /// The VHD Id.
        /// </summary>
        public readonly string? VhdId;
        /// <summary>
        /// The VHD name.
        /// </summary>
        public readonly string? VhdName;
        /// <summary>
        /// The type of the volume.
        /// </summary>
        public readonly string? VhdType;

        [OutputConstructor]
        private DiskDetailsResponse(
            double? maxSizeMB,

            string? vhdId,

            string? vhdName,

            string? vhdType)
        {
            MaxSizeMB = maxSizeMB;
            VhdId = vhdId;
            VhdName = vhdName;
            VhdType = vhdType;
        }
    }
}
