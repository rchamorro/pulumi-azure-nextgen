// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901Preview
{
    public static class GetBandwidthSchedule
    {
        public static Task<GetBandwidthScheduleResult> InvokeAsync(GetBandwidthScheduleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBandwidthScheduleResult>("azure-nextgen:databoxedge/v20200901preview:getBandwidthSchedule", args ?? new GetBandwidthScheduleArgs(), options.WithVersion());
    }


    public sealed class GetBandwidthScheduleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The device name.
        /// </summary>
        [Input("deviceName", required: true)]
        public string DeviceName { get; set; } = null!;

        /// <summary>
        /// The bandwidth schedule name.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetBandwidthScheduleArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBandwidthScheduleResult
    {
        /// <summary>
        /// The days of the week when this schedule is applicable.
        /// </summary>
        public readonly ImmutableArray<string> Days;
        /// <summary>
        /// The path ID that uniquely identifies the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The object name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The bandwidth rate in Mbps.
        /// </summary>
        public readonly int RateInMbps;
        /// <summary>
        /// The start time of the schedule in UTC.
        /// </summary>
        public readonly string Start;
        /// <summary>
        /// The stop time of the schedule in UTC.
        /// </summary>
        public readonly string Stop;
        /// <summary>
        /// Bandwidth object related to ASE resource
        /// </summary>
        public readonly Outputs.SystemDataResponse SystemData;
        /// <summary>
        /// The hierarchical type of the object.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetBandwidthScheduleResult(
            ImmutableArray<string> days,

            string id,

            string name,

            int rateInMbps,

            string start,

            string stop,

            Outputs.SystemDataResponse systemData,

            string type)
        {
            Days = days;
            Id = id;
            Name = name;
            RateInMbps = rateInMbps;
            Start = start;
            Stop = stop;
            SystemData = systemData;
            Type = type;
        }
    }
}
