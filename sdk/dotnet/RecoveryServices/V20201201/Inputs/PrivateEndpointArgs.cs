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
    /// The Private Endpoint network resource that is linked to the Private Endpoint connection
    /// </summary>
    public sealed class PrivateEndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gets or sets id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        public PrivateEndpointArgs()
        {
        }
    }
}
