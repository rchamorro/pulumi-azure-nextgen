// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20210101.Inputs
{

    /// <summary>
    /// Container extended information
    /// </summary>
    public sealed class GenericContainerExtendedInfoArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Container identity information
        /// </summary>
        [Input("containerIdentityInfo")]
        public Input<Inputs.ContainerIdentityInfoArgs>? ContainerIdentityInfo { get; set; }

        /// <summary>
        /// Public key of container cert
        /// </summary>
        [Input("rawCertData")]
        public Input<string>? RawCertData { get; set; }

        [Input("serviceEndpoints")]
        private InputMap<string>? _serviceEndpoints;

        /// <summary>
        /// Azure Backup Service Endpoints for the container
        /// </summary>
        public InputMap<string> ServiceEndpoints
        {
            get => _serviceEndpoints ?? (_serviceEndpoints = new InputMap<string>());
            set => _serviceEndpoints = value;
        }

        public GenericContainerExtendedInfoArgs()
        {
        }
    }
}
