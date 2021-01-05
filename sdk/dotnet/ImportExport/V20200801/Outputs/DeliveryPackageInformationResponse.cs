// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ImportExport.V20200801.Outputs
{

    [OutputType]
    public sealed class DeliveryPackageInformationResponse
    {
        /// <summary>
        /// The name of the carrier that is used to ship the import or export drives.
        /// </summary>
        public readonly string CarrierName;
        /// <summary>
        /// The number of drives included in the package.
        /// </summary>
        public readonly double? DriveCount;
        /// <summary>
        /// The date when the package is shipped.
        /// </summary>
        public readonly string? ShipDate;
        /// <summary>
        /// The tracking number of the package.
        /// </summary>
        public readonly string TrackingNumber;

        [OutputConstructor]
        private DeliveryPackageInformationResponse(
            string carrierName,

            double? driveCount,

            string? shipDate,

            string trackingNumber)
        {
            CarrierName = carrierName;
            DriveCount = driveCount;
            ShipDate = shipDate;
            TrackingNumber = trackingNumber;
        }
    }
}
