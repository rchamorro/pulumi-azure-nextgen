// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190901.Inputs
{

    /// <summary>
    /// Filter that is applied to packet capture request. Multiple filters can be applied.
    /// </summary>
    public sealed class PacketCaptureFilterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [Input("localIPAddress")]
        public Input<string>? LocalIPAddress { get; set; }

        /// <summary>
        /// Local port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [Input("localPort")]
        public Input<string>? LocalPort { get; set; }

        /// <summary>
        /// Protocol to be filtered on.
        /// </summary>
        [Input("protocol")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20190901.PcProtocol>? Protocol { get; set; }

        /// <summary>
        /// Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [Input("remoteIPAddress")]
        public Input<string>? RemoteIPAddress { get; set; }

        /// <summary>
        /// Remote port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [Input("remotePort")]
        public Input<string>? RemotePort { get; set; }

        public PacketCaptureFilterArgs()
        {
            Protocol = "Any";
        }
    }
}
