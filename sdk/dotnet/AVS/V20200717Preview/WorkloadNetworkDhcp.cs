// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AVS.V20200717Preview
{
    /// <summary>
    /// NSX DHCP
    /// </summary>
    public partial class WorkloadNetworkDhcp : Pulumi.CustomResource
    {
        /// <summary>
        /// Type of DHCP: SERVER or RELAY.
        /// </summary>
        [Output("dhcpType")]
        public Output<string> DhcpType { get; private set; } = null!;

        /// <summary>
        /// Display name of the DHCP entity.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The provisioning state
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// NSX revision number.
        /// </summary>
        [Output("revision")]
        public Output<int?> Revision { get; private set; } = null!;

        /// <summary>
        /// NSX Segments consuming DHCP.
        /// </summary>
        [Output("segments")]
        public Output<ImmutableArray<string>> Segments { get; private set; } = null!;

        /// <summary>
        /// Resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a WorkloadNetworkDhcp resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WorkloadNetworkDhcp(string name, WorkloadNetworkDhcpArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:avs/v20200717preview:WorkloadNetworkDhcp", name, args ?? new WorkloadNetworkDhcpArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WorkloadNetworkDhcp(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:avs/v20200717preview:WorkloadNetworkDhcp", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WorkloadNetworkDhcp resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WorkloadNetworkDhcp Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new WorkloadNetworkDhcp(name, id, options);
        }
    }

    public sealed class WorkloadNetworkDhcpArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// NSX DHCP identifier. Generally the same as the DHCP display name
        /// </summary>
        [Input("dhcpId", required: true)]
        public Input<string> DhcpId { get; set; } = null!;

        /// <summary>
        /// Type of DHCP: SERVER or RELAY.
        /// </summary>
        [Input("dhcpType", required: true)]
        public Input<string> DhcpType { get; set; } = null!;

        /// <summary>
        /// Display name of the DHCP entity.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// Name of the private cloud
        /// </summary>
        [Input("privateCloudName", required: true)]
        public Input<string> PrivateCloudName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// NSX revision number.
        /// </summary>
        [Input("revision")]
        public Input<int>? Revision { get; set; }

        public WorkloadNetworkDhcpArgs()
        {
        }
    }
}
