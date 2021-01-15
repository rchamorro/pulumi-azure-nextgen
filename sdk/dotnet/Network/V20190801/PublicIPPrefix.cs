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
    /// Public IP prefix resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20190801:PublicIPPrefix")]
    public partial class PublicIPPrefix : Pulumi.CustomResource
    {
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

        /// <summary>
        /// The allocated Prefix.
        /// </summary>
        [Output("ipPrefix")]
        public Output<string?> IpPrefix { get; private set; } = null!;

        /// <summary>
        /// The list of tags associated with the public IP prefix.
        /// </summary>
        [Output("ipTags")]
        public Output<ImmutableArray<Outputs.IpTagResponse>> IpTags { get; private set; } = null!;

        /// <summary>
        /// The reference to load balancer frontend IP configuration associated with the public IP prefix.
        /// </summary>
        [Output("loadBalancerFrontendIpConfiguration")]
        public Output<Outputs.SubResourceResponse> LoadBalancerFrontendIpConfiguration { get; private set; } = null!;

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
        /// The Length of the Public IP Prefix.
        /// </summary>
        [Output("prefixLength")]
        public Output<int?> PrefixLength { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the public IP prefix resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The public IP address version.
        /// </summary>
        [Output("publicIPAddressVersion")]
        public Output<string?> PublicIPAddressVersion { get; private set; } = null!;

        /// <summary>
        /// The list of all referenced PublicIPAddresses.
        /// </summary>
        [Output("publicIPAddresses")]
        public Output<ImmutableArray<Outputs.ReferencedPublicIpAddressResponse>> PublicIPAddresses { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the public IP prefix resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// The public IP prefix SKU.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.PublicIPPrefixSkuResponse?> Sku { get; private set; } = null!;

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
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        [Output("zones")]
        public Output<ImmutableArray<string>> Zones { get; private set; } = null!;


        /// <summary>
        /// Create a PublicIPPrefix resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PublicIPPrefix(string name, PublicIPPrefixArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:PublicIPPrefix", name, args ?? new PublicIPPrefixArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PublicIPPrefix(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:PublicIPPrefix", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:PublicIPPrefix"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:PublicIPPrefix"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PublicIPPrefix resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PublicIPPrefix Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PublicIPPrefix(name, id, options);
        }
    }

    public sealed class PublicIPPrefixArgs : Pulumi.ResourceArgs
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
        /// The allocated Prefix.
        /// </summary>
        [Input("ipPrefix")]
        public Input<string>? IpPrefix { get; set; }

        [Input("ipTags")]
        private InputList<Inputs.IpTagArgs>? _ipTags;

        /// <summary>
        /// The list of tags associated with the public IP prefix.
        /// </summary>
        public InputList<Inputs.IpTagArgs> IpTags
        {
            get => _ipTags ?? (_ipTags = new InputList<Inputs.IpTagArgs>());
            set => _ipTags = value;
        }

        /// <summary>
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The Length of the Public IP Prefix.
        /// </summary>
        [Input("prefixLength")]
        public Input<int>? PrefixLength { get; set; }

        /// <summary>
        /// The public IP address version.
        /// </summary>
        [Input("publicIPAddressVersion")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20190801.IPVersion>? PublicIPAddressVersion { get; set; }

        [Input("publicIPAddresses")]
        private InputList<Inputs.ReferencedPublicIpAddressArgs>? _publicIPAddresses;

        /// <summary>
        /// The list of all referenced PublicIPAddresses.
        /// </summary>
        public InputList<Inputs.ReferencedPublicIpAddressArgs> PublicIPAddresses
        {
            get => _publicIPAddresses ?? (_publicIPAddresses = new InputList<Inputs.ReferencedPublicIpAddressArgs>());
            set => _publicIPAddresses = value;
        }

        /// <summary>
        /// The name of the public IP prefix.
        /// </summary>
        [Input("publicIpPrefixName", required: true)]
        public Input<string> PublicIpPrefixName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource GUID property of the public IP prefix resource.
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

        /// <summary>
        /// The public IP prefix SKU.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.PublicIPPrefixSkuArgs>? Sku { get; set; }

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

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public PublicIPPrefixArgs()
        {
        }
    }
}
