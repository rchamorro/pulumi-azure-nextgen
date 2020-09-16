// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceFabricMesh.V20180701Preview.Inputs
{

    /// <summary>
    /// Describes a network reference in a service.
    /// </summary>
    public sealed class NetworkRefArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the network.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public NetworkRefArgs()
        {
        }
    }
}