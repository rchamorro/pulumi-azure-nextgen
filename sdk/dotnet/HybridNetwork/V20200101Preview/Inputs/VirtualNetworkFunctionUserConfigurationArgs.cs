// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HybridNetwork.V20200101Preview.Inputs
{

    /// <summary>
    /// The virtual network function user configuration.
    /// </summary>
    public sealed class VirtualNetworkFunctionUserConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("networkInterfaces")]
        private InputList<Inputs.NetworkInterfaceArgs>? _networkInterfaces;

        /// <summary>
        /// The network interface configuration.
        /// </summary>
        public InputList<Inputs.NetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.NetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The name of the virtual network function role.
        /// </summary>
        [Input("roleName")]
        public Input<string>? RoleName { get; set; }

        /// <summary>
        /// The user data parameters from the customer.
        /// </summary>
        [Input("userDataParameters")]
        public Input<object>? UserDataParameters { get; set; }

        public VirtualNetworkFunctionUserConfigurationArgs()
        {
        }
    }
}
