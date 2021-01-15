// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190901
{
    /// <summary>
    /// Private link service resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20190901:PrivateLinkService")]
    public partial class PrivateLinkService : Pulumi.CustomResource
    {
        /// <summary>
        /// The alias of the private link service.
        /// </summary>
        [Output("alias")]
        public Output<string> Alias { get; private set; } = null!;

        /// <summary>
        /// The auto-approval list of the private link service.
        /// </summary>
        [Output("autoApproval")]
        public Output<Outputs.PrivateLinkServicePropertiesResponseAutoApproval?> AutoApproval { get; private set; } = null!;

        /// <summary>
        /// Whether the private link service is enabled for proxy protocol or not.
        /// </summary>
        [Output("enableProxyProtocol")]
        public Output<bool?> EnableProxyProtocol { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The list of Fqdn.
        /// </summary>
        [Output("fqdns")]
        public Output<ImmutableArray<string>> Fqdns { get; private set; } = null!;

        /// <summary>
        /// An array of private link service IP configurations.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.PrivateLinkServiceIpConfigurationResponse>> IpConfigurations { get; private set; } = null!;

        /// <summary>
        /// An array of references to the load balancer IP configurations.
        /// </summary>
        [Output("loadBalancerFrontendIpConfigurations")]
        public Output<ImmutableArray<Outputs.FrontendIPConfigurationResponse>> LoadBalancerFrontendIpConfigurations { get; private set; } = null!;

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
        /// An array of references to the network interfaces created for this private link service.
        /// </summary>
        [Output("networkInterfaces")]
        public Output<ImmutableArray<Outputs.NetworkInterfaceResponse>> NetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// An array of list about connections to the private endpoint.
        /// </summary>
        [Output("privateEndpointConnections")]
        public Output<ImmutableArray<Outputs.PrivateEndpointConnectionResponse>> PrivateEndpointConnections { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the private link service resource.
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
        /// The visibility list of the private link service.
        /// </summary>
        [Output("visibility")]
        public Output<Outputs.PrivateLinkServicePropertiesResponseVisibility?> Visibility { get; private set; } = null!;


        /// <summary>
        /// Create a PrivateLinkService resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PrivateLinkService(string name, PrivateLinkServiceArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190901:PrivateLinkService", name, args ?? new PrivateLinkServiceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PrivateLinkService(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190901:PrivateLinkService", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:PrivateLinkService"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:PrivateLinkService"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PrivateLinkService resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PrivateLinkService Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PrivateLinkService(name, id, options);
        }
    }

    public sealed class PrivateLinkServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The auto-approval list of the private link service.
        /// </summary>
        [Input("autoApproval")]
        public Input<Inputs.PrivateLinkServicePropertiesAutoApprovalArgs>? AutoApproval { get; set; }

        /// <summary>
        /// Whether the private link service is enabled for proxy protocol or not.
        /// </summary>
        [Input("enableProxyProtocol")]
        public Input<bool>? EnableProxyProtocol { get; set; }

        [Input("fqdns")]
        private InputList<string>? _fqdns;

        /// <summary>
        /// The list of Fqdn.
        /// </summary>
        public InputList<string> Fqdns
        {
            get => _fqdns ?? (_fqdns = new InputList<string>());
            set => _fqdns = value;
        }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("ipConfigurations")]
        private InputList<Inputs.PrivateLinkServiceIpConfigurationArgs>? _ipConfigurations;

        /// <summary>
        /// An array of private link service IP configurations.
        /// </summary>
        public InputList<Inputs.PrivateLinkServiceIpConfigurationArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.PrivateLinkServiceIpConfigurationArgs>());
            set => _ipConfigurations = value;
        }

        [Input("loadBalancerFrontendIpConfigurations")]
        private InputList<Inputs.FrontendIPConfigurationArgs>? _loadBalancerFrontendIpConfigurations;

        /// <summary>
        /// An array of references to the load balancer IP configurations.
        /// </summary>
        public InputList<Inputs.FrontendIPConfigurationArgs> LoadBalancerFrontendIpConfigurations
        {
            get => _loadBalancerFrontendIpConfigurations ?? (_loadBalancerFrontendIpConfigurations = new InputList<Inputs.FrontendIPConfigurationArgs>());
            set => _loadBalancerFrontendIpConfigurations = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the private link service.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

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
        /// The visibility list of the private link service.
        /// </summary>
        [Input("visibility")]
        public Input<Inputs.PrivateLinkServicePropertiesVisibilityArgs>? Visibility { get; set; }

        public PrivateLinkServiceArgs()
        {
        }
    }
}
