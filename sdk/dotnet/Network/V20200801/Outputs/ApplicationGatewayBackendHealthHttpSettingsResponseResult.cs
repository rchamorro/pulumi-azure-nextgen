// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Outputs
{

    [OutputType]
    public sealed class ApplicationGatewayBackendHealthHttpSettingsResponseResult
    {
        /// <summary>
        /// Reference to an ApplicationGatewayBackendHttpSettings resource.
        /// </summary>
        public readonly Outputs.ApplicationGatewayBackendHttpSettingsResponse? BackendHttpSettings;
        /// <summary>
        /// List of ApplicationGatewayBackendHealthServer resources.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayBackendHealthServerResponseResult> Servers;

        [OutputConstructor]
        private ApplicationGatewayBackendHealthHttpSettingsResponseResult(
            Outputs.ApplicationGatewayBackendHttpSettingsResponse? backendHttpSettings,

            ImmutableArray<Outputs.ApplicationGatewayBackendHealthServerResponseResult> servers)
        {
            BackendHttpSettings = backendHttpSettings;
            Servers = servers;
        }
    }
}
