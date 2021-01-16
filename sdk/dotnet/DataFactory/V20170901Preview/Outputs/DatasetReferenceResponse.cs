// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class DatasetReferenceResponse
    {
        /// <summary>
        /// Arguments for dataset.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Parameters;
        /// <summary>
        /// Reference dataset name.
        /// </summary>
        public readonly string ReferenceName;
        /// <summary>
        /// Dataset reference type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DatasetReferenceResponse(
            ImmutableDictionary<string, object>? parameters,

            string referenceName,

            string type)
        {
            Parameters = parameters;
            ReferenceName = referenceName;
            Type = type;
        }
    }
}
