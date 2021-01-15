// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.Latest
{
    /// <summary>
    /// DSCP Configuration in a resource group.
    /// Latest API Version: 2020-08-01.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/latest:DscpConfiguration")]
    public partial class DscpConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// Associated Network Interfaces to the DSCP Configuration.
        /// </summary>
        [Output("associatedNetworkInterfaces")]
        public Output<ImmutableArray<Outputs.NetworkInterfaceResponse>> AssociatedNetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// Destination IP ranges.
        /// </summary>
        [Output("destinationIpRanges")]
        public Output<ImmutableArray<Outputs.QosIpRangeResponse>> DestinationIpRanges { get; private set; } = null!;

        /// <summary>
        /// Destination port ranges.
        /// </summary>
        [Output("destinationPortRanges")]
        public Output<ImmutableArray<Outputs.QosPortRangeResponse>> DestinationPortRanges { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// Resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// List of markings to be used in the configuration.
        /// </summary>
        [Output("markings")]
        public Output<ImmutableArray<int>> Markings { get; private set; } = null!;

        /// <summary>
        /// Resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// RNM supported protocol types.
        /// </summary>
        [Output("protocol")]
        public Output<string?> Protocol { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the DSCP Configuration resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Qos Collection ID generated by RNM.
        /// </summary>
        [Output("qosCollectionId")]
        public Output<string> QosCollectionId { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the DSCP Configuration resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// Source IP ranges.
        /// </summary>
        [Output("sourceIpRanges")]
        public Output<ImmutableArray<Outputs.QosIpRangeResponse>> SourceIpRanges { get; private set; } = null!;

        /// <summary>
        /// Sources port ranges.
        /// </summary>
        [Output("sourcePortRanges")]
        public Output<ImmutableArray<Outputs.QosPortRangeResponse>> SourcePortRanges { get; private set; } = null!;

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
        /// Create a DscpConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DscpConfiguration(string name, DscpConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/latest:DscpConfiguration", name, args ?? new DscpConfigurationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DscpConfiguration(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/latest:DscpConfiguration", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:DscpConfiguration"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:DscpConfiguration"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:DscpConfiguration"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DscpConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DscpConfiguration Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new DscpConfiguration(name, id, options);
        }
    }

    public sealed class DscpConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("destinationIpRanges")]
        private InputList<Inputs.QosIpRangeArgs>? _destinationIpRanges;

        /// <summary>
        /// Destination IP ranges.
        /// </summary>
        public InputList<Inputs.QosIpRangeArgs> DestinationIpRanges
        {
            get => _destinationIpRanges ?? (_destinationIpRanges = new InputList<Inputs.QosIpRangeArgs>());
            set => _destinationIpRanges = value;
        }

        [Input("destinationPortRanges")]
        private InputList<Inputs.QosPortRangeArgs>? _destinationPortRanges;

        /// <summary>
        /// Destination port ranges.
        /// </summary>
        public InputList<Inputs.QosPortRangeArgs> DestinationPortRanges
        {
            get => _destinationPortRanges ?? (_destinationPortRanges = new InputList<Inputs.QosPortRangeArgs>());
            set => _destinationPortRanges = value;
        }

        /// <summary>
        /// The name of the resource.
        /// </summary>
        [Input("dscpConfigurationName", required: true)]
        public Input<string> DscpConfigurationName { get; set; } = null!;

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

        [Input("markings")]
        private InputList<int>? _markings;

        /// <summary>
        /// List of markings to be used in the configuration.
        /// </summary>
        public InputList<int> Markings
        {
            get => _markings ?? (_markings = new InputList<int>());
            set => _markings = value;
        }

        /// <summary>
        /// RNM supported protocol types.
        /// </summary>
        [Input("protocol")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.Latest.ProtocolType>? Protocol { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("sourceIpRanges")]
        private InputList<Inputs.QosIpRangeArgs>? _sourceIpRanges;

        /// <summary>
        /// Source IP ranges.
        /// </summary>
        public InputList<Inputs.QosIpRangeArgs> SourceIpRanges
        {
            get => _sourceIpRanges ?? (_sourceIpRanges = new InputList<Inputs.QosIpRangeArgs>());
            set => _sourceIpRanges = value;
        }

        [Input("sourcePortRanges")]
        private InputList<Inputs.QosPortRangeArgs>? _sourcePortRanges;

        /// <summary>
        /// Sources port ranges.
        /// </summary>
        public InputList<Inputs.QosPortRangeArgs> SourcePortRanges
        {
            get => _sourcePortRanges ?? (_sourcePortRanges = new InputList<Inputs.QosPortRangeArgs>());
            set => _sourcePortRanges = value;
        }

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

        public DscpConfigurationArgs()
        {
        }
    }
}
