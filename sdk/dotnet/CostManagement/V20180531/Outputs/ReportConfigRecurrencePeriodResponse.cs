// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CostManagement.V20180531.Outputs
{

    [OutputType]
    public sealed class ReportConfigRecurrencePeriodResponse
    {
        /// <summary>
        /// The start date of recurrence.
        /// </summary>
        public readonly string From;
        /// <summary>
        /// The end date of recurrence. If not provided, we default this to 10 years from the start date.
        /// </summary>
        public readonly string? To;

        [OutputConstructor]
        private ReportConfigRecurrencePeriodResponse(
            string from,

            string? to)
        {
            From = from;
            To = to;
        }
    }
}