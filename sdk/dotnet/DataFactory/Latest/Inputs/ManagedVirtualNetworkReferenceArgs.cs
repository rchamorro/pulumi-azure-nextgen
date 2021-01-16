// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// Managed Virtual Network reference type.
    /// </summary>
    public sealed class ManagedVirtualNetworkReferenceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Reference ManagedVirtualNetwork name.
        /// </summary>
        [Input("referenceName", required: true)]
        public Input<string> ReferenceName { get; set; } = null!;

        /// <summary>
        /// Managed Virtual Network reference type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ManagedVirtualNetworkReferenceArgs()
        {
        }
    }
}
