// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190601
{
    /// <summary>
    /// A common class for general resource information.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20190601:LocalNetworkGateway")]
    public partial class LocalNetworkGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [Output("bgpSettings")]
        public Output<Outputs.BgpSettingsResponse?> BgpSettings { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        [Output("gatewayIpAddress")]
        public Output<string?> GatewayIpAddress { get; private set; } = null!;

        /// <summary>
        /// Local network site address space.
        /// </summary>
        [Output("localNetworkAddressSpace")]
        public Output<Outputs.AddressSpaceResponse?> LocalNetworkAddressSpace { get; private set; } = null!;

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
        /// The provisioning state of the LocalNetworkGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the LocalNetworkGateway resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

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
        /// Create a LocalNetworkGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LocalNetworkGateway(string name, LocalNetworkGatewayArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190601:LocalNetworkGateway", name, args ?? new LocalNetworkGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LocalNetworkGateway(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190601:LocalNetworkGateway", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150615:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160330:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160601:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:LocalNetworkGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:LocalNetworkGateway"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LocalNetworkGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LocalNetworkGateway Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LocalNetworkGateway(name, id, options);
        }
    }

    public sealed class LocalNetworkGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Local network gateway's BGP speaker settings.
        /// </summary>
        [Input("bgpSettings")]
        public Input<Inputs.BgpSettingsArgs>? BgpSettings { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// IP address of local network gateway.
        /// </summary>
        [Input("gatewayIpAddress")]
        public Input<string>? GatewayIpAddress { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Local network site address space.
        /// </summary>
        [Input("localNetworkAddressSpace")]
        public Input<Inputs.AddressSpaceArgs>? LocalNetworkAddressSpace { get; set; }

        /// <summary>
        /// The name of the local network gateway.
        /// </summary>
        [Input("localNetworkGatewayName", required: true)]
        public Input<string> LocalNetworkGatewayName { get; set; } = null!;

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
        /// The resource GUID property of the LocalNetworkGateway resource.
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

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

        public LocalNetworkGatewayArgs()
        {
        }
    }
}
