// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201.Inputs
{

    /// <summary>
    /// This is used to represent the various nodes of the distributed container.
    /// </summary>
    public sealed class DistributedNodesInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the node under a distributed container.
        /// </summary>
        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        /// <summary>
        /// Status of this Node.
        /// Failed | Succeeded
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public DistributedNodesInfoArgs()
        {
        }
    }
}
