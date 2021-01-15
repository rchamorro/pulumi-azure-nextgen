// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20150615
{
    /// <summary>
    /// A common class for general resource information
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20150615:VirtualNetworkGateway")]
    public partial class VirtualNetworkGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// Virtual network gateway's BGP speaker settings.
        /// </summary>
        [Output("bgpSettings")]
        public Output<Outputs.BgpSettingsResponse?> BgpSettings { get; private set; } = null!;

        /// <summary>
        /// Whether BGP is enabled for this virtual network gateway or not.
        /// </summary>
        [Output("enableBgp")]
        public Output<bool?> EnableBgp { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
        /// </summary>
        [Output("gatewayDefaultSite")]
        public Output<Outputs.SubResourceResponse?> GatewayDefaultSite { get; private set; } = null!;

        /// <summary>
        /// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
        /// </summary>
        [Output("gatewayType")]
        public Output<string?> GatewayType { get; private set; } = null!;

        /// <summary>
        /// IP configurations for virtual network gateway.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.VirtualNetworkGatewayIPConfigurationResponse>> IpConfigurations { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the VirtualNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the VirtualNetworkGateway resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.VirtualNetworkGatewaySkuResponse?> Sku { get; private set; } = null!;

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
        /// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
        /// </summary>
        [Output("vpnClientConfiguration")]
        public Output<Outputs.VpnClientConfigurationResponse?> VpnClientConfiguration { get; private set; } = null!;

        /// <summary>
        /// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
        /// </summary>
        [Output("vpnType")]
        public Output<string?> VpnType { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualNetworkGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualNetworkGateway(string name, VirtualNetworkGatewayArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20150615:VirtualNetworkGateway", name, args ?? new VirtualNetworkGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualNetworkGateway(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20150615:VirtualNetworkGateway", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160330:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160601:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VirtualNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:VirtualNetworkGateway"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualNetworkGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualNetworkGateway Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualNetworkGateway(name, id, options);
        }
    }

    public sealed class VirtualNetworkGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Virtual network gateway's BGP speaker settings.
        /// </summary>
        [Input("bgpSettings")]
        public Input<Inputs.BgpSettingsArgs>? BgpSettings { get; set; }

        /// <summary>
        /// Whether BGP is enabled for this virtual network gateway or not.
        /// </summary>
        [Input("enableBgp")]
        public Input<bool>? EnableBgp { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// The reference of the LocalNetworkGateway resource which represents local network site having default routes. Assign Null value in case of removing existing default site setting.
        /// </summary>
        [Input("gatewayDefaultSite")]
        public Input<Inputs.SubResourceArgs>? GatewayDefaultSite { get; set; }

        /// <summary>
        /// The type of this virtual network gateway. Possible values are: 'Vpn' and 'ExpressRoute'.
        /// </summary>
        [Input("gatewayType")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20150615.VirtualNetworkGatewayType>? GatewayType { get; set; }

        /// <summary>
        /// Resource Identifier.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipConfigurations")]
        private InputList<Inputs.VirtualNetworkGatewayIPConfigurationArgs>? _ipConfigurations;

        /// <summary>
        /// IP configurations for virtual network gateway.
        /// </summary>
        public InputList<Inputs.VirtualNetworkGatewayIPConfigurationArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.VirtualNetworkGatewayIPConfigurationArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The provisioning state of the VirtualNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource GUID property of the VirtualNetworkGateway resource.
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

        /// <summary>
        /// The reference of the VirtualNetworkGatewaySku resource which represents the SKU selected for Virtual network gateway.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.VirtualNetworkGatewaySkuArgs>? Sku { get; set; }

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
        /// The name of the virtual network gateway.
        /// </summary>
        [Input("virtualNetworkGatewayName", required: true)]
        public Input<string> VirtualNetworkGatewayName { get; set; } = null!;

        /// <summary>
        /// The reference of the VpnClientConfiguration resource which represents the P2S VpnClient configurations.
        /// </summary>
        [Input("vpnClientConfiguration")]
        public Input<Inputs.VpnClientConfigurationArgs>? VpnClientConfiguration { get; set; }

        /// <summary>
        /// The type of this virtual network gateway. Possible values are: 'PolicyBased' and 'RouteBased'.
        /// </summary>
        [Input("vpnType")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20150615.VpnType>? VpnType { get; set; }

        public VirtualNetworkGatewayArgs()
        {
        }
    }
}
