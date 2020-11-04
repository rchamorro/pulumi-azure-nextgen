// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701
{
    /// <summary>
    /// Pool of backend IP addresses.
    /// </summary>
    public partial class LoadBalancerBackendAddressPool : Pulumi.CustomResource
    {
        /// <summary>
        /// An array of references to IP addresses defined in network interfaces.
        /// </summary>
        [Output("backendIPConfigurations")]
        public Output<ImmutableArray<Outputs.NetworkInterfaceIPConfigurationResponse>> BackendIPConfigurations { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// An array of backend addresses.
        /// </summary>
        [Output("loadBalancerBackendAddresses")]
        public Output<ImmutableArray<Outputs.LoadBalancerBackendAddressResponse>> LoadBalancerBackendAddresses { get; private set; } = null!;

        /// <summary>
        /// An array of references to load balancing rules that use this backend address pool.
        /// </summary>
        [Output("loadBalancingRules")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> LoadBalancingRules { get; private set; } = null!;

        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// A reference to an outbound rule that uses this backend address pool.
        /// </summary>
        [Output("outboundRule")]
        public Output<Outputs.SubResourceResponse> OutboundRule { get; private set; } = null!;

        /// <summary>
        /// An array of references to outbound rules that use this backend address pool.
        /// </summary>
        [Output("outboundRules")]
        public Output<ImmutableArray<Outputs.SubResourceResponse>> OutboundRules { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the backend address pool resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a LoadBalancerBackendAddressPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LoadBalancerBackendAddressPool(string name, LoadBalancerBackendAddressPoolArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200701:LoadBalancerBackendAddressPool", name, args ?? new LoadBalancerBackendAddressPoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LoadBalancerBackendAddressPool(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20200701:LoadBalancerBackendAddressPool", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:LoadBalancerBackendAddressPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:LoadBalancerBackendAddressPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:LoadBalancerBackendAddressPool"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:LoadBalancerBackendAddressPool"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LoadBalancerBackendAddressPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LoadBalancerBackendAddressPool Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new LoadBalancerBackendAddressPool(name, id, options);
        }
    }

    public sealed class LoadBalancerBackendAddressPoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the backend address pool.
        /// </summary>
        [Input("backendAddressPoolName", required: true)]
        public Input<string> BackendAddressPoolName { get; set; } = null!;

        /// <summary>
        /// Resource ID.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("loadBalancerBackendAddresses")]
        private InputList<Inputs.LoadBalancerBackendAddressArgs>? _loadBalancerBackendAddresses;

        /// <summary>
        /// An array of backend addresses.
        /// </summary>
        public InputList<Inputs.LoadBalancerBackendAddressArgs> LoadBalancerBackendAddresses
        {
            get => _loadBalancerBackendAddresses ?? (_loadBalancerBackendAddresses = new InputList<Inputs.LoadBalancerBackendAddressArgs>());
            set => _loadBalancerBackendAddresses = value;
        }

        /// <summary>
        /// The name of the load balancer.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public Input<string> LoadBalancerName { get; set; } = null!;

        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public LoadBalancerBackendAddressPoolArgs()
        {
        }
    }
}
