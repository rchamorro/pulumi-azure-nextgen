// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20160330
{
    /// <summary>
    /// LoadBalancer resource
    /// </summary>
    public partial class LoadBalancer : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets or sets Pools of backend IP addresses
        /// </summary>
        [Output("backendAddressPools")]
        public Output<ImmutableArray<Outputs.BackendAddressPoolResponse>> BackendAddressPools { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// Gets or sets frontend IP addresses of the load balancer
        /// </summary>
        [Output("frontendIPConfigurations")]
        public Output<ImmutableArray<Outputs.FrontendIPConfigurationResponse>> FrontendIPConfigurations { get; private set; } = null!;

        /// <summary>
        /// Gets or sets inbound NAT pools
        /// </summary>
        [Output("inboundNatPools")]
        public Output<ImmutableArray<Outputs.InboundNatPoolResponse>> InboundNatPools { get; private set; } = null!;

        /// <summary>
        /// Gets or sets list of inbound rules
        /// </summary>
        [Output("inboundNatRules")]
        public Output<ImmutableArray<Outputs.InboundNatRuleResponse>> InboundNatRules { get; private set; } = null!;

        /// <summary>
        /// Gets or sets load balancing rules
        /// </summary>
        [Output("loadBalancingRules")]
        public Output<ImmutableArray<Outputs.LoadBalancingRuleResponse>> LoadBalancingRules { get; private set; } = null!;

        /// <summary>
        /// Resource location
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Resource name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Gets or sets outbound NAT rules
        /// </summary>
        [Output("outboundNatRules")]
        public Output<ImmutableArray<Outputs.OutboundNatRuleResponse>> OutboundNatRules { get; private set; } = null!;

        /// <summary>
        /// Gets or sets list of Load balancer probes
        /// </summary>
        [Output("probes")]
        public Output<ImmutableArray<Outputs.ProbeResponse>> Probes { get; private set; } = null!;

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Gets or sets resource GUID property of the Load balancer resource
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// Resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Resource type
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a LoadBalancer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadBalancer(string name, LoadBalancerArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20160330:LoadBalancer", name, args ?? new LoadBalancerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoadBalancer(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20160330:LoadBalancer", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150501preview:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150615:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160601:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:LoadBalancer"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:LoadBalancer"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoadBalancer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadBalancer Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LoadBalancer(name, id, options);
        }
    }

    public sealed class LoadBalancerArgs : Pulumi.ResourceArgs
    {
        [Input("backendAddressPools")]
        private InputList<Inputs.BackendAddressPoolArgs>? _backendAddressPools;

        /// <summary>
        /// Gets or sets Pools of backend IP addresses
        /// </summary>
        public InputList<Inputs.BackendAddressPoolArgs> BackendAddressPools
        {
            get => _backendAddressPools ?? (_backendAddressPools = new InputList<Inputs.BackendAddressPoolArgs>());
            set => _backendAddressPools = value;
        }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        [Input("frontendIPConfigurations")]
        private InputList<Inputs.FrontendIPConfigurationArgs>? _frontendIPConfigurations;

        /// <summary>
        /// Gets or sets frontend IP addresses of the load balancer
        /// </summary>
        public InputList<Inputs.FrontendIPConfigurationArgs> FrontendIPConfigurations
        {
            get => _frontendIPConfigurations ?? (_frontendIPConfigurations = new InputList<Inputs.FrontendIPConfigurationArgs>());
            set => _frontendIPConfigurations = value;
        }

        /// <summary>
        /// Resource Id
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("inboundNatPools")]
        private InputList<Inputs.InboundNatPoolArgs>? _inboundNatPools;

        /// <summary>
        /// Gets or sets inbound NAT pools
        /// </summary>
        public InputList<Inputs.InboundNatPoolArgs> InboundNatPools
        {
            get => _inboundNatPools ?? (_inboundNatPools = new InputList<Inputs.InboundNatPoolArgs>());
            set => _inboundNatPools = value;
        }

        [Input("inboundNatRules")]
        private InputList<Inputs.InboundNatRuleArgs>? _inboundNatRules;

        /// <summary>
        /// Gets or sets list of inbound rules
        /// </summary>
        public InputList<Inputs.InboundNatRuleArgs> InboundNatRules
        {
            get => _inboundNatRules ?? (_inboundNatRules = new InputList<Inputs.InboundNatRuleArgs>());
            set => _inboundNatRules = value;
        }

        /// <summary>
        /// The name of the loadBalancer.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public Input<string> LoadBalancerName { get; set; } = null!;

        [Input("loadBalancingRules")]
        private InputList<Inputs.LoadBalancingRuleArgs>? _loadBalancingRules;

        /// <summary>
        /// Gets or sets load balancing rules
        /// </summary>
        public InputList<Inputs.LoadBalancingRuleArgs> LoadBalancingRules
        {
            get => _loadBalancingRules ?? (_loadBalancingRules = new InputList<Inputs.LoadBalancingRuleArgs>());
            set => _loadBalancingRules = value;
        }

        /// <summary>
        /// Resource location
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("outboundNatRules")]
        private InputList<Inputs.OutboundNatRuleArgs>? _outboundNatRules;

        /// <summary>
        /// Gets or sets outbound NAT rules
        /// </summary>
        public InputList<Inputs.OutboundNatRuleArgs> OutboundNatRules
        {
            get => _outboundNatRules ?? (_outboundNatRules = new InputList<Inputs.OutboundNatRuleArgs>());
            set => _outboundNatRules = value;
        }

        [Input("probes")]
        private InputList<Inputs.ProbeArgs>? _probes;

        /// <summary>
        /// Gets or sets list of Load balancer probes
        /// </summary>
        public InputList<Inputs.ProbeArgs> Probes
        {
            get => _probes ?? (_probes = new InputList<Inputs.ProbeArgs>());
            set => _probes = value;
        }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Gets or sets resource GUID property of the Load balancer resource
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Resource tags
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public LoadBalancerArgs()
        {
        }
    }
}
