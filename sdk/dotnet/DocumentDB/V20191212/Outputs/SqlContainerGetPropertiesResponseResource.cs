// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20191212.Outputs
{

    [OutputType]
    public sealed class SqlContainerGetPropertiesResponseResource
    {
        /// <summary>
        /// The conflict resolution policy for the container.
        /// </summary>
        public readonly Outputs.ConflictResolutionPolicyResponse? ConflictResolutionPolicy;
        /// <summary>
        /// Default time to live
        /// </summary>
        public readonly int? DefaultTtl;
        /// <summary>
        /// A system generated property representing the resource etag required for optimistic concurrency control.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Name of the Cosmos DB SQL container
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The configuration of the indexing policy. By default, the indexing is automatic for all document paths within the container
        /// </summary>
        public readonly Outputs.IndexingPolicyResponse? IndexingPolicy;
        /// <summary>
        /// The configuration of the partition key to be used for partitioning data into multiple partitions
        /// </summary>
        public readonly Outputs.ContainerPartitionKeyResponse? PartitionKey;
        /// <summary>
        /// A system generated property. A unique identifier.
        /// </summary>
        public readonly string Rid;
        /// <summary>
        /// A system generated property that denotes the last updated timestamp of the resource.
        /// </summary>
        public readonly object Ts;
        /// <summary>
        /// The unique key policy configuration for specifying uniqueness constraints on documents in the collection in the Azure Cosmos DB service.
        /// </summary>
        public readonly Outputs.UniqueKeyPolicyResponse? UniqueKeyPolicy;

        [OutputConstructor]
        private SqlContainerGetPropertiesResponseResource(
            Outputs.ConflictResolutionPolicyResponse? conflictResolutionPolicy,

            int? defaultTtl,

            string etag,

            string id,

            Outputs.IndexingPolicyResponse? indexingPolicy,

            Outputs.ContainerPartitionKeyResponse? partitionKey,

            string rid,

            object ts,

            Outputs.UniqueKeyPolicyResponse? uniqueKeyPolicy)
        {
            ConflictResolutionPolicy = conflictResolutionPolicy;
            DefaultTtl = defaultTtl;
            Etag = etag;
            Id = id;
            IndexingPolicy = indexingPolicy;
            PartitionKey = partitionKey;
            Rid = rid;
            Ts = ts;
            UniqueKeyPolicy = uniqueKeyPolicy;
        }
    }
}
