// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Devices.V20170119
{
    /// <summary>
    /// The description of the IoT hub.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:devices/v20170119:IotHubResource")]
    public partial class IotHubResource : Pulumi.CustomResource
    {
        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The properties of an IoT hub.
        /// </summary>
        [Output("properties")]
        public Output<Outputs.IotHubPropertiesResponse> Properties { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the IoT hub. A resource group name uniquely identifies the resource group within the subscription.
        /// </summary>
        [Output("resourcegroup")]
        public Output<string> Resourcegroup { get; private set; } = null!;

        /// <summary>
        /// Information about the SKU of the IoT hub.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.IotHubSkuInfoResponse> Sku { get; private set; } = null!;

        /// <summary>
        /// The subscription identifier.
        /// </summary>
        [Output("subscriptionid")]
        public Output<string> Subscriptionid { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a IotHubResource resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IotHubResource(string name, IotHubResourceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:devices/v20170119:IotHubResource", name, args ?? new IotHubResourceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private IotHubResource(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:devices/v20170119:IotHubResource", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:devices/latest:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20160203:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20170701:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20180122:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20180401:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20181201preview:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20190322:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20190322preview:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20190701preview:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20191104:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200301:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200401:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200615:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200710preview:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200801:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200831:IotHubResource"},
                    new Pulumi.Alias { Type = "azure-nextgen:devices/v20200831preview:IotHubResource"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing IotHubResource resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IotHubResource Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new IotHubResource(name, id, options);
        }
    }

    public sealed class IotHubResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Etag field is *not* required. If it is provided in the response body, it must also be provided as a header per the normal ETag convention.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The properties of an IoT hub.
        /// </summary>
        [Input("properties")]
        public Input<Inputs.IotHubPropertiesArgs>? Properties { get; set; }

        /// <summary>
        /// The name of the resource group that contains the IoT hub.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the IoT hub to create or update.
        /// </summary>
        [Input("resourceName", required: true)]
        public Input<string> ResourceName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group that contains the IoT hub. A resource group name uniquely identifies the resource group within the subscription.
        /// </summary>
        [Input("resourcegroup", required: true)]
        public Input<string> Resourcegroup { get; set; } = null!;

        /// <summary>
        /// Information about the SKU of the IoT hub.
        /// </summary>
        [Input("sku", required: true)]
        public Input<Inputs.IotHubSkuInfoArgs> Sku { get; set; } = null!;

        /// <summary>
        /// The subscription identifier.
        /// </summary>
        [Input("subscriptionid", required: true)]
        public Input<string> Subscriptionid { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public IotHubResourceArgs()
        {
        }
    }
}
