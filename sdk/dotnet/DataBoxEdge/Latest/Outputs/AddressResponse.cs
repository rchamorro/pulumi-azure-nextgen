// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.Latest.Outputs
{

    [OutputType]
    public sealed class AddressResponse
    {
        /// <summary>
        /// The address line1.
        /// </summary>
        public readonly string? AddressLine1;
        /// <summary>
        /// The address line2.
        /// </summary>
        public readonly string? AddressLine2;
        /// <summary>
        /// The address line3.
        /// </summary>
        public readonly string? AddressLine3;
        /// <summary>
        /// The city name.
        /// </summary>
        public readonly string? City;
        /// <summary>
        /// The country name.
        /// </summary>
        public readonly string Country;
        /// <summary>
        /// The postal code.
        /// </summary>
        public readonly string? PostalCode;
        /// <summary>
        /// The state name.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private AddressResponse(
            string? addressLine1,

            string? addressLine2,

            string? addressLine3,

            string? city,

            string country,

            string? postalCode,

            string? state)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            City = city;
            Country = country;
            PostalCode = postalCode;
            State = state;
        }
    }
}
