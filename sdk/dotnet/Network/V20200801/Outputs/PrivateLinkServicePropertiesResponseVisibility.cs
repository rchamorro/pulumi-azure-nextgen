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
    public sealed class PrivateLinkServicePropertiesResponseVisibility
    {
        /// <summary>
        /// The list of subscriptions.
        /// </summary>
        public readonly ImmutableArray<string> Subscriptions;

        [OutputConstructor]
        private PrivateLinkServicePropertiesResponseVisibility(ImmutableArray<string> subscriptions)
        {
            Subscriptions = subscriptions;
        }
    }
}
