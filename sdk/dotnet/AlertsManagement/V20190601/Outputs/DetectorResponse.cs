// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AlertsManagement.V20190601.Outputs
{

    [OutputType]
    public sealed class DetectorResponse
    {
        /// <summary>
        /// The Smart Detector description. By default this is not populated, unless it's specified in expandDetector
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The detector id.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The Smart Detector image path. By default this is not populated, unless it's specified in expandDetector
        /// </summary>
        public readonly ImmutableArray<string> ImagePaths;
        /// <summary>
        /// The Smart Detector name. By default this is not populated, unless it's specified in expandDetector
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The detector's parameters.'
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Parameters;
        /// <summary>
        /// The Smart Detector supported resource types. By default this is not populated, unless it's specified in expandDetector
        /// </summary>
        public readonly ImmutableArray<string> SupportedResourceTypes;

        [OutputConstructor]
        private DetectorResponse(
            string? description,

            string id,

            ImmutableArray<string> imagePaths,

            string? name,

            ImmutableDictionary<string, object>? parameters,

            ImmutableArray<string> supportedResourceTypes)
        {
            Description = description;
            Id = id;
            ImagePaths = imagePaths;
            Name = name;
            Parameters = parameters;
            SupportedResourceTypes = supportedResourceTypes;
        }
    }
}
