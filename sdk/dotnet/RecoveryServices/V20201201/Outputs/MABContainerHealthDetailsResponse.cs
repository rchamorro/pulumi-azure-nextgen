// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201.Outputs
{

    [OutputType]
    public sealed class MABContainerHealthDetailsResponse
    {
        /// <summary>
        /// Health Code
        /// </summary>
        public readonly int? Code;
        /// <summary>
        /// Health Message
        /// </summary>
        public readonly string? Message;
        /// <summary>
        /// Health Recommended Actions
        /// </summary>
        public readonly ImmutableArray<string> Recommendations;
        /// <summary>
        /// Health Title
        /// </summary>
        public readonly string? Title;

        [OutputConstructor]
        private MABContainerHealthDetailsResponse(
            int? code,

            string? message,

            ImmutableArray<string> recommendations,

            string? title)
        {
            Code = code;
            Message = message;
            Recommendations = recommendations;
            Title = title;
        }
    }
}
