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
    public sealed class IpTagResponse
    {
        /// <summary>
        /// The IP tag type. Example: FirstPartyUsage.
        /// </summary>
        public readonly string? IpTagType;
        /// <summary>
        /// The value of the IP tag associated with the public IP. Example: SQL.
        /// </summary>
        public readonly string? Tag;

        [OutputConstructor]
        private IpTagResponse(
            string? ipTagType,

            string? tag)
        {
            IpTagType = ipTagType;
            Tag = tag;
        }
    }
}
