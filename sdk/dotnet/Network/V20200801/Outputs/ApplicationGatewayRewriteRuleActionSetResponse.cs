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
    public sealed class ApplicationGatewayRewriteRuleActionSetResponse
    {
        /// <summary>
        /// Request Header Actions in the Action Set.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayHeaderConfigurationResponse> RequestHeaderConfigurations;
        /// <summary>
        /// Response Header Actions in the Action Set.
        /// </summary>
        public readonly ImmutableArray<Outputs.ApplicationGatewayHeaderConfigurationResponse> ResponseHeaderConfigurations;
        /// <summary>
        /// Url Configuration Action in the Action Set.
        /// </summary>
        public readonly Outputs.ApplicationGatewayUrlConfigurationResponse? UrlConfiguration;

        [OutputConstructor]
        private ApplicationGatewayRewriteRuleActionSetResponse(
            ImmutableArray<Outputs.ApplicationGatewayHeaderConfigurationResponse> requestHeaderConfigurations,

            ImmutableArray<Outputs.ApplicationGatewayHeaderConfigurationResponse> responseHeaderConfigurations,

            Outputs.ApplicationGatewayUrlConfigurationResponse? urlConfiguration)
        {
            RequestHeaderConfigurations = requestHeaderConfigurations;
            ResponseHeaderConfigurations = responseHeaderConfigurations;
            UrlConfiguration = urlConfiguration;
        }
    }
}
