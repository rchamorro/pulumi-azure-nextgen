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
    /// Cosmos DB indexing policy
    /// </summary>
    public sealed class IndexingPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Indicates if the indexing policy is automatic
        /// </summary>
        [Input("automatic")]
        public Input<bool>? Automatic { get; set; }

        [Input("compositeIndexes")]
        private InputList<ImmutableArray<Inputs.CompositePathArgs>>? _compositeIndexes;

        /// <summary>
        /// List of composite path list
        /// </summary>
        public InputList<ImmutableArray<Inputs.CompositePathArgs>> CompositeIndexes
        {
            get => _compositeIndexes ?? (_compositeIndexes = new InputList<ImmutableArray<Inputs.CompositePathArgs>>());
            set => _compositeIndexes = value;
        }

        [Input("excludedPaths")]
        private InputList<Inputs.ExcludedPathArgs>? _excludedPaths;

        /// <summary>
        /// List of paths to exclude from indexing
        /// </summary>
        public InputList<Inputs.ExcludedPathArgs> ExcludedPaths
        {
            get => _excludedPaths ?? (_excludedPaths = new InputList<Inputs.ExcludedPathArgs>());
            set => _excludedPaths = value;
        }

        [Input("includedPaths")]
        private InputList<Inputs.IncludedPathArgs>? _includedPaths;

        /// <summary>
        /// List of paths to include in the indexing
        /// </summary>
        public InputList<Inputs.IncludedPathArgs> IncludedPaths
        {
            get => _includedPaths ?? (_includedPaths = new InputList<Inputs.IncludedPathArgs>());
            set => _includedPaths = value;
        }

        /// <summary>
        /// Indicates the indexing mode.
        /// </summary>
        [Input("indexingMode")]
        public InputUnion<string, Pulumi.AzureNextGen.DocumentDB.V20200401.IndexingMode>? IndexingMode { get; set; }

        [Input("spatialIndexes")]
        private InputList<Inputs.SpatialSpecArgs>? _spatialIndexes;

        /// <summary>
        /// List of spatial specifics
        /// </summary>
        public InputList<Inputs.SpatialSpecArgs> SpatialIndexes
        {
            get => _spatialIndexes ?? (_spatialIndexes = new InputList<Inputs.SpatialSpecArgs>());
            set => _spatialIndexes = value;
        }

        public IndexingPolicyArgs()
        {
            IndexingMode = "Consistent";
        }
    }
}
