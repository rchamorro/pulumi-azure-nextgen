// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.HealthcareApis.V20210111.Inputs
{

    /// <summary>
    /// Authentication configuration information
    /// </summary>
    public sealed class ServiceAuthenticationConfigurationInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The audience url for the service
        /// </summary>
        [Input("audience")]
        public Input<string>? Audience { get; set; }

        /// <summary>
        /// The authority url for the service
        /// </summary>
        [Input("authority")]
        public Input<string>? Authority { get; set; }

        /// <summary>
        /// If the SMART on FHIR proxy is enabled
        /// </summary>
        [Input("smartProxyEnabled")]
        public Input<bool>? SmartProxyEnabled { get; set; }

        public ServiceAuthenticationConfigurationInfoArgs()
        {
        }
    }
}
