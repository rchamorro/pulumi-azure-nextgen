// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20200831Preview.Outputs
{

    [OutputType]
    public sealed class IotHubPropertiesResponseDeviceStreams
    {
        /// <summary>
        /// List of Device Streams Endpoints.
        /// </summary>
        public readonly ImmutableArray<string> StreamingEndpoints;

        [OutputConstructor]
        private IotHubPropertiesResponseDeviceStreams(ImmutableArray<string> streamingEndpoints)
        {
            StreamingEndpoints = streamingEndpoints;
        }
    }
}
