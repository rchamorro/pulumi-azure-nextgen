// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StorSimple.V20170601.Outputs
{

    [OutputType]
    public sealed class FailoverTargetResponseResult
    {
        /// <summary>
        /// The amount of free local storage available on the device in bytes.
        /// </summary>
        public readonly double? AvailableLocalStorageInBytes;
        /// <summary>
        /// The amount of free tiered storage available for the device in bytes.
        /// </summary>
        public readonly double? AvailableTieredStorageInBytes;
        /// <summary>
        /// The count of data containers on the device.
        /// </summary>
        public readonly int? DataContainersCount;
        /// <summary>
        /// The path ID of the device.
        /// </summary>
        public readonly string? DeviceId;
        /// <summary>
        /// The geo location (applicable only for cloud appliances) of the device.
        /// </summary>
        public readonly string? DeviceLocation;
        /// <summary>
        /// The software version of the device.
        /// </summary>
        public readonly string? DeviceSoftwareVersion;
        /// <summary>
        /// The status of the device.
        /// </summary>
        public readonly string? DeviceStatus;
        /// <summary>
        /// The eligibility result of the device, as a failover target device.
        /// </summary>
        public readonly Outputs.TargetEligibilityResultResponseResult? EligibilityResult;
        /// <summary>
        /// The friendly name for the current version of software on the device.
        /// </summary>
        public readonly string? FriendlyDeviceSoftwareVersion;
        /// <summary>
        /// The model number of the device.
        /// </summary>
        public readonly string? ModelDescription;
        /// <summary>
        /// The count of volumes on the device.
        /// </summary>
        public readonly int? VolumesCount;

        [OutputConstructor]
        private FailoverTargetResponseResult(
            double? availableLocalStorageInBytes,

            double? availableTieredStorageInBytes,

            int? dataContainersCount,

            string? deviceId,

            string? deviceLocation,

            string? deviceSoftwareVersion,

            string? deviceStatus,

            Outputs.TargetEligibilityResultResponseResult? eligibilityResult,

            string? friendlyDeviceSoftwareVersion,

            string? modelDescription,

            int? volumesCount)
        {
            AvailableLocalStorageInBytes = availableLocalStorageInBytes;
            AvailableTieredStorageInBytes = availableTieredStorageInBytes;
            DataContainersCount = dataContainersCount;
            DeviceId = deviceId;
            DeviceLocation = deviceLocation;
            DeviceSoftwareVersion = deviceSoftwareVersion;
            DeviceStatus = deviceStatus;
            EligibilityResult = eligibilityResult;
            FriendlyDeviceSoftwareVersion = friendlyDeviceSoftwareVersion;
            ModelDescription = modelDescription;
            VolumesCount = volumesCount;
        }
    }
}
