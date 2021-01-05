// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20180101
{
    public static class GetJob
    {
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("azure-nextgen:databox/v20180101:getJob", args ?? new GetJobArgs(), options.WithVersion());
    }


    public sealed class GetJobArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// $expand is supported on details parameter for job, which provides details on the job stages.
        /// </summary>
        [Input("expand")]
        public string? Expand { get; set; }

        /// <summary>
        /// The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
        /// </summary>
        [Input("jobName", required: true)]
        public string JobName { get; set; } = null!;

        /// <summary>
        /// The Resource Group Name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetJobArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetJobResult
    {
        /// <summary>
        /// Reason for cancellation.
        /// </summary>
        public readonly string CancellationReason;
        /// <summary>
        /// Details of a job run. This field will only be sent for expand details filter.
        /// </summary>
        public readonly object? Details;
        /// <summary>
        /// Top level error for the job.
        /// </summary>
        public readonly Outputs.ErrorResponse Error;
        /// <summary>
        /// Id of the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Describes whether the job is cancellable or not.
        /// </summary>
        public readonly bool IsCancellable;
        /// <summary>
        /// Describes whether the job is deletable or not.
        /// </summary>
        public readonly bool IsDeletable;
        /// <summary>
        /// Describes whether the shipping address is editable or not.
        /// </summary>
        public readonly bool IsShippingAddressEditable;
        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on update the request will succeed.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Name of the object.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The sku type.
        /// </summary>
        public readonly Outputs.SkuResponse Sku;
        /// <summary>
        /// Time at which the job was started in UTC ISO 8601 format.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// Name of the stage which is in progress.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Type of the object.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetJobResult(
            string cancellationReason,

            object? details,

            Outputs.ErrorResponse error,

            string id,

            bool isCancellable,

            bool isDeletable,

            bool isShippingAddressEditable,

            string location,

            string name,

            Outputs.SkuResponse sku,

            string startTime,

            string status,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            CancellationReason = cancellationReason;
            Details = details;
            Error = error;
            Id = id;
            IsCancellable = isCancellable;
            IsDeletable = isDeletable;
            IsShippingAddressEditable = isShippingAddressEditable;
            Location = location;
            Name = name;
            Sku = sku;
            StartTime = startTime;
            Status = status;
            Tags = tags;
            Type = type;
        }
    }
}
