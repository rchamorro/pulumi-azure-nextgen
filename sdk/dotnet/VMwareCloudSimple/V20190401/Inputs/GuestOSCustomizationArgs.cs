// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.VMwareCloudSimple.V20190401.Inputs
{

    /// <summary>
    /// Guest OS Customization properties
    /// </summary>
    public sealed class GuestOSCustomizationArgs : Pulumi.ResourceArgs
    {
        [Input("dnsServers")]
        private InputList<string>? _dnsServers;

        /// <summary>
        /// List of dns servers to use
        /// </summary>
        public InputList<string> DnsServers
        {
            get => _dnsServers ?? (_dnsServers = new InputList<string>());
            set => _dnsServers = value;
        }

        /// <summary>
        /// Virtual Machine hostname
        /// </summary>
        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// Password for login
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        /// <summary>
        /// id of customization policy
        /// </summary>
        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        /// <summary>
        /// Username for login
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public GuestOSCustomizationArgs()
        {
        }
    }
}