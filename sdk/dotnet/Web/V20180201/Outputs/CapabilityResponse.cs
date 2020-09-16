// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20180201.Outputs
{

    [OutputType]
    public sealed class CapabilityResponse
    {
        /// <summary>
        /// Name of the SKU capability.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Reason of the SKU capability.
        /// </summary>
        public readonly string? Reason;
        /// <summary>
        /// Value of the SKU capability.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private CapabilityResponse(
            string? name,

            string? reason,

            string? value)
        {
            Name = name;
            Reason = reason;
            Value = value;
        }
    }
}