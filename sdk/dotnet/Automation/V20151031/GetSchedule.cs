// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20151031
{
    public static class GetSchedule
    {
        public static Task<GetScheduleResult> InvokeAsync(GetScheduleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetScheduleResult>("azure-nextgen:automation/v20151031:getSchedule", args ?? new GetScheduleArgs(), options.WithVersion());
    }


    public sealed class GetScheduleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the automation account.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public string AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The schedule name.
        /// </summary>
        [Input("scheduleName", required: true)]
        public string ScheduleName { get; set; } = null!;

        public GetScheduleArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetScheduleResult
    {
        /// <summary>
        /// Gets or sets the advanced schedule.
        /// </summary>
        public readonly Outputs.AdvancedScheduleResponse? AdvancedSchedule;
        /// <summary>
        /// Gets or sets the creation time.
        /// </summary>
        public readonly string? CreationTime;
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Gets or sets the end time of the schedule.
        /// </summary>
        public readonly string? ExpiryTime;
        /// <summary>
        /// Gets or sets the expiry time's offset in minutes.
        /// </summary>
        public readonly double? ExpiryTimeOffsetMinutes;
        /// <summary>
        /// Gets or sets the frequency of the schedule.
        /// </summary>
        public readonly string? Frequency;
        /// <summary>
        /// Gets or sets the interval of the schedule.
        /// </summary>
        public readonly object? Interval;
        /// <summary>
        /// Gets or sets a value indicating whether this schedule is enabled.
        /// </summary>
        public readonly bool? IsEnabled;
        /// <summary>
        /// Gets or sets the last modified time.
        /// </summary>
        public readonly string? LastModifiedTime;
        /// <summary>
        /// The name of the resource
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets or sets the next run time of the schedule.
        /// </summary>
        public readonly string? NextRun;
        /// <summary>
        /// Gets or sets the next run time's offset in minutes.
        /// </summary>
        public readonly double? NextRunOffsetMinutes;
        /// <summary>
        /// Gets or sets the start time of the schedule.
        /// </summary>
        public readonly string? StartTime;
        /// <summary>
        /// Gets the start time's offset in minutes.
        /// </summary>
        public readonly double StartTimeOffsetMinutes;
        /// <summary>
        /// Gets or sets the time zone of the schedule.
        /// </summary>
        public readonly string? TimeZone;
        /// <summary>
        /// The type of the resource.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetScheduleResult(
            Outputs.AdvancedScheduleResponse? advancedSchedule,

            string? creationTime,

            string? description,

            string? expiryTime,

            double? expiryTimeOffsetMinutes,

            string? frequency,

            object? interval,

            bool? isEnabled,

            string? lastModifiedTime,

            string name,

            string? nextRun,

            double? nextRunOffsetMinutes,

            string? startTime,

            double startTimeOffsetMinutes,

            string? timeZone,

            string type)
        {
            AdvancedSchedule = advancedSchedule;
            CreationTime = creationTime;
            Description = description;
            ExpiryTime = expiryTime;
            ExpiryTimeOffsetMinutes = expiryTimeOffsetMinutes;
            Frequency = frequency;
            Interval = interval;
            IsEnabled = isEnabled;
            LastModifiedTime = lastModifiedTime;
            Name = name;
            NextRun = nextRun;
            NextRunOffsetMinutes = nextRunOffsetMinutes;
            StartTime = startTime;
            StartTimeOffsetMinutes = startTimeOffsetMinutes;
            TimeZone = timeZone;
            Type = type;
        }
    }
}
