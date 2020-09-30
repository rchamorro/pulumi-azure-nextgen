// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class LinkedServiceReferenceResponse
    {
        /// <summary>
        /// Arguments for LinkedService.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Parameters;
        /// <summary>
        /// Reference LinkedService name.
        /// </summary>
        public readonly string ReferenceName;
        /// <summary>
        /// Linked service reference type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private LinkedServiceReferenceResponse(
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
