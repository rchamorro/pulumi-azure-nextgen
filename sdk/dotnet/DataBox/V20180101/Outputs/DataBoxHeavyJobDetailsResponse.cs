// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20180101.Outputs
{

    [OutputType]
    public sealed class DataBoxHeavyJobDetailsResponse
    {
        /// <summary>
        /// Shared access key to download the chain of custody logs
        /// </summary>
        public readonly string ChainOfCustodySasKey;
        /// <summary>
        /// Contact details for notification and shipping.
        /// </summary>
        public readonly Outputs.ContactDetailsResponse ContactDetails;
        /// <summary>
        /// List of copy log details.
        /// </summary>
        public readonly ImmutableArray<object> CopyLogDetails;
        /// <summary>
        /// Copy progress per account.
        /// </summary>
        public readonly ImmutableArray<Outputs.CopyProgressResponse> CopyProgress;
        /// <summary>
        /// Delivery package shipping details.
        /// </summary>
        public readonly Outputs.PackageShippingDetailsResponse DeliveryPackage;
        /// <summary>
        /// Destination account details.
        /// </summary>
        public readonly ImmutableArray<Union<Outputs.DestinationManagedDiskDetailsResponse, Outputs.DestinationStorageAccountDetailsResponse>> DestinationAccountDetails;
        /// <summary>
        /// Error details for failure. This is optional.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobErrorDetailsResponse> ErrorDetails;
        /// <summary>
        /// The expected size of the data, which needs to be transferred in this job, in terabytes.
        /// </summary>
        public readonly int? ExpectedDataSizeInTeraBytes;
        /// <summary>
        /// Indicates the type of job details.
        /// Expected value is 'DataBoxHeavy'.
        /// </summary>
        public readonly string JobDetailsType;
        /// <summary>
        /// List of stages that run in the job.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobStagesResponse> JobStages;
        /// <summary>
        /// Preferences for the order.
        /// </summary>
        public readonly Outputs.PreferencesResponse? Preferences;
        /// <summary>
        /// Return package shipping details.
        /// </summary>
        public readonly Outputs.PackageShippingDetailsResponse ReturnPackage;
        /// <summary>
        /// Shared access key to download the return shipment label
        /// </summary>
        public readonly string ReverseShipmentLabelSasKey;
        /// <summary>
        /// Shipping address of the customer.
        /// </summary>
        public readonly Outputs.ShippingAddressResponse ShippingAddress;

        [OutputConstructor]
        private DataBoxHeavyJobDetailsResponse(
            string chainOfCustodySasKey,

            Outputs.ContactDetailsResponse contactDetails,

            ImmutableArray<object> copyLogDetails,

            ImmutableArray<Outputs.CopyProgressResponse> copyProgress,

            Outputs.PackageShippingDetailsResponse deliveryPackage,

            ImmutableArray<Union<Outputs.DestinationManagedDiskDetailsResponse, Outputs.DestinationStorageAccountDetailsResponse>> destinationAccountDetails,

            ImmutableArray<Outputs.JobErrorDetailsResponse> errorDetails,

            int? expectedDataSizeInTeraBytes,

            string jobDetailsType,

            ImmutableArray<Outputs.JobStagesResponse> jobStages,

            Outputs.PreferencesResponse? preferences,

            Outputs.PackageShippingDetailsResponse returnPackage,

            string reverseShipmentLabelSasKey,

            Outputs.ShippingAddressResponse shippingAddress)
        {
            ChainOfCustodySasKey = chainOfCustodySasKey;
            ContactDetails = contactDetails;
            CopyLogDetails = copyLogDetails;
            CopyProgress = copyProgress;
            DeliveryPackage = deliveryPackage;
            DestinationAccountDetails = destinationAccountDetails;
            ErrorDetails = errorDetails;
            ExpectedDataSizeInTeraBytes = expectedDataSizeInTeraBytes;
            JobDetailsType = jobDetailsType;
            JobStages = jobStages;
            Preferences = preferences;
            ReturnPackage = returnPackage;
            ReverseShipmentLabelSasKey = reverseShipmentLabelSasKey;
            ShippingAddress = shippingAddress;
        }
    }
}
