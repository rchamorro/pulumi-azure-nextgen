// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.MachineLearningServices.V20200515Preview.Outputs
{

    [OutputType]
    public sealed class AKSVariantResponseResponse
    {
        /// <summary>
        /// The compute environment type for the service.
        /// Expected value is 'Custom'.
        /// </summary>
        public readonly string ComputeType;
        /// <summary>
        /// The deployment type for the service.
        /// </summary>
        public readonly string? DeploymentType;
        /// <summary>
        /// The service description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The error details.
        /// </summary>
        public readonly Outputs.ServiceResponseBaseResponseError Error;
        /// <summary>
        /// Is this the default variant.
        /// </summary>
        public readonly bool? IsDefault;
        /// <summary>
        /// The service tag dictionary. Tags are mutable.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? KvTags;
        /// <summary>
        /// The service property dictionary. Properties are immutable.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Properties;
        /// <summary>
        /// The current state of the service.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// The amount of traffic variant receives.
        /// </summary>
        public readonly double? TrafficPercentile;
        /// <summary>
        /// The type of the variant.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private AKSVariantResponseResponse(
            string computeType,

            string? deploymentType,

            string? description,

            Outputs.ServiceResponseBaseResponseError error,

            bool? isDefault,

            ImmutableDictionary<string, string>? kvTags,

            ImmutableDictionary<string, string>? properties,

            string state,

            double? trafficPercentile,

            string? type)
        {
            ComputeType = computeType;
            DeploymentType = deploymentType;
            Description = description;
            Error = error;
            IsDefault = isDefault;
            KvTags = kvTags;
            Properties = properties;
            State = state;
            TrafficPercentile = trafficPercentile;
            Type = type;
        }
    }
}
