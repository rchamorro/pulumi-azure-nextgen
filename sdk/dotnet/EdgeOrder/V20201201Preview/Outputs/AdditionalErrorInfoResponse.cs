// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.EdgeOrder.V20201201Preview.Outputs
{

    [OutputType]
    public sealed class AdditionalErrorInfoResponse
    {
        public readonly object? Info;
        public readonly string? Type;

        [OutputConstructor]
        private AdditionalErrorInfoResponse(
            object? info,

            string? type)
        {
            Info = info;
            Type = type;
        }
    }
}
