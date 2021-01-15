// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190801
{
    /// <summary>
    /// VirtualRouter Resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20190801:VirtualRouter")]
    public partial class VirtualRouter : Pulumi.CustomResource
    {
        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The Gateway on which VirtualRouter is hosted.
        /// </summary>
        [Output("hostedGateway")]
        public Output<Outputs.SubResourceResponse?> HostedGateway { get; private set; } = null!;

        /// <summary>
        /// The Subnet on which VirtualRouter is hosted.
        /// </summary>
        [Output("hostedSubnet")]
        public Output<Outputs.SubResourceResponse?> HostedSubnet { get; private set; } = null!;

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
        /// List of references to VirtualRouterPeerings
        /// </summary>
        [Output("peerings")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> Peerings { get; private set; } = null!;

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
        /// VirtualRouter ASN.
        /// </summary>
        [Output("virtualRouterAsn")]
        public Output<double?> VirtualRouterAsn { get; private set; } = null!;

        /// <summary>
        /// VirtualRouter IPs
        /// </summary>
        [Output("virtualRouterIps")]
        public Output<ImmutableArray<string>> VirtualRouterIps { get; private set; } = null!;


        /// <summary>
        /// Create a VirtualRouter resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VirtualRouter(string name, VirtualRouterArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:VirtualRouter", name, args ?? new VirtualRouterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VirtualRouter(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:VirtualRouter", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:VirtualRouter"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:VirtualRouter"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VirtualRouter resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VirtualRouter Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VirtualRouter(name, id, options);
        }
    }

    public sealed class VirtualRouterArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Gateway on which VirtualRouter is hosted.
        /// </summary>
        [Input("hostedGateway")]
        public Input<Inputs.SubResourceArgs>? HostedGateway { get; set; }

        /// <summary>
        /// The Subnet on which VirtualRouter is hosted.
        /// </summary>
        [Input("hostedSubnet")]
        public Input<Inputs.SubResourceArgs>? HostedSubnet { get; set; }

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
        /// The name of the resource group.
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
        /// VirtualRouter ASN.
        /// </summary>
        [Input("virtualRouterAsn")]
        public Input<double>? VirtualRouterAsn { get; set; }

        [Input("virtualRouterIps")]
        private InputList<string>? _virtualRouterIps;

        /// <summary>
        /// VirtualRouter IPs
        /// </summary>
        public InputList<string> VirtualRouterIps
        {
            get => _virtualRouterIps ?? (_virtualRouterIps = new InputList<string>());
            set => _virtualRouterIps = value;
        }

        /// <summary>
        /// The name of the Virtual Router.
        /// </summary>
        [Input("virtualRouterName", required: true)]
        public Input<string> VirtualRouterName { get; set; } = null!;

        public VirtualRouterArgs()
        {
        }
    }
}
