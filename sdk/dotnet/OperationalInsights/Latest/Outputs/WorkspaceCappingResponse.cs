// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.OperationalInsights.Latest.Outputs
{

    [OutputType]
    public sealed class WorkspaceCappingResponse
    {
        /// <summary>
        /// The workspace daily quota for ingestion.
        /// </summary>
        public readonly double? DailyQuotaGb;
        /// <summary>
        /// The status of data ingestion for this workspace.
        /// </summary>
        public readonly string DataIngestionStatus;
        /// <summary>
        /// The time when the quota will be rest.
        /// </summary>
        public readonly string QuotaNextResetTime;

        [OutputConstructor]
        private WorkspaceCappingResponse(
            double? dailyQuotaGb,

            string dataIngestionStatus,

            string quotaNextResetTime)
        {
            DailyQuotaGb = dailyQuotaGb;
            DataIngestionStatus = dataIngestionStatus;
            QuotaNextResetTime = quotaNextResetTime;
        }
    }
}