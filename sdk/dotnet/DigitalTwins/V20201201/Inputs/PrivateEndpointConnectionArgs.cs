// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DigitalTwins.V20201201.Inputs
{

    /// <summary>
    /// The private endpoint connection of a Digital Twin.
    /// </summary>
    public sealed class PrivateEndpointConnectionArgs : Pulumi.ResourceArgs
    {
        [Input("properties", required: true)]
        public Input<Inputs.PrivateEndpointConnectionPropertiesArgs> Properties { get; set; } = null!;

        public PrivateEndpointConnectionArgs()
        {
        }
    }
}
