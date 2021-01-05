// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.Latest
{
    public static class GetJob
    {
        public static Task<GetJobResult> InvokeAsync(GetJobArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetJobResult>("azure-nextgen:databox/latest:getJob", args ?? new GetJobArgs(), options.WithVersion());
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
        /// Delivery Info of Job.
        /// </summary>
        public readonly Outputs.JobDeliveryInfoResponse? DeliveryInfo;
        /// <summary>
        /// Delivery type of Job.
        /// </summary>
        public readonly string? DeliveryType;
        /// <summary>
        /// Details of a job run. This field will only be sent for expand details filter.
        /// </summary>
        public readonly object? Details;
        /// <summary>
        /// Top level error for the job.
        /// </summary>
        public readonly Outputs.CloudErrorResponse Error;
        /// <summary>
        /// Id of the object.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Msi identity of the resource
        /// </summary>
        public readonly Outputs.ResourceIdentityResponse? Identity;
        /// <summary>
        /// Describes whether the job is cancellable or not.
        /// </summary>
        public readonly bool IsCancellable;
        /// <summary>
        /// Flag to indicate cancellation of scheduled job.
        /// </summary>
        public readonly bool IsCancellableWithoutFee;
        /// <summary>
        /// Describes whether the job is deletable or not.
        /// </summary>
        public readonly bool IsDeletable;
        /// <summary>
        /// Is Prepare To Ship Enabled on this job
        /// </summary>
        public readonly bool IsPrepareToShipEnabled;
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
        /// Type of the data transfer.
        /// </summary>
        public readonly string TransferType;
        /// <summary>
        /// Type of the object.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetJobResult(
            string cancellationReason,

            Outputs.JobDeliveryInfoResponse? deliveryInfo,

            string? deliveryType,

            object? details,

            Outputs.CloudErrorResponse error,

            string id,

            Outputs.ResourceIdentityResponse? identity,

            bool isCancellable,

            bool isCancellableWithoutFee,

            bool isDeletable,

            bool isPrepareToShipEnabled,

            bool isShippingAddressEditable,

            string location,

            string name,

            Outputs.SkuResponse sku,

            string startTime,

            string status,

            ImmutableDictionary<string, string>? tags,

            string transferType,

            string type)
        {
            CancellationReason = cancellationReason;
            DeliveryInfo = deliveryInfo;
            DeliveryType = deliveryType;
            Details = details;
            Error = error;
            Id = id;
            Identity = identity;
            IsCancellable = isCancellable;
            IsCancellableWithoutFee = isCancellableWithoutFee;
            IsDeletable = isDeletable;
            IsPrepareToShipEnabled = isPrepareToShipEnabled;
            IsShippingAddressEditable = isShippingAddressEditable;
            Location = location;
            Name = name;
            Sku = sku;
            StartTime = startTime;
            Status = status;
            Tags = tags;
            TransferType = transferType;
            Type = type;
        }
    }
}
