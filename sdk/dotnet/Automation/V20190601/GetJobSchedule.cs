// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Automation.V20190601
{
    public static class GetJobSchedule
    {
        public static Task<GetJobScheduleResult> InvokeAsync(GetJobScheduleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobScheduleResult>("azure-nextgen:automation/v20190601:getJobSchedule", args ?? new GetJobScheduleArgs(), options.WithVersion());
    }


    public sealed class GetJobScheduleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the automation account.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public string AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The job schedule name.
        /// </summary>
        [Input("jobScheduleId", required: true)]
        public string JobScheduleId { get; set; } = null!;

        /// <summary>
        /// Name of an Azure Resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetJobScheduleArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJobScheduleResult
    {
        /// <summary>
        /// Gets the id of the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Gets or sets the id of job schedule.
        /// </summary>
        public readonly string? JobScheduleId;
        /// <summary>
        /// Gets the name of the variable.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Gets or sets the parameters of the job schedule.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Parameters;
        /// <summary>
        /// Gets or sets the hybrid worker group that the scheduled job should run on.
        /// </summary>
        public readonly string? RunOn;
        /// <summary>
        /// Gets or sets the runbook.
        /// </summary>
        public readonly Outputs.RunbookAssociationPropertyResponse? Runbook;
        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        public readonly Outputs.ScheduleAssociationPropertyResponse? Schedule;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetJobScheduleResult(
            string id,

            string? jobScheduleId,

            string name,

            ImmutableDictionary<string, string>? parameters,

            string? runOn,

            Outputs.RunbookAssociationPropertyResponse? runbook,

            Outputs.ScheduleAssociationPropertyResponse? schedule,

            string type)
        {
            Id = id;
            JobScheduleId = jobScheduleId;
            Name = name;
            Parameters = parameters;
            RunOn = runOn;
            Runbook = runbook;
            Schedule = schedule;
            Type = type;
        }
    }
}
