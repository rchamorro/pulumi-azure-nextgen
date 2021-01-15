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
    /// NetworkSecurityGroup resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20190801:NetworkSecurityGroup")]
    public partial class NetworkSecurityGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The default security rules of network security group.
        /// </summary>
        [Output("defaultSecurityRules")]
        public Output<ImmutableArray<Outputs.SecurityRuleResponse>> DefaultSecurityRules { get; private set; } = null!;

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string?> Etag { get; private set; } = null!;

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
        /// A collection of references to network interfaces.
        /// </summary>
        [Output("networkInterfaces")]
        public Output<ImmutableArray<Outputs.NetworkInterfaceResponse>> NetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// The provisioning state of the network security group resource.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The resource GUID property of the network security group resource.
        /// </summary>
        [Output("resourceGuid")]
        public Output<string?> ResourceGuid { get; private set; } = null!;

        /// <summary>
        /// A collection of security rules of the network security group.
        /// </summary>
        [Output("securityRules")]
        public Output<ImmutableArray<Outputs.SecurityRuleResponse>> SecurityRules { get; private set; } = null!;

        /// <summary>
        /// A collection of references to subnets.
        /// </summary>
        [Output("subnets")]
        public Output<ImmutableArray<Outputs.SubnetResponse>> Subnets { get; private set; } = null!;

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
        /// Create a NetworkSecurityGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkSecurityGroup(string name, NetworkSecurityGroupArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:NetworkSecurityGroup", name, args ?? new NetworkSecurityGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkSecurityGroup(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20190801:NetworkSecurityGroup", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150501preview:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150615:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160330:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160601:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181101:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:NetworkSecurityGroup"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200801:NetworkSecurityGroup"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkSecurityGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkSecurityGroup Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new NetworkSecurityGroup(name, id, options);
        }
    }

    public sealed class NetworkSecurityGroupArgs : Pulumi.ResourceArgs
    {
        [Input("defaultSecurityRules")]
        private InputList<Inputs.SecurityRuleArgs>? _defaultSecurityRules;

        /// <summary>
        /// The default security rules of network security group.
        /// </summary>
        public InputList<Inputs.SecurityRuleArgs> DefaultSecurityRules
        {
            get => _defaultSecurityRules ?? (_defaultSecurityRules = new InputList<Inputs.SecurityRuleArgs>());
            set => _defaultSecurityRules = value;
        }

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
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the network security group.
        /// </summary>
        [Input("networkSecurityGroupName", required: true)]
        public Input<string> NetworkSecurityGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The resource GUID property of the network security group resource.
        /// </summary>
        [Input("resourceGuid")]
        public Input<string>? ResourceGuid { get; set; }

        [Input("securityRules")]
        private InputList<Inputs.SecurityRuleArgs>? _securityRules;

        /// <summary>
        /// A collection of security rules of the network security group.
        /// </summary>
        public InputList<Inputs.SecurityRuleArgs> SecurityRules
        {
            get => _securityRules ?? (_securityRules = new InputList<Inputs.SecurityRuleArgs>());
            set => _securityRules = value;
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

        public NetworkSecurityGroupArgs()
        {
        }
    }
}
