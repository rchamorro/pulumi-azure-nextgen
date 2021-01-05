// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20170501
{
    /// <summary>
    /// Class representing a Traffic Manager endpoint.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:network/v20170501:Endpoint")]
    public partial class Endpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the location of the external or nested endpoints when using the ‘Performance’ traffic routing method.
        /// </summary>
        [Output("endpointLocation")]
        public Output<string?> EndpointLocation { get; private set; } = null!;

        /// <summary>
        /// The monitoring status of the endpoint.
        /// </summary>
        [Output("endpointMonitorStatus")]
        public Output<string?> EndpointMonitorStatus { get; private set; } = null!;

        /// <summary>
        /// The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method.
        /// </summary>
        [Output("endpointStatus")]
        public Output<string?> EndpointStatus { get; private set; } = null!;

        /// <summary>
        /// The list of countries/regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values.
        /// </summary>
        [Output("geoMapping")]
        public Output<ImmutableArray<string>> GeoMapping { get; private set; } = null!;

        /// <summary>
        /// The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.
        /// </summary>
        [Output("minChildEndpoints")]
        public Output<double?> MinChildEndpoints { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The priority of this endpoint when using the ‘Priority’ traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value.
        /// </summary>
        [Output("priority")]
        public Output<double?> Priority { get; private set; } = null!;

        /// <summary>
        /// The fully-qualified DNS name of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint.
        /// </summary>
        [Output("target")]
        public Output<string?> Target { get; private set; } = null!;

        /// <summary>
        /// The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.
        /// </summary>
        [Output("targetResourceId")]
        public Output<string?> TargetResourceId { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Network/trafficManagerProfiles.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000.
        /// </summary>
        [Output("weight")]
        public Output<double?> Weight { get; private set; } = null!;


        /// <summary>
        /// Create a Endpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Endpoint(string name, EndpointArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20170501:Endpoint", name, args ?? new EndpointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Endpoint(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:network/v20170501:Endpoint", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:network/latest:Endpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20151101:Endpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20170301:Endpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180201:Endpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180301:Endpoint"},
                    new Pulumi.Alias { Type = "azure-nextgen:network/v20180401:Endpoint"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Endpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Endpoint Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Endpoint(name, id, options);
        }
    }

    public sealed class EndpointArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the location of the external or nested endpoints when using the ‘Performance’ traffic routing method.
        /// </summary>
        [Input("endpointLocation")]
        public Input<string>? EndpointLocation { get; set; }

        /// <summary>
        /// The monitoring status of the endpoint.
        /// </summary>
        [Input("endpointMonitorStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20170501.EndpointMonitorStatus>? EndpointMonitorStatus { get; set; }

        /// <summary>
        /// The name of the Traffic Manager endpoint to be created or updated.
        /// </summary>
        [Input("endpointName", required: true)]
        public Input<string> EndpointName { get; set; } = null!;

        /// <summary>
        /// The status of the endpoint. If the endpoint is Enabled, it is probed for endpoint health and is included in the traffic routing method.
        /// </summary>
        [Input("endpointStatus")]
        public InputUnion<string, Pulumi.AzureNextGen.Network.V20170501.EndpointStatus>? EndpointStatus { get; set; }

        /// <summary>
        /// The type of the Traffic Manager endpoint to be created or updated.
        /// </summary>
        [Input("endpointType", required: true)]
        public Input<string> EndpointType { get; set; } = null!;

        [Input("geoMapping")]
        private InputList<string>? _geoMapping;

        /// <summary>
        /// The list of countries/regions mapped to this endpoint when using the ‘Geographic’ traffic routing method. Please consult Traffic Manager Geographic documentation for a full list of accepted values.
        /// </summary>
        public InputList<string> GeoMapping
        {
            get => _geoMapping ?? (_geoMapping = new InputList<string>());
            set => _geoMapping = value;
        }

        /// <summary>
        /// The minimum number of endpoints that must be available in the child profile in order for the parent profile to be considered available. Only applicable to endpoint of type 'NestedEndpoints'.
        /// </summary>
        [Input("minChildEndpoints")]
        public Input<double>? MinChildEndpoints { get; set; }

        /// <summary>
        /// The priority of this endpoint when using the ‘Priority’ traffic routing method. Possible values are from 1 to 1000, lower values represent higher priority. This is an optional parameter.  If specified, it must be specified on all endpoints, and no two endpoints can share the same priority value.
        /// </summary>
        [Input("priority")]
        public Input<double>? Priority { get; set; }

        /// <summary>
        /// The name of the Traffic Manager profile.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group containing the Traffic Manager endpoint to be created or updated.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The fully-qualified DNS name of the endpoint. Traffic Manager returns this value in DNS responses to direct traffic to this endpoint.
        /// </summary>
        [Input("target")]
        public Input<string>? Target { get; set; }

        /// <summary>
        /// The Azure Resource URI of the of the endpoint. Not applicable to endpoints of type 'ExternalEndpoints'.
        /// </summary>
        [Input("targetResourceId")]
        public Input<string>? TargetResourceId { get; set; }

        /// <summary>
        /// The weight of this endpoint when using the 'Weighted' traffic routing method. Possible values are from 1 to 1000.
        /// </summary>
        [Input("weight")]
        public Input<double>? Weight { get; set; }

        public EndpointArgs()
        {
        }
    }
}
