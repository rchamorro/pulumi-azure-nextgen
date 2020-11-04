// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class TrafficSelectorPolicyResponse
    {
        /// <summary>
        /// A collection of local address spaces in CIDR format.
        /// </summary>
        public readonly ImmutableArray<string> LocalAddressRanges;
        /// <summary>
        /// A collection of remote address spaces in CIDR format.
        /// </summary>
        public readonly ImmutableArray<string> RemoteAddressRanges;

        [OutputConstructor]
        private TrafficSelectorPolicyResponse(
            ImmutableArray<string> localAddressRanges,

            ImmutableArray<string> remoteAddressRanges)
        {
            LocalAddressRanges = localAddressRanges;
            RemoteAddressRanges = remoteAddressRanges;
        }
    }
}
