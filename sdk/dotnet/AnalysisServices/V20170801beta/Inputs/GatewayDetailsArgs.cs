// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AnalysisServices.V20170801beta.Inputs
{

    /// <summary>
    /// The gateway details.
    /// </summary>
    public sealed class GatewayDetailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gateway resource to be associated with the server.
        /// </summary>
        [Input("gatewayResourceId")]
        public Input<string>? GatewayResourceId { get; set; }

        public GatewayDetailsArgs()
        {
        }
    }
}