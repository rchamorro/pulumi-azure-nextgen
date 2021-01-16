// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class NatGatewaySkuResponse
    {
        /// <summary>
        /// Name of Nat Gateway SKU.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private NatGatewaySkuResponse(string? name)
        {
            Name = name;
        }
    }
}
