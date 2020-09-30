// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20160601.Outputs
{

    [OutputType]
    public sealed class WorkflowParameterResponse
    {
        /// <summary>
        /// The description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The type.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The value.
        /// </summary>
        public readonly object? Value;

        [OutputConstructor]
        private WorkflowParameterResponse(
            string? description,

            object? metadata,

            string? type,

            object? value)
        {
            Description = description;
            Metadata = metadata;
            Type = type;
            Value = value;
        }
    }
}
