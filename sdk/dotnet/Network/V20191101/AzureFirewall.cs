// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20191101
{
    /// <summary>
    /// Azure Firewall resource.
    /// </summary>
    public partial class AzureFirewall : Pulumi.CustomResource
    {
        /// <summary>
        /// The additional properties used to further config this azure firewall.
        /// </summary>
        [Output("additionalProperties")]
        public Output<ImmutableDictionary<string, string>?> AdditionalProperties { get; private set; } = null!;

        /// <summary>
        /// Collection of application rule collections used by Azure Firewall.
        /// </summary>
        [Output("applicationRuleCollections")]
        public Output<ImmutableArray<Outputs.AzureFirewallApplicationRuleCollectionResponse>> ApplicationRuleCollections { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The firewallPolicy associated with this azure firewall.
        /// </summary>
        [Output("firewallPolicy")]
        public Output<Outputs.SubResourceResponse?> FirewallPolicy { get; private set; } = null!;

        /// <summary>
        /// IP addresses associated with AzureFirewall.
        /// </summary>
        [Output("hubIpAddresses")]
        public Output<Outputs.HubIPAddressesResponse> HubIpAddresses { get; private set; } = null!;

        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.AzureFirewallIPConfigurationResponse>> IpConfigurations { get; private set; } = null!;

        /// <summary>
        /// IpGroups associated with AzureFirewall.
        /// </summary>
        [Output("ipGroups")]
        public Output<ImmutableArray<Outputs.AzureFirewallIpGroupsResponse>> IpGroups { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// IP configuration of the Azure Firewall used for management traffic.
        /// </summary>
        [Output("managementIpConfiguration")]
        public Output<Outputs.AzureFirewallIPConfigurationResponse?> ManagementIpConfiguration { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Collection of NAT rule collections used by Azure Firewall.
        /// </summary>
        [Output("natRuleCollections")]
        public Output<ImmutableArray<Outputs.AzureFirewallNatRuleCollectionResponse>> NatRuleCollections { get; private set; } = null!;

        /// <summary>
        /// Collection of network rule collections used by Azure Firewall.
        /// </summary>
        [Output("networkRuleCollections")]
        public Output<ImmutableArray<Outputs.AzureFirewallNetworkRuleCollectionResponse>> NetworkRuleCollections { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the Azure firewall resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The Azure Firewall Resource SKU.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.AzureFirewallSkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The operation mode for Threat Intelligence.
        /// </summary>
        [Output("threatIntelMode")]
        public Output<string?> ThreatIntelMode { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The virtualHub to which the firewall belongs.
        /// </summary>
        [Output("virtualHub")]
        public Output<Outputs.SubResourceResponse?> VirtualHub { get; private set; } = null!;

        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        [Output("zones")]
        public Output<ImmutableArray<string>> Zones { get; private set; } = null!;


        /// <summary>
        /// Create a AzureFirewall resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AzureFirewall(string name, AzureFirewallArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20191101:AzureFirewall", name, args ?? new AzureFirewallArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AzureFirewall(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20191101:AzureFirewall", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:AzureFirewall"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:AzureFirewall"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AzureFirewall resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AzureFirewall Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new AzureFirewall(name, id, options);
        }
    }

    public sealed class AzureFirewallArgs : Pulumi.ResourceArgs
    {
        [Input("additionalProperties")]
        private InputMap<string>? _additionalProperties;

        /// <summary>
        /// The additional properties used to further config this azure firewall.
        /// </summary>
        public InputMap<string> AdditionalProperties
        {
            get => _additionalProperties ?? (_additionalProperties = new InputMap<string>());
            set => _additionalProperties = value;
        }

        [Input("applicationRuleCollections")]
        private InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs>? _applicationRuleCollections;

        /// <summary>
        /// Collection of application rule collections used by Azure Firewall.
        /// </summary>
        public InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs> ApplicationRuleCollections
        {
            get => _applicationRuleCollections ?? (_applicationRuleCollections = new InputList<Inputs.AzureFirewallApplicationRuleCollectionArgs>());
            set => _applicationRuleCollections = value;
        }

        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("azureFirewallName", required: true)]
        public Input<string> AzureFirewallName { get; set; } = null!;

        /// <summary>
        /// The firewallPolicy associated with this azure firewall.
        /// </summary>
        [Input("firewallPolicy")]
        public Input<Inputs.SubResourceArgs>? FirewallPolicy { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipConfigurations")]
        private InputList<Inputs.AzureFirewallIPConfigurationArgs>? _ipConfigurations;

        /// <summary>
        /// IP configuration of the Azure Firewall resource.
        /// </summary>
        public InputList<Inputs.AzureFirewallIPConfigurationArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.AzureFirewallIPConfigurationArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// IP configuration of the Azure Firewall used for management traffic.
        /// </summary>
        [Input("managementIpConfiguration")]
        public Input<Inputs.AzureFirewallIPConfigurationArgs>? ManagementIpConfiguration { get; set; }

        [Input("natRuleCollections")]
        private InputList<Inputs.AzureFirewallNatRuleCollectionArgs>? _natRuleCollections;

        /// <summary>
        /// Collection of NAT rule collections used by Azure Firewall.
        /// </summary>
        public InputList<Inputs.AzureFirewallNatRuleCollectionArgs> NatRuleCollections
        {
            get => _natRuleCollections ?? (_natRuleCollections = new InputList<Inputs.AzureFirewallNatRuleCollectionArgs>());
            set => _natRuleCollections = value;
        }

        [Input("networkRuleCollections")]
        private InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs>? _networkRuleCollections;

        /// <summary>
        /// Collection of network rule collections used by Azure Firewall.
        /// </summary>
        public InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs> NetworkRuleCollections
        {
            get => _networkRuleCollections ?? (_networkRuleCollections = new InputList<Inputs.AzureFirewallNetworkRuleCollectionArgs>());
            set => _networkRuleCollections = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Azure Firewall Resource SKU.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.AzureFirewallSkuArgs>? Sku { get; set; }

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
        /// The operation mode for Threat Intelligence.
        /// </summary>
        [Input("threatIntelMode")]
        public Input<string>? ThreatIntelMode { get; set; }

        /// <summary>
        /// The virtualHub to which the firewall belongs.
        /// </summary>
        [Input("virtualHub")]
        public Input<Inputs.SubResourceArgs>? VirtualHub { get; set; }

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public AzureFirewallArgs()
        {
        }
    }
}
