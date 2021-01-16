// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801.Inputs
{

    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    public sealed class VirtualApplianceSkuPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Virtual Appliance Scale Unit.
        /// </summary>
        [Input("bundledScaleUnit")]
        public Input<string>? BundledScaleUnit { get; set; }

        /// <summary>
        /// Virtual Appliance Version.
        /// </summary>
        [Input("marketPlaceVersion")]
        public Input<string>? MarketPlaceVersion { get; set; }

        /// <summary>
        /// Virtual Appliance Vendor.
        /// </summary>
        [Input("vendor")]
        public Input<string>? Vendor { get; set; }

        public VirtualApplianceSkuPropertiesArgs()
        {
        }
    }
}
