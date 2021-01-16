// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901.Outputs
{

    [OutputType]
    public sealed class SystemDataResponse
    {
        /// <summary>
        /// The timestamp of resource creation (UTC).
        /// </summary>
        public readonly string? CreatedAt;
        /// <summary>
        /// The identity that created the resource.
        /// </summary>
        public readonly string? CreatedBy;
        /// <summary>
        /// The type of identity that created the resource.
        /// </summary>
        public readonly string? CreatedByType;
        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedAt;
        /// <summary>
        /// The identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedBy;
        /// <summary>
        /// The type of identity that last modified the resource.
        /// </summary>
        public readonly string? LastModifiedByType;

        [OutputConstructor]
        private SystemDataResponse(
            string? createdAt,

            string? createdBy,

            string? createdByType,

            string? lastModifiedAt,

            string? lastModifiedBy,

            string? lastModifiedByType)
        {
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            CreatedByType = createdByType;
            LastModifiedAt = lastModifiedAt;
            LastModifiedBy = lastModifiedBy;
            LastModifiedByType = lastModifiedByType;
        }
    }
}
