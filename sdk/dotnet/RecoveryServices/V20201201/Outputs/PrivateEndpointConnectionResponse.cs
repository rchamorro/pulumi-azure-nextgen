// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201.Outputs
{

    [OutputType]
    public sealed class PrivateEndpointConnectionResponse
    {
        /// <summary>
        /// Gets or sets private endpoint associated with the private endpoint connection
        /// </summary>
        public readonly Outputs.PrivateEndpointResponse? PrivateEndpoint;
        /// <summary>
        /// Gets or sets private link service connection state
        /// </summary>
        public readonly Outputs.PrivateLinkServiceConnectionStateResponse? PrivateLinkServiceConnectionState;
        /// <summary>
        /// Gets or sets provisioning state of the private endpoint connection
        /// </summary>
        public readonly string? ProvisioningState;

        [OutputConstructor]
        private PrivateEndpointConnectionResponse(
            Outputs.PrivateEndpointResponse? privateEndpoint,

            Outputs.PrivateLinkServiceConnectionStateResponse? privateLinkServiceConnectionState,

            string? provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }
    }
}
