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
    /// Contains custom Dns resolution configuration from customer.
    /// </summary>
    public sealed class CustomDnsConfigPropertiesFormatArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fqdn that resolves to private endpoint ip address.
        /// </summary>
        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        [Input("ipAddresses")]
        private InputList<string>? _ipAddresses;

        /// <summary>
        /// A list of private ip addresses of the private endpoint.
        /// </summary>
        public InputList<string> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<string>());
            set => _ipAddresses = value;
        }

        public CustomDnsConfigPropertiesFormatArgs()
        {
        }
    }
}
