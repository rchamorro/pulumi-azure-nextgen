// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DeploymentManager.V20180901Preview
{
    /// <summary>
    /// Represents the response of a service unit resource.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:deploymentmanager/v20180901preview:ServiceUnit")]
    public partial class ServiceUnit : Pulumi.CustomResource
    {
        /// <summary>
        /// The artifacts for the service unit.
        /// </summary>
        [Output("artifacts")]
        public Output<Outputs.ServiceUnitArtifactsResponse?> Artifacts { get; private set; } = null!;

        /// <summary>
        /// Describes the type of ARM deployment to be performed on the resource.
        /// </summary>
        [Output("deploymentMode")]
        public Output<string> DeploymentMode { get; private set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the resource
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The Azure Resource Group to which the resources in the service unit belong to or should be deployed to.
        /// </summary>
        [Output("targetResourceGroup")]
        public Output<string> TargetResourceGroup { get; private set; } = null!;

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a ServiceUnit resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServiceUnit(string name, ServiceUnitArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:deploymentmanager/v20180901preview:ServiceUnit", name, args ?? new ServiceUnitArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ServiceUnit(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:deploymentmanager/v20180901preview:ServiceUnit", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:deploymentmanager/v20191101preview:ServiceUnit"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServiceUnit resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServiceUnit Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new ServiceUnit(name, id, options);
        }
    }

    public sealed class ServiceUnitArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The artifacts for the service unit.
        /// </summary>
        [Input("artifacts")]
        public Input<Inputs.ServiceUnitArtifactsArgs>? Artifacts { get; set; }

        /// <summary>
        /// Describes the type of ARM deployment to be performed on the resource.
        /// </summary>
        [Input("deploymentMode", required: true)]
        public Input<Pulumi.AzureNextGen.DeploymentManager.V20180901Preview.DeploymentMode> DeploymentMode { get; set; } = null!;

        /// <summary>
        /// The geo-location where the resource lives
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the service resource.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// The name of the service topology .
        /// </summary>
        [Input("serviceTopologyName", required: true)]
        public Input<string> ServiceTopologyName { get; set; } = null!;

        /// <summary>
        /// The name of the service unit resource.
        /// </summary>
        [Input("serviceUnitName", required: true)]
        public Input<string> ServiceUnitName { get; set; } = null!;

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
        /// The Azure Resource Group to which the resources in the service unit belong to or should be deployed to.
        /// </summary>
        [Input("targetResourceGroup", required: true)]
        public Input<string> TargetResourceGroup { get; set; } = null!;

        public ServiceUnitArgs()
        {
        }
    }
}
