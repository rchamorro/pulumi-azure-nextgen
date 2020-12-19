// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.WindowsIoT.V20180216Preview
{
    /// <summary>
    /// The description of the Windows IoT Device Service.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:windowsiot/v20180216preview:Service")]
    public partial class Service : Pulumi.CustomResource
    {
        /// <summary>
        /// Windows IoT Device Service OEM AAD domain
        /// </summary>
        [Output("adminDomainName")]
        public Output<string?> AdminDomainName { get; private set; } = null!;

        /// <summary>
        /// Windows IoT Device Service ODM AAD domain
        /// </summary>
        [Output("billingDomainName")]
        public Output<string> BillingDomainName { get; private set; } = null!;

        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The Azure Region where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Windows IoT Device Service notes.
        /// </summary>
        [Output("notes")]
        public Output<string?> Notes { get; private set; } = null!;

        /// <summary>
        /// Windows IoT Device Service device allocation,
        /// </summary>
        [Output("quantity")]
        public Output<int?> Quantity { get; private set; } = null!;

        /// <summary>
        /// Windows IoT Device Service start date,
        /// </summary>
        [Output("startDate")]
        public Output<string> StartDate { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:windowsiot/v20180216preview:Service", name, args ?? new ServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:windowsiot/v20180216preview:Service", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:windowsiot/latest:Service"},
                    new Pulumi.Alias { Type = "azure-nextgen:windowsiot/v20190601:Service"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Service(name, id, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Windows IoT Device Service OEM AAD domain
        /// </summary>
        [Input("adminDomainName")]
        public Input<string>? AdminDomainName { get; set; }

        /// <summary>
        /// The name of the Windows IoT Device Service.
        /// </summary>
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The Azure Region where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Windows IoT Device Service notes.
        /// </summary>
        [Input("notes")]
        public Input<string>? Notes { get; set; }

        /// <summary>
        /// Windows IoT Device Service device allocation,
        /// </summary>
        [Input("quantity")]
        public Input<int>? Quantity { get; set; }

        /// <summary>
        /// The name of the resource group that contains the Windows IoT Device Service.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ServiceArgs()
        {
        }
    }
}
