// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20200930.Inputs
{

    /// <summary>
    /// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
    /// </summary>
    public sealed class PurchasePlanArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The plan ID.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the product of the image from the marketplace. This is the same value as Offer under the imageReference element.
        /// </summary>
        [Input("product", required: true)]
        public Input<string> Product { get; set; } = null!;

        /// <summary>
        /// The Offer Promotion Code.
        /// </summary>
        [Input("promotionCode")]
        public Input<string>? PromotionCode { get; set; }

        /// <summary>
        /// The publisher ID.
        /// </summary>
        [Input("publisher", required: true)]
        public Input<string> Publisher { get; set; } = null!;

        public PurchasePlanArgs()
        {
        }
    }
}
