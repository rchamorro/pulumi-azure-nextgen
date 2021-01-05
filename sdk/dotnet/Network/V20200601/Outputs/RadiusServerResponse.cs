// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200601.Outputs
{

    [OutputType]
    public sealed class RadiusServerResponse
    {
        /// <summary>
        /// The address of this radius server.
        /// </summary>
        public readonly string RadiusServerAddress;
        /// <summary>
        /// The initial score assigned to this radius server.
        /// </summary>
        public readonly double? RadiusServerScore;
        /// <summary>
        /// The secret used for this radius server.
        /// </summary>
        public readonly string? RadiusServerSecret;

        [OutputConstructor]
        private RadiusServerResponse(
            string radiusServerAddress,

            double? radiusServerScore,

            string? radiusServerSecret)
        {
            RadiusServerAddress = radiusServerAddress;
            RadiusServerScore = radiusServerScore;
            RadiusServerSecret = radiusServerSecret;
        }
    }
}
