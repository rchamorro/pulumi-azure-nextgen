// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20180601
{
    /// <summary>
    /// Peering in an ExpressRoute Cross Connection resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20180601:ExpressRouteCrossConnectionPeering")]
    public partial class ExpressRouteCrossConnectionPeering : Pulumi.CustomResource
    {
        /// <summary>
        /// The Azure ASN.
        /// </summary>
        [Output("azureASN")]
        public Output<int> AzureASN { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        [Output("gatewayManagerEtag")]
        public Output<string?> GatewayManagerEtag { get; private set; } = null!;

        /// <summary>
        /// The IPv6 peering configuration.
        /// </summary>
        [Output("ipv6PeeringConfig")]
        public Output<Outputs.Ipv6ExpressRouteCircuitPeeringConfigResponse?> Ipv6PeeringConfig { get; private set; } = null!;

        /// <summary>
        /// Gets whether the provider or the customer last modified the peering.
        /// </summary>
        [Output("lastModifiedBy")]
        public Output<string?> LastModifiedBy { get; private set; } = null!;

        /// <summary>
        /// The Microsoft peering configuration.
        /// </summary>
        [Output("microsoftPeeringConfig")]
        public Output<Outputs.ExpressRouteCircuitPeeringConfigResponse?> MicrosoftPeeringConfig { get; private set; } = null!;

        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// The peer ASN.
        /// </summary>
        [Output("peerASN")]
        public Output<double?> PeerASN { get; private set; } = null!;

        /// <summary>
        /// The peering type.
        /// </summary>
        [Output("peeringType")]
        public Output<string?> PeeringType { get; private set; } = null!;

        /// <summary>
        /// The primary port.
        /// </summary>
        [Output("primaryAzurePort")]
        public Output<string> PrimaryAzurePort { get; private set; } = null!;

        /// <summary>
        /// The primary address prefix.
        /// </summary>
        [Output("primaryPeerAddressPrefix")]
        public Output<string?> PrimaryPeerAddressPrefix { get; private set; } = null!;

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The secondary port.
        /// </summary>
        [Output("secondaryAzurePort")]
        public Output<string> SecondaryAzurePort { get; private set; } = null!;

        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        [Output("secondaryPeerAddressPrefix")]
        public Output<string?> SecondaryPeerAddressPrefix { get; private set; } = null!;

        /// <summary>
        /// The shared key.
        /// </summary>
        [Output("sharedKey")]
        public Output<string?> SharedKey { get; private set; } = null!;

        /// <summary>
        /// The peering state.
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// The VLAN ID.
        /// </summary>
        [Output("vlanId")]
        public Output<int?> VlanId { get; private set; } = null!;


        /// <summary>
        /// Create a ExpressRouteCrossConnectionPeering resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExpressRouteCrossConnectionPeering(string name, ExpressRouteCrossConnectionPeeringArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180601:ExpressRouteCrossConnectionPeering", name, args ?? new ExpressRouteCrossConnectionPeeringArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExpressRouteCrossConnectionPeering(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20180601:ExpressRouteCrossConnectionPeering", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:ExpressRouteCrossConnectionPeering"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:ExpressRouteCrossConnectionPeering"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ExpressRouteCrossConnectionPeering resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExpressRouteCrossConnectionPeering Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ExpressRouteCrossConnectionPeering(name, id, options);
        }
    }

    public sealed class ExpressRouteCrossConnectionPeeringArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the ExpressRouteCrossConnection.
        /// </summary>
        [Input("crossConnectionName", required: true)]
        public Input<string> CrossConnectionName { get; set; } = null!;

        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        [Input("gatewayManagerEtag")]
        public Input<string>? GatewayManagerEtag { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The IPv6 peering configuration.
        /// </summary>
        [Input("ipv6PeeringConfig")]
        public Input<Inputs.Ipv6ExpressRouteCircuitPeeringConfigArgs>? Ipv6PeeringConfig { get; set; }

        /// <summary>
        /// Gets whether the provider or the customer last modified the peering.
        /// </summary>
        [Input("lastModifiedBy")]
        public Input<string>? LastModifiedBy { get; set; }

        /// <summary>
        /// The Microsoft peering configuration.
        /// </summary>
        [Input("microsoftPeeringConfig")]
        public Input<Inputs.ExpressRouteCircuitPeeringConfigArgs>? MicrosoftPeeringConfig { get; set; }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The peer ASN.
        /// </summary>
        [Input("peerASN")]
        public Input<double>? PeerASN { get; set; }

        /// <summary>
        /// The name of the peering.
        /// </summary>
        [Input("peeringName", required: true)]
        public Input<string> PeeringName { get; set; } = null!;

        /// <summary>
        /// The peering type.
        /// </summary>
        [Input("peeringType")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20180601.ExpressRoutePeeringType>? PeeringType { get; set; }

        /// <summary>
        /// The primary address prefix.
        /// </summary>
        [Input("primaryPeerAddressPrefix")]
        public Input<string>? PrimaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The secondary address prefix.
        /// </summary>
        [Input("secondaryPeerAddressPrefix")]
        public Input<string>? SecondaryPeerAddressPrefix { get; set; }

        /// <summary>
        /// The shared key.
        /// </summary>
        [Input("sharedKey")]
        public Input<string>? SharedKey { get; set; }

        /// <summary>
        /// The peering state.
        /// </summary>
        [Input("state")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20180601.ExpressRoutePeeringState>? State { get; set; }

        /// <summary>
        /// The VLAN ID.
        /// </summary>
        [Input("vlanId")]
        public Input<int>? VlanId { get; set; }

        public ExpressRouteCrossConnectionPeeringArgs()
        {
        }
    }
}
