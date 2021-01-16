// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// Virtual Hub identifier.
    /// </summary>
    public sealed class VirtualHubIdArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource URI for the Virtual Hub where the ExpressRoute gateway is or will be deployed. The Virtual Hub resource and the ExpressRoute gateway resource reside in the same subscription.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        public VirtualHubIdArgs()
        {
        }
    }
}
