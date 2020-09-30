// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20190501.Outputs
{

    [OutputType]
    public sealed class BatchConfigurationPropertiesResponse
    {
        /// <summary>
        /// The name of the batch group.
        /// </summary>
        public readonly string BatchGroupName;
        /// <summary>
        /// The artifact changed time.
        /// </summary>
        public readonly string? ChangedTime;
        /// <summary>
        /// The artifact creation time.
        /// </summary>
        public readonly string? CreatedTime;
        public readonly object? Metadata;
        /// <summary>
        /// The batch release criteria.
        /// </summary>
        public readonly Outputs.BatchReleaseCriteriaResponse ReleaseCriteria;

        [OutputConstructor]
        private BatchConfigurationPropertiesResponse(
            string batchGroupName,

            string? changedTime,

            string? createdTime,

            object? metadata,

            Outputs.BatchReleaseCriteriaResponse releaseCriteria)
        {
            BatchGroupName = batchGroupName;
            ChangedTime = changedTime;
            CreatedTime = createdTime;
            Metadata = metadata;
            ReleaseCriteria = releaseCriteria;
        }
    }
}
