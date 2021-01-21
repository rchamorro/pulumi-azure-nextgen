// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.V20210111.Outputs
{

    [OutputType]
    public sealed class ServiceAcrConfigurationInfoResponse
    {
        /// <summary>
        /// The list of the ACR login servers.
        /// </summary>
        public readonly ImmutableArray<string> LoginServers;

        [OutputConstructor]
        private ServiceAcrConfigurationInfoResponse(ImmutableArray<string> loginServers)
        {
            LoginServers = loginServers;
        }
    }
}
