// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerInstance.V20201101.Inputs
{

    /// <summary>
    /// The port exposed on the container group.
    /// </summary>
    public sealed class PortArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The port number.
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// The protocol associated with the port.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        public PortArgs()
        {
        }
    }
}
