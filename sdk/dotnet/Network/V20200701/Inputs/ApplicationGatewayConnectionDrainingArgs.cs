// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Inputs
{

    /// <summary>
    /// Connection draining allows open connections to a backend server to be active for a specified time after the backend server got removed from the configuration.
    /// </summary>
    public sealed class ApplicationGatewayConnectionDrainingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of seconds connection draining is active. Acceptable values are from 1 second to 3600 seconds.
        /// </summary>
        [Input("drainTimeoutInSec", required: true)]
        public Input<int> DrainTimeoutInSec { get; set; } = null!;

        /// <summary>
        /// Whether connection draining is enabled or not.
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public ApplicationGatewayConnectionDrainingArgs()
        {
        }
    }
}
