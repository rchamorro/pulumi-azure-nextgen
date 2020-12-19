// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.Latest
{
    /// <summary>
    /// Hybrid Connection for an App Service app.
    /// Latest API Version: 2020-09-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:web/latest:WebAppRelayServiceConnectionSlot")]
    public partial class WebAppRelayServiceConnectionSlot : Pulumi.CustomResource
    {
        [Output("biztalkUri")]
        public Output<string?> BiztalkUri { get; private set; } = null!;

        [Output("entityConnectionString")]
        public Output<string?> EntityConnectionString { get; private set; } = null!;

        [Output("entityName")]
        public Output<string?> EntityName { get; private set; } = null!;

        [Output("hostname")]
        public Output<string?> Hostname { get; private set; } = null!;

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Output("kind")]
        public Output<string?> Kind { get; private set; } = null!;

        /// <summary>
        /// Resource Name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("port")]
        public Output<int?> Port { get; private set; } = null!;

        [Output("resourceConnectionString")]
        public Output<string?> ResourceConnectionString { get; private set; } = null!;

        [Output("resourceType")]
        public Output<string?> ResourceType { get; private set; } = null!;

        /// <summary>
        /// The system metadata relating to this resource.
        /// </summary>
        [Output("systemData")]
        public Output<Outputs.SystemDataResponse> SystemData { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WebAppRelayServiceConnectionSlot resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAppRelayServiceConnectionSlot(string name, WebAppRelayServiceConnectionSlotArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppRelayServiceConnectionSlot", name, args ?? new WebAppRelayServiceConnectionSlotArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebAppRelayServiceConnectionSlot(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:web/latest:WebAppRelayServiceConnectionSlot", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20150801:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20160801:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20180201:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20181101:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20190801:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200601:WebAppRelayServiceConnectionSlot"},
                    new Pulumi.Alias { Type = "azure-nextgen:web/v20200901:WebAppRelayServiceConnectionSlot"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebAppRelayServiceConnectionSlot resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAppRelayServiceConnectionSlot Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WebAppRelayServiceConnectionSlot(name, id, options);
        }
    }

    public sealed class WebAppRelayServiceConnectionSlotArgs : Pulumi.ResourceArgs
    {
        [Input("biztalkUri")]
        public Input<string>? BiztalkUri { get; set; }

        [Input("entityConnectionString")]
        public Input<string>? EntityConnectionString { get; set; }

        [Input("entityName", required: true)]
        public Input<string> EntityName { get; set; } = null!;

        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Name of the app.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("resourceConnectionString")]
        public Input<string>? ResourceConnectionString { get; set; }

        /// <summary>
        /// Name of the resource group to which the resource belongs.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        /// <summary>
        /// Name of the deployment slot. If a slot is not specified, the API will create or update a hybrid connection for the production slot.
        /// </summary>
        [Input("slot", required: true)]
        public Input<string> Slot { get; set; } = null!;

        public WebAppRelayServiceConnectionSlotArgs()
        {
        }
    }
}
