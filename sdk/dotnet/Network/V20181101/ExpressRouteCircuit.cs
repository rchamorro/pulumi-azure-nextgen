// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20181101
{
    /// <summary>
    /// ExpressRouteCircuit resource
    /// </summary>
    public partial class ExpressRouteCircuit : Pulumi.CustomResource
    {
        /// <summary>
        /// Allow classic operations
        /// </summary>
        [Output("allowClassicOperations")]
        public Output<bool?> AllowClassicOperations { get; private set; } = null!;

        /// <summary>
        /// Flag to enable Global Reach on the circuit.
        /// </summary>
        [Output("allowGlobalReach")]
        public Output<bool?> AllowGlobalReach { get; private set; } = null!;

        /// <summary>
        /// The list of authorizations.
        /// </summary>
        [Output("authorizations")]
        public Output<ImmutableArray<Outputs.ExpressRouteCircuitAuthorizationResponse>> Authorizations { get; private set; } = null!;

        /// <summary>
        /// The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [Output("bandwidthInGbps")]
        public Output<double?> BandwidthInGbps { get; private set; } = null!;

        /// <summary>
        /// The CircuitProvisioningState state of the resource.
        /// </summary>
        [Output("circuitProvisioningState")]
        public Output<string?> CircuitProvisioningState { get; private set; } = null!;

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        /// <summary>
        /// The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [Output("expressRoutePort")]
        public Output<Outputs.SubResourceResponse?> ExpressRoutePort { get; private set; } = null!;

        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        [Output("gatewayManagerEtag")]
        public Output<string?> GatewayManagerEtag { get; private set; } = null!;

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
        /// The list of peerings.
        /// </summary>
        [Output("peerings")]
        public Output<ImmutableArray<Outputs.ExpressRouteCircuitPeeringResponse>> Peerings { get; private set; } = null!;

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Output("provisioningState")]
        public Output<string?> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The ServiceKey.
        /// </summary>
        [Output("serviceKey")]
        public Output<string?> ServiceKey { get; private set; } = null!;

        /// <summary>
        /// The ServiceProviderNotes.
        /// </summary>
        [Output("serviceProviderNotes")]
        public Output<string?> ServiceProviderNotes { get; private set; } = null!;

        /// <summary>
        /// The ServiceProviderProperties.
        /// </summary>
        [Output("serviceProviderProperties")]
        public Output<Outputs.ExpressRouteCircuitServiceProviderPropertiesResponse?> ServiceProviderProperties { get; private set; } = null!;

        /// <summary>
        /// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
        /// </summary>
        [Output("serviceProviderProvisioningState")]
        public Output<string?> ServiceProviderProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The SKU.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.ExpressRouteCircuitSkuResponse?> Sku { get; private set; } = null!;

        /// <summary>
        /// The identifier of the circuit traffic. Outer tag for QinQ encapsulation.
        /// </summary>
        [Output("stag")]
        public Output<int> Stag { get; private set; } = null!;

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
        /// Create a ExpressRouteCircuit resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ExpressRouteCircuit(string name, ExpressRouteCircuitArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181101:ExpressRouteCircuit", name, args ?? new ExpressRouteCircuitArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ExpressRouteCircuit(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20181101:ExpressRouteCircuit", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150501preview:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20150615:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160330:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160601:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20160901:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20161201:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170601:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170801:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170901:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171001:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20171101:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180101:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180601:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180701:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180801:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181001:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20181201:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190201:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190401:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190601:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190701:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190801:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20190901:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191101:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20191201:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200301:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200401:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200501:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200601:ExpressRouteCircuit"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20200701:ExpressRouteCircuit"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ExpressRouteCircuit resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ExpressRouteCircuit Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ExpressRouteCircuit(name, id, options);
        }
    }

    public sealed class ExpressRouteCircuitArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Allow classic operations
        /// </summary>
        [Input("allowClassicOperations")]
        public Input<bool>? AllowClassicOperations { get; set; }

        /// <summary>
        /// Flag to enable Global Reach on the circuit.
        /// </summary>
        [Input("allowGlobalReach")]
        public Input<bool>? AllowGlobalReach { get; set; }

        [Input("authorizations")]
        private InputList<Inputs.ExpressRouteCircuitAuthorizationArgs>? _authorizations;

        /// <summary>
        /// The list of authorizations.
        /// </summary>
        public InputList<Inputs.ExpressRouteCircuitAuthorizationArgs> Authorizations
        {
            get => _authorizations ?? (_authorizations = new InputList<Inputs.ExpressRouteCircuitAuthorizationArgs>());
            set => _authorizations = value;
        }

        /// <summary>
        /// The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [Input("bandwidthInGbps")]
        public Input<double>? BandwidthInGbps { get; set; }

        /// <summary>
        /// The name of the circuit.
        /// </summary>
        [Input("circuitName", required: true)]
        public Input<string> CircuitName { get; set; } = null!;

        /// <summary>
        /// The CircuitProvisioningState state of the resource.
        /// </summary>
        [Input("circuitProvisioningState")]
        public Input<string>? CircuitProvisioningState { get; set; }

        /// <summary>
        /// The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [Input("expressRoutePort")]
        public Input<Inputs.SubResourceArgs>? ExpressRoutePort { get; set; }

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
        /// Resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("peerings")]
        private InputList<Inputs.ExpressRouteCircuitPeeringArgs>? _peerings;

        /// <summary>
        /// The list of peerings.
        /// </summary>
        public InputList<Inputs.ExpressRouteCircuitPeeringArgs> Peerings
        {
            get => _peerings ?? (_peerings = new InputList<Inputs.ExpressRouteCircuitPeeringArgs>());
            set => _peerings = value;
        }

        /// <summary>
        /// Gets the provisioning state of the public IP resource. Possible values are: 'Updating', 'Deleting', and 'Failed'.
        /// </summary>
        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The ServiceKey.
        /// </summary>
        [Input("serviceKey")]
        public Input<string>? ServiceKey { get; set; }

        /// <summary>
        /// The ServiceProviderNotes.
        /// </summary>
        [Input("serviceProviderNotes")]
        public Input<string>? ServiceProviderNotes { get; set; }

        /// <summary>
        /// The ServiceProviderProperties.
        /// </summary>
        [Input("serviceProviderProperties")]
        public Input<Inputs.ExpressRouteCircuitServiceProviderPropertiesArgs>? ServiceProviderProperties { get; set; }

        /// <summary>
        /// The ServiceProviderProvisioningState state of the resource. Possible values are 'NotProvisioned', 'Provisioning', 'Provisioned', and 'Deprovisioning'.
        /// </summary>
        [Input("serviceProviderProvisioningState")]
        public Input<string>? ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// The SKU.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.ExpressRouteCircuitSkuArgs>? Sku { get; set; }

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

        public ExpressRouteCircuitArgs()
        {
        }
    }
}
