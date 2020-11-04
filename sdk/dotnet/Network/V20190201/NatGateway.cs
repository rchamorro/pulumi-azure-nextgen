// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20190201
{
    /// <summary>
    /// Nat Gateway resource.
    /// </summary>
    public partial class NatGateway : Pulumi.CustomResource
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The idle timeout of the nat gateway.
        /// </summary>
        [Output("idleTimeoutInMinutes")]
        public Output<int?> IdleTimeoutInMinutes { get; private set; } = null!;

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
        /// The provisioning state of the NatGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// An array of public ip addresses associated with the nat gateway resource.
        /// </summary>
        [Output("publicIpAddresses")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> PublicIpAddresses { get; private set; } = null!;

        /// <summary>
        /// An array of public ip prefixes associated with the nat gateway resource.
        /// </summary>
        [Output("publicIpPrefixes")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> PublicIpPrefixes { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the nat gateway resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// The nat gateway SKU.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.NatGatewaySkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// An array of references to the subnets using this nat gateway resource.
        /// </summary>
        [Output("subnets")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> Subnets { get; private set; } = null!;

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
        /// Create a NatGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NatGateway(string name, NatGatewayArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190201:NatGateway", name, args ?? new NatGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NatGateway(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190201:NatGateway", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:NatGateway"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:NatGateway"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NatGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NatGateway Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NatGateway(name, id, options);
        }
    }

    public sealed class NatGatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// The idle timeout of the nat gateway.
        /// </summary>
        [Input("idleTimeoutInMinutes")]
        public Input<int>? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the nat gateway.
        /// </summary>
        [Input("natGatewayName", required: true)]
        public Input<string> NatGatewayName { get; set; } = null!;

        /// <summary>
        /// The provisioning state of the NatGateway resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        [Input("publicIpAddresses")]
        private InputList<Inputs.SubResourceArgs>? _publicIpAddresses;

        /// <summary>
        /// An array of public ip addresses associated with the nat gateway resource.
        /// </summary>
        public InputList<Inputs.SubResourceArgs> PublicIpAddresses
        {
            get => _publicIpAddresses ?? (_publicIpAddresses = new InputList<Inputs.SubResourceArgs>());
            set => _publicIpAddresses = value;
        }

        [Input("publicIpPrefixes")]
        private InputList<Inputs.SubResourceArgs>? _publicIpPrefixes;

        /// <summary>
        /// An array of public ip prefixes associated with the nat gateway resource.
        /// </summary>
        public InputList<Inputs.SubResourceArgs> PublicIpPrefixes
        {
            get => _publicIpPrefixes ?? (_publicIpPrefixes = new InputList<Inputs.SubResourceArgs>());
            set => _publicIpPrefixes = value;
        }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource GUID property of the nat gateway resource.
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

        /// <summary>
        /// The nat gateway SKU.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.NatGatewaySkuArgs>? Sku { get; set; }

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

        public NatGatewayArgs()
        {
        }
    }
}
