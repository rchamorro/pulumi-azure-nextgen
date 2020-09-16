// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180601Preview.Outputs
{

    [OutputType]
    public sealed class TrackPropertyConditionResponse
    {
        /// <summary>
        /// Track property condition operation
        /// </summary>
        public readonly string Operation;
        /// <summary>
        /// Track property type
        /// </summary>
        public readonly string Property;
        /// <summary>
        /// Track property value
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private TrackPropertyConditionResponse(
            string operation,

            string property,

            string? value)
        {
            Operation = operation;
            Property = property;
            Value = value;
        }
    }
}