// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20200601.Inputs
{

    /// <summary>
    /// Describes a virtual machine scale set network profile's network configurations.
    /// </summary>
    public sealed class VirtualMachineScaleSetNetworkConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The dns settings to be applied on the network interfaces.
        /// </summary>
        [Input("dnsSettings")]
        public Input<Inputs.VirtualMachineScaleSetNetworkConfigurationDnsSettingsArgs>? DnsSettings { get; set; }

        /// <summary>
        /// Specifies whether the network interface is accelerated networking-enabled.
        /// </summary>
        [Input("enableAcceleratedNetworking")]
        public Input<bool>? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Specifies whether the network interface is FPGA networking-enabled.
        /// </summary>
        [Input("enableFpga")]
        public Input<bool>? EnableFpga { get; set; }

        /// <summary>
        /// Whether IP forwarding enabled on this NIC.
        /// </summary>
        [Input("enableIPForwarding")]
        public Input<bool>? EnableIPForwarding { get; set; }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipConfigurations", required: true)]
        private InputList<Inputs.VirtualMachineScaleSetIPConfigurationArgs>? _ipConfigurations;

        /// <summary>
        /// Specifies the IP configurations of the network interface.
        /// </summary>
        public InputList<Inputs.VirtualMachineScaleSetIPConfigurationArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.VirtualMachineScaleSetIPConfigurationArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// The network configuration name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The network security group.
        /// </summary>
        [Input("networkSecurityGroup")]
        public Input<Inputs.SubResourceArgs>? NetworkSecurityGroup { get; set; }

        /// <summary>
        /// Specifies the primary network interface in case the virtual machine has more than 1 network interface.
        /// </summary>
        [Input("primary")]
        public Input<bool>? Primary { get; set; }

        public VirtualMachineScaleSetNetworkConfigurationArgs()
        {
        }
    }
}
