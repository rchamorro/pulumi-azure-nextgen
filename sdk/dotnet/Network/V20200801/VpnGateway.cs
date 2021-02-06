// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200801
{
    /// <summary>
    /// VpnGateway Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20200801:VpnGateway")]
    public partial class VpnGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [Output("bgpSettings")]
        public Output<Outputs.BgpSettingsResponse?> BgpSettings { get; private set; } = null!;

        /// <summary>
        /// List of all vpn connections to the gateway.
        /// </summary>
        [Output("connections")]
        public Output<ImmutableArray<Outputs.VpnConnectionResponse>> Connections { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// List of all IPs configured on the gateway.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.VpnGatewayIpConfigurationResponse>> IpConfigurations { get; private set; } = null!;

        /// <summary>
        /// Enable Routing Preference property for the Public IP Interface of the VpnGateway.
        /// </summary>
        [Output("isRoutingPreferenceInternet")]
        public Output<bool?> IsRoutingPreferenceInternet { get; private set; } = null!;

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
        /// List of all the nat Rules associated with the gateway.
        /// </summary>
        [Output("natRules")]
        public Output<ImmutableArray<Outputs.VpnGatewayNatRuleResponse>> NatRules { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the VPN gateway resource.
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
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        [Output("virtualHub")]
        public Output<Outputs.SubResourceResponse?> VirtualHub { get; private set; } = null!;

        /// <summary>
        /// The scale unit for this vpn gateway.
        /// </summary>
        [Output("vpnGatewayScaleUnit")]
        public Output<int?> VpnGatewayScaleUnit { get; private set; } = null!;


        /// <summary>
        /// Create a VpnGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpnGateway(string name, VpnGatewayArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200801:VpnGateway", name, args ?? new VpnGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpnGateway(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200801:VpnGateway", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:VpnGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VpnGateway"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VpnGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpnGateway Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VpnGateway(name, id, options);
        }
    }

    public sealed class VpnGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [Input("bgpSettings")]
        public Input<Inputs.BgpSettingsArgs>? BgpSettings { get; set; }

        [Input("connections")]
        private InputList<Inputs.VpnConnectionArgs>? _connections;

        /// <summary>
        /// List of all vpn connections to the gateway.
        /// </summary>
        public InputList<Inputs.VpnConnectionArgs> Connections
        {
            get => _connections ?? (_connections = new InputList<Inputs.VpnConnectionArgs>());
            set => _connections = value;
        }

        /// <summary>
        /// The name of the gateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public Input<string> GatewayName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Enable Routing Preference property for the Public IP Interface of the VpnGateway.
        /// </summary>
        [Input("isRoutingPreferenceInternet")]
        public Input<bool>? IsRoutingPreferenceInternet { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("natRules")]
        private InputList<Inputs.VpnGatewayNatRuleArgs>? _natRules;

        /// <summary>
        /// List of all the nat Rules associated with the gateway.
        /// </summary>
        public InputList<Inputs.VpnGatewayNatRuleArgs> NatRules
        {
            get => _natRules ?? (_natRules = new InputList<Inputs.VpnGatewayNatRuleArgs>());
            set => _natRules = value;
        }

        /// <summary>
        /// The resource group name of the VpnGateway.
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
        /// The VirtualHub to which the gateway belongs.
        /// </summary>
        [Input("virtualHub")]
        public Input<Inputs.SubResourceArgs>? VirtualHub { get; set; }

        /// <summary>
        /// The scale unit for this vpn gateway.
        /// </summary>
        [Input("vpnGatewayScaleUnit")]
        public Input<int>? VpnGatewayScaleUnit { get; set; }

        public VpnGatewayArgs()
        {
        }
    }
}
