// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest.Inputs
{

    /// <summary>
    /// Radius Server Settings.
    /// </summary>
    public sealed class RadiusServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The address of this radius server.
        /// </summary>
        [Input("radiusServerAddress", required: true)]
        public Input<string> RadiusServerAddress { get; set; } = null!;

        /// <summary>
        /// The initial score assigned to this radius server.
        /// </summary>
        [Input("radiusServerScore")]
        public Input<double>? RadiusServerScore { get; set; }

        /// <summary>
        /// The secret used for this radius server.
        /// </summary>
        [Input("radiusServerSecret")]
        public Input<string>? RadiusServerSecret { get; set; }

        public RadiusServerArgs()
        {
        }
    }
}
