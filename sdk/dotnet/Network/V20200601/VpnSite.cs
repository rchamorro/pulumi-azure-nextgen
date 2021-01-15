// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200601
{
    /// <summary>
    /// VpnSite Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20200601:VpnSite")]
    public partial class VpnSite : Pulumi.CustomResource
    {
        /// <summary>
        /// The AddressSpace that contains an array of IP address ranges.
        /// </summary>
        [Output("addressSpace")]
        public Output<Outputs.AddressSpaceResponse?> AddressSpace { get; private set; } = null!;

        /// <summary>
        /// The set of bgp properties.
        /// </summary>
        [Output("bgpProperties")]
        public Output<Outputs.BgpSettingsResponse?> BgpProperties { get; private set; } = null!;

        /// <summary>
        /// The device properties.
        /// </summary>
        [Output("deviceProperties")]
        public Output<Outputs.DevicePropertiesResponse?> DeviceProperties { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The ip-address for the vpn-site.
        /// </summary>
        [Output("ipAddress")]
        public Output<string?> IpAddress { get; private set; } = null!;

        /// <summary>
        /// IsSecuritySite flag.
        /// </summary>
        [Output("isSecuritySite")]
        public Output<bool?> IsSecuritySite { get; private set; } = null!;

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
        /// Office365 Policy.
        /// </summary>
        [Output("o365Policy")]
        public Output<Outputs.O365PolicyPropertiesResponse?> O365Policy { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the VPN site resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The key for vpn-site that can be used for connections.
        /// </summary>
        [Output("siteKey")]
        public Output<string?> SiteKey { get; private set; } = null!;

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
        /// The VirtualWAN to which the vpnSite belongs.
        /// </summary>
        [Output("virtualWan")]
        public Output<Outputs.SubResourceResponse?> VirtualWan { get; private set; } = null!;

        /// <summary>
        /// List of all vpn site links.
        /// </summary>
        [Output("vpnSiteLinks")]
        public Output<ImmutableArray<Outputs.VpnSiteLinkResponse>> VpnSiteLinks { get; private set; } = null!;


        /// <summary>
        /// Create a VpnSite resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpnSite(string name, VpnSiteArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200601:VpnSite", name, args ?? new VpnSiteArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VpnSite(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200601:VpnSite", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VpnSite"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:VpnSite"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VpnSite resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpnSite Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VpnSite(name, id, options);
        }
    }

    public sealed class VpnSiteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The AddressSpace that contains an array of IP address ranges.
        /// </summary>
        [Input("addressSpace")]
        public Input<Inputs.AddressSpaceArgs>? AddressSpace { get; set; }

        /// <summary>
        /// The set of bgp properties.
        /// </summary>
        [Input("bgpProperties")]
        public Input<Inputs.BgpSettingsArgs>? BgpProperties { get; set; }

        /// <summary>
        /// The device properties.
        /// </summary>
        [Input("deviceProperties")]
        public Input<Inputs.DevicePropertiesArgs>? DeviceProperties { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The ip-address for the vpn-site.
        /// </summary>
        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        /// <summary>
        /// IsSecuritySite flag.
        /// </summary>
        [Input("isSecuritySite")]
        public Input<bool>? IsSecuritySite { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// Office365 Policy.
        /// </summary>
        [Input("o365Policy")]
        public Input<Inputs.O365PolicyPropertiesArgs>? O365Policy { get; set; }

        /// <summary>
        /// The resource group name of the VpnSite.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The key for vpn-site that can be used for connections.
        /// </summary>
        [Input("siteKey")]
        public Input<string>? SiteKey { get; set; }

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
        /// The VirtualWAN to which the vpnSite belongs.
        /// </summary>
        [Input("virtualWan")]
        public Input<Inputs.SubResourceArgs>? VirtualWan { get; set; }

        [Input("vpnSiteLinks")]
        private InputList<Inputs.VpnSiteLinkArgs>? _vpnSiteLinks;

        /// <summary>
        /// List of all vpn site links.
        /// </summary>
        public InputList<Inputs.VpnSiteLinkArgs> VpnSiteLinks
        {
            get => _vpnSiteLinks ?? (_vpnSiteLinks = new InputList<Inputs.VpnSiteLinkArgs>());
            set => _vpnSiteLinks = value;
        }

        /// <summary>
        /// The name of the VpnSite being created or updated.
        /// </summary>
        [Input("vpnSiteName", required: true)]
        public Input<string> VpnSiteName { get; set; } = null!;

        public VpnSiteArgs()
        {
        }
    }
}
