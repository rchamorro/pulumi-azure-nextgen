// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBox.V20180101
{
    /// <summary>
    /// Job Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:databox/v20180101:Job")]
    public partial class Job : Pulumi.CustomResource
    {
        /// <summary>
        /// Reason for cancellation.
        /// </summary>
        [Output("cancellationReason")]
        public Output<string> CancellationReason { get; private set; } = null!;

        /// <summary>
        /// Details of a job run. This field will only be sent for expand details filter.
        /// </summary>
        [Output("details")]
        public Output<object?> Details { get; private set; } = null!;

        /// <summary>
        /// Top level error for the job.
        /// </summary>
        [Output("error")]
        public Output<Outputs.ErrorResponse> Error { get; private set; } = null!;

        /// <summary>
        /// Describes whether the job is cancellable or not.
        /// </summary>
        [Output("isCancellable")]
        public Output<bool> IsCancellable { get; private set; } = null!;

        /// <summary>
        /// Describes whether the job is deletable or not.
        /// </summary>
        [Output("isDeletable")]
        public Output<bool> IsDeletable { get; private set; } = null!;

        /// <summary>
        /// Describes whether the shipping address is editable or not.
        /// </summary>
        [Output("isShippingAddressEditable")]
        public Output<bool> IsShippingAddressEditable { get; private set; } = null!;

        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on update the request will succeed.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Name of the object.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The sku type.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse> Sku { get; private set; } = null!;

        /// <summary>
        /// Time at which the job was started in UTC ISO 8601 format.
        /// </summary>
        [Output("startTime")]
        public Output<string> StartTime { get; private set; } = null!;

        /// <summary>
        /// Name of the stage which is in progress.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Type of the object.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Job resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Job(string name, JobArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:databox/v20180101:Job", name, args ?? new JobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Job(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:databox/v20180101:Job", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:databox/latest:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:databox/v20190901:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:databox/v20200401:Job"},
                    new Pulumi.Alias { Type = "azure-nextgen:databox/v20201101:Job"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Job resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Job Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Job(name, id, options);
        }
    }

    public sealed class JobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Details of a job run. This field will only be sent for expand details filter.
        /// </summary>
        [Input("details")]
        public Input<object>? Details { get; set; }

        /// <summary>
        /// The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only
        /// </summary>
        [Input("jobName", required: true)]
        public Input<string> JobName { get; set; } = null!;

        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on update the request will succeed.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The Resource Group Name
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The sku type.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.SkuArgs> Sku { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public JobArgs()
        {
        }
    }
}
