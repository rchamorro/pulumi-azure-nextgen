// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20200401.Inputs
{

    /// <summary>
    /// Cosmos DB SQL container resource object
    /// </summary>
    public sealed class SqlContainerResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Analytical TTL.
        /// </summary>
        [Input("analyticalStorageTtl")]
        public Input<double>? AnalyticalStorageTtl { get; set; }

        /// <summary>
        /// The conflict resolution policy for the container.
        /// </summary>
        [Input("conflictResolutionPolicy")]
        public Input<Inputs.ConflictResolutionPolicyArgs>? ConflictResolutionPolicy { get; set; }

        /// <summary>
        /// Default time to live
        /// </summary>
        [Input("defaultTtl")]
        public Input<int>? DefaultTtl { get; set; }

        /// <summary>
        /// Name of the Cosmos DB SQL container
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container
        /// </summary>
        [Input("indexingPolicy")]
        public Input<Inputs.IndexingPolicyArgs>? IndexingPolicy { get; set; }

        /// <summary>
        /// The configuration of the partition key to be used for partitioning data into multiple partitions
        /// </summary>
        [Input("partitionKey")]
        public Input<Inputs.ContainerPartitionKeyArgs>? PartitionKey { get; set; }

        /// <summary>
        /// The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.
        /// </summary>
        [Input("uniqueKeyPolicy")]
        public Input<Inputs.UniqueKeyPolicyArgs>? UniqueKeyPolicy { get; set; }

        public SqlContainerResourceArgs()
        {
        }
    }
}
