// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.Latest
{
    /// <summary>
    /// The workflow type.
    /// </summary>
    public partial class Workflow : Pulumi.CustomResource
    {
        /// <summary>
        /// The access control configuration.
        /// </summary>
        [Output("accessControl")]
        public Output<Outputs.FlowAccessControlConfigurationResponse?> AccessControl { get; private set; } = null!;

        /// <summary>
        /// Gets the access endpoint.
        /// </summary>
        [Output("accessEndpoint")]
        public Output<string> AccessEndpoint { get; private set; } = null!;

        /// <summary>
        /// Gets the changed time.
        /// </summary>
        [Output("changedTime")]
        public Output<string> ChangedTime { get; private set; } = null!;

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [Output("createdTime")]
        public Output<string> CreatedTime { get; private set; } = null!;

        /// <summary>
        /// The definition.
        /// </summary>
        [Output("definition")]
        public Output<object?> Definition { get; private set; } = null!;

        /// <summary>
        /// The endpoints configuration.
        /// </summary>
        [Output("endpointsConfiguration")]
        public Output<Outputs.FlowEndpointsConfigurationResponse?> EndpointsConfiguration { get; private set; } = null!;

        /// <summary>
        /// The integration account.
        /// </summary>
        [Output("integrationAccount")]
        public Output<Outputs.ResourceReferenceResponse?> IntegrationAccount { get; private set; } = null!;

        /// <summary>
        /// The integration service environment.
        /// </summary>
        [Output("integrationServiceEnvironment")]
        public Output<Outputs.ResourceReferenceResponse?> IntegrationServiceEnvironment { get; private set; } = null!;

        /// <summary>
        /// The resource location.
        /// </summary>
        [Output("location")]
        public Output<string?> Location { get; private set; } = null!;

        /// <summary>
        /// Gets the resource name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The parameters.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, Outputs.WorkflowParameterResponse>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// Gets the provisioning state.
        /// </summary>
        [Output("provisioningState")]
        public Output<string> ProvisioningState { get; private set; } = null!;

        /// <summary>
        /// The sku.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.SkuResponse> Sku { get; private set; } = null!;

        /// <summary>
        /// The state.
        /// </summary>
        [Output("state")]
        public Output<string?> State { get; private set; } = null!;

        /// <summary>
        /// The resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// Gets the version.
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a Workflow resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Workflow(string name, WorkflowArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/latest:Workflow", name, args ?? new WorkflowArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Workflow(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:logic/latest:Workflow", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20150201preview:Workflow"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20160601:Workflow"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20180701preview:Workflow"},
                    new Pulumi.Alias { Type = "azure-nextgen:logic/v20190501:Workflow"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Workflow resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Workflow Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new Workflow(name, id, options);
        }
    }

    public sealed class WorkflowArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The access control configuration.
        /// </summary>
        [Input("accessControl")]
        public Input<Inputs.FlowAccessControlConfigurationArgs>? AccessControl { get; set; }

        /// <summary>
        /// The definition.
        /// </summary>
        [Input("definition")]
        public Input<object>? Definition { get; set; }

        /// <summary>
        /// The endpoints configuration.
        /// </summary>
        [Input("endpointsConfiguration")]
        public Input<Inputs.FlowEndpointsConfigurationArgs>? EndpointsConfiguration { get; set; }

        /// <summary>
        /// The integration account.
        /// </summary>
        [Input("integrationAccount")]
        public Input<Inputs.ResourceReferenceArgs>? IntegrationAccount { get; set; }

        /// <summary>
        /// The integration service environment.
        /// </summary>
        [Input("integrationServiceEnvironment")]
        public Input<Inputs.ResourceReferenceArgs>? IntegrationServiceEnvironment { get; set; }

        /// <summary>
        /// The resource location.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        [Input("parameters")]
        private InputMap<Inputs.WorkflowParameterArgs>? _parameters;

        /// <summary>
        /// The parameters.
        /// </summary>
        public InputMap<Inputs.WorkflowParameterArgs> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<Inputs.WorkflowParameterArgs>());
            set => _parameters = value;
        }

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The state.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// The resource tags.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The workflow name.
        /// </summary>
        [Input("workflowName", required: true)]
        public Input<string> WorkflowName { get; set; } = null!;

        public WorkflowArgs()
        {
        }
    }
}
