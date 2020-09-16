// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RedHatOpenShift.V20200430.Inputs
{

    /// <summary>
    /// ClusterProfile represents a cluster profile.
    /// </summary>
    public sealed class ClusterProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The domain for the cluster (immutable).
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// The pull secret for the cluster (immutable).
        /// </summary>
        [Input("pullSecret")]
        public Input<string>? PullSecret { get; set; }

        /// <summary>
        /// The ID of the cluster resource group (immutable).
        /// </summary>
        [Input("resourceGroupId")]
        public Input<string>? ResourceGroupId { get; set; }

        /// <summary>
        /// The version of the cluster (immutable).
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public ClusterProfileArgs()
        {
        }
    }
}