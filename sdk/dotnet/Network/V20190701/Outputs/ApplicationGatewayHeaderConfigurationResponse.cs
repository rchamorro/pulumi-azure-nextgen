// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190701.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayHeaderConfigurationResponse
    {
        /// <summary>
        /// Header name of the header configuration.
        /// </summary>
        public readonly string? HeaderName;
        /// <summary>
        /// Header value of the header configuration.
        /// </summary>
        public readonly string? HeaderValue;

        [OutputConstructor]
        private ApplicationGatewayHeaderConfigurationResponse(
            string? headerName,

            string? headerValue)
        {
            HeaderName = headerName;
            HeaderValue = headerValue;
        }
    }
}