// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DocumentDB.V20151106.Inputs
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
        public InputUnion<string, Pulumi.AzureNextGen.DocumentDB.V20151106.IndexingMode>? IndexingMode { get; set; }

        public IndexingPolicyArgs()
        {
            IndexingMode = "Consistent";
        }
    }
}
