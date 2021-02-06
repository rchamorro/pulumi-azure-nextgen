// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180401
{
    /// <summary>
    /// VirtualWAN Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20180401:VirtualWAN")]
    public partial class VirtualWAN : Pulumi.CustomResource
    {
        /// <summary>
        /// Vpn encryption to be disabled or not.
        /// </summary>
        [Output("disableVpnEncryption")]
        public Output<bool?> DisableVpnEncryption { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// List of VirtualHubs in the VirtualWAN.
        /// </summary>
        [Output("virtualHubs")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> VirtualHubs { get; private set; } = null!;

        [Output("vpnSites")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> VpnSites { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualWAN resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualWAN(string name, VirtualWANArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180401:VirtualWAN", name, args ?? new VirtualWANArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualWAN(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180401:VirtualWAN", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VirtualWAN"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:VirtualWAN"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualWAN resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualWAN Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualWAN(name, id, options);
        }
    }

    public sealed class VirtualWANArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Vpn encryption to be disabled or not.
        /// </summary>
        [Input("disableVpnEncryption")]
        public Input<bool>? DisableVpnEncryption { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The resource group name of the VirtualWan.
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

        /// <summary>
        /// The name of the VirtualWAN being created or updated.
        /// </summary>
        [Input("virtualWANName", required: true)]
        public Input<string> VirtualWANName { get; set; } = null!;

        public VirtualWANArgs()
        {
        }
    }
}
