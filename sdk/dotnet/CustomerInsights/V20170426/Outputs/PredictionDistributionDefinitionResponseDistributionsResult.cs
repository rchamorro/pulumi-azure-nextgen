// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426.Outputs
{

    [OutputType]
    public sealed class PredictionDistributionDefinitionResponseDistributionsResult
    {
        /// <summary>
        /// Number of negatives.
        /// </summary>
        public readonly double? Negatives;
        /// <summary>
        /// Number of negatives above threshold.
        /// </summary>
        public readonly double? NegativesAboveThreshold;
        /// <summary>
        /// Number of positives.
        /// </summary>
        public readonly double? Positives;
        /// <summary>
        /// Number of positives above threshold.
        /// </summary>
        public readonly double? PositivesAboveThreshold;
        /// <summary>
        /// Score threshold.
        /// </summary>
        public readonly int? ScoreThreshold;

        [OutputConstructor]
        private PredictionDistributionDefinitionResponseDistributionsResult(
            double? negatives,

            double? negativesAboveThreshold,

            double? positives,

            double? positivesAboveThreshold,

            int? scoreThreshold)
        {
            Negatives = negatives;
            NegativesAboveThreshold = negativesAboveThreshold;
            Positives = positives;
            PositivesAboveThreshold = positivesAboveThreshold;
            ScoreThreshold = scoreThreshold;
        }
    }
}
