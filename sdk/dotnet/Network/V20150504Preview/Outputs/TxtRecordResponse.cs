// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20150504Preview.Outputs
{

    [OutputType]
    public sealed class TxtRecordResponse
    {
        /// <summary>
        /// Gets or sets the text value of this record.
        /// </summary>
        public readonly ImmutableArray<string> Value;

        [OutputConstructor]
        private TxtRecordResponse(ImmutableArray<string> value)
        {
            Value = value;
        }
    }
}