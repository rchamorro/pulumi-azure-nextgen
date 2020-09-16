// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.V20180701.Outputs
{

    [OutputType]
    public sealed class EdgeUsageDataCollectionPolicyResponseResult
    {
        /// <summary>
        /// Usage data collection frequency in ISO 8601 duration format e.g. PT10M , PT5H.
        /// </summary>
        public readonly string? DataCollectionFrequency;
        /// <summary>
        /// Usage data reporting frequency in ISO 8601 duration format e.g. PT10M , PT5H.
        /// </summary>
        public readonly string? DataReportingFrequency;
        /// <summary>
        /// Details of Event Hub where the usage will be reported.
        /// </summary>
        public readonly Outputs.EdgeUsageDataEventHubResponseResult? EventHubDetails;
        /// <summary>
        /// Maximum time for which the functionality of the device will not be hampered for not reporting the usage data.
        /// </summary>
        public readonly string? MaxAllowedUnreportedUsageDuration;

        [OutputConstructor]
        private EdgeUsageDataCollectionPolicyResponseResult(
            string? dataCollectionFrequency,

            string? dataReportingFrequency,

            Outputs.EdgeUsageDataEventHubResponseResult? eventHubDetails,

            string? maxAllowedUnreportedUsageDuration)
        {
            DataCollectionFrequency = dataCollectionFrequency;
            DataReportingFrequency = dataReportingFrequency;
            EventHubDetails = eventHubDetails;
            MaxAllowedUnreportedUsageDuration = maxAllowedUnreportedUsageDuration;
        }
    }
}