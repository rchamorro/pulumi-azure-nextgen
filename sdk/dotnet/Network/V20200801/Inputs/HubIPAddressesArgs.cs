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
    /// IP addresses associated with azure firewall.
    /// </summary>
    public sealed class HubIPAddressesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Private IP Address associated with azure firewall.
        /// </summary>
        [Input("privateIPAddress")]
        public Input<string>? PrivateIPAddress { get; set; }

        /// <summary>
        /// Public IP addresses associated with azure firewall.
        /// </summary>
        [Input("publicIPs")]
        public Input<Inputs.HubPublicIPAddressesArgs>? PublicIPs { get; set; }

        public HubIPAddressesArgs()
        {
        }
    }
}
