// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20201101.Outputs
{

    [OutputType]
    public sealed class RoutingRuleLinkResponse
    {
        /// <summary>
        /// Resource ID.
        /// </summary>
        public readonly string? Id;

        [OutputConstructor]
        private RoutingRuleLinkResponse(string? id)
        {
            Id = id;
        }
    }
}
