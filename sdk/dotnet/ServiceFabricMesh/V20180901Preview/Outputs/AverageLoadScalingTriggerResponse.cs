// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabricMesh.V20180901Preview.Outputs
{

    [OutputType]
    public sealed class AverageLoadScalingTriggerResponse
    {
        /// <summary>
        /// The type of auto scaling trigger
        /// </summary>
        public readonly string Kind;
        /// <summary>
        /// Lower load threshold (if average load is below this threshold, service will scale down).
        /// </summary>
        public readonly double LowerLoadThreshold;
        /// <summary>
        /// Description of the metric that is used for scaling.
        /// </summary>
        public readonly Outputs.AutoScalingResourceMetricResponse Metric;
        /// <summary>
        /// Scale interval that indicates how often will this trigger be checked.
        /// </summary>
        public readonly int ScaleIntervalInSeconds;
        /// <summary>
        /// Upper load threshold (if average load is above this threshold, service will scale up).
        /// </summary>
        public readonly double UpperLoadThreshold;

        [OutputConstructor]
        private AverageLoadScalingTriggerResponse(
            string kind,

            double lowerLoadThreshold,

            Outputs.AutoScalingResourceMetricResponse metric,

            int scaleIntervalInSeconds,

            double upperLoadThreshold)
        {
            Kind = kind;
            LowerLoadThreshold = lowerLoadThreshold;
            Metric = metric;
            ScaleIntervalInSeconds = scaleIntervalInSeconds;
            UpperLoadThreshold = upperLoadThreshold;
        }
    }
}