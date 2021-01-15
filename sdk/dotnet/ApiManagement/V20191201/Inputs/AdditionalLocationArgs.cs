// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ApiManagement.V20191201.Inputs
{

    /// <summary>
    /// Description of an additional API Management resource location.
    /// </summary>
    public sealed class AdditionalLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.
        /// </summary>
        [Input("disableGateway")]
        public Input<bool>? DisableGateway { get; set; }

        /// <summary>
        /// The location name of the additional region among Azure Data center regions.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// SKU properties of the API Management service.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.ApiManagementServiceSkuPropertiesArgs> Sku { get; set; } = null!;

        /// <summary>
        /// Virtual network configuration for the location.
        /// </summary>
        [Input("virtualNetworkConfiguration")]
        public Input<Inputs.VirtualNetworkConfigurationArgs>? VirtualNetworkConfiguration { get; set; }

        public AdditionalLocationArgs()
        {
            DisableGateway = false;
        }
    }
}
