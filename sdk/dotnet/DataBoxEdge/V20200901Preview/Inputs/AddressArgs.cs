// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901Preview.Inputs
{

    /// <summary>
    /// The shipping address of the customer.
    /// </summary>
    public sealed class AddressArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The address line1.
        /// </summary>
        [Input("addressLine1")]
        public Input<string>? AddressLine1 { get; set; }

        /// <summary>
        /// The address line2.
        /// </summary>
        [Input("addressLine2")]
        public Input<string>? AddressLine2 { get; set; }

        /// <summary>
        /// The address line3.
        /// </summary>
        [Input("addressLine3")]
        public Input<string>? AddressLine3 { get; set; }

        /// <summary>
        /// The city name.
        /// </summary>
        [Input("city")]
        public Input<string>? City { get; set; }

        /// <summary>
        /// The country name.
        /// </summary>
        [Input("country", required: true)]
        public Input<string> Country { get; set; } = null!;

        /// <summary>
        /// The postal code.
        /// </summary>
        [Input("postalCode")]
        public Input<string>? PostalCode { get; set; }

        /// <summary>
        /// The state name.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        public AddressArgs()
        {
        }
    }
}
