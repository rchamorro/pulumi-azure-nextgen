// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20190101
{
    /// <summary>
    /// The policy set definition.
    /// </summary>
    [AzureNextGenResourceType("azure-nextgen:authorization/v20190101:PolicySetDefinition")]
    public partial class PolicySetDefinition : Pulumi.CustomResource
    {
        /// <summary>
        /// The policy set definition description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The policy set definition metadata.
        /// </summary>
        [Output("metadata")]
        public Output<object?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the policy set definition.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        [Output("parameters")]
        public Output<object?> Parameters { get; private set; } = null!;

        /// <summary>
        /// An array of policy definition references.
        /// </summary>
        [Output("policyDefinitions")]
        public Output<ImmutableArray<Outputs.PolicyDefinitionReferenceResponse>> PolicyDefinitions { get; private set; } = null!;

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        [Output("policyType")]
        public Output<string?> PolicyType { get; private set; } = null!;

        /// <summary>
        /// The type of the resource (Microsoft.Authorization/policySetDefinitions).
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;


        /// <summary>
        /// Create a PolicySetDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PolicySetDefinition(string name, PolicySetDefinitionArgs args, CustomResourceOptions? options = null)
            : base("azure-nextgen:authorization/v20190101:PolicySetDefinition", name, args ?? new PolicySetDefinitionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PolicySetDefinition(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("azure-nextgen:authorization/v20190101:PolicySetDefinition", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/latest:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20170601preview:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20180301:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20180501:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20190601:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20190901:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20200301:PolicySetDefinition"},
                    new Pulumi.Alias { Type = "azure-nextgen:authorization/v20200901:PolicySetDefinition"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PolicySetDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PolicySetDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PolicySetDefinition(name, id, options);
        }
    }

    public sealed class PolicySetDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The policy set definition description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The policy set definition metadata.
        /// </summary>
        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        [Input("parameters")]
        public Input<object>? Parameters { get; set; }

        [Input("policyDefinitions", required: true)]
        private InputList<Inputs.PolicyDefinitionReferenceArgs>? _policyDefinitions;

        /// <summary>
        /// An array of policy definition references.
        /// </summary>
        public InputList<Inputs.PolicyDefinitionReferenceArgs> PolicyDefinitions
        {
            get => _policyDefinitions ?? (_policyDefinitions = new InputList<Inputs.PolicyDefinitionReferenceArgs>());
            set => _policyDefinitions = value;
        }

        /// <summary>
        /// The name of the policy set definition to create.
        /// </summary>
        [Input("policySetDefinitionName", required: true)]
        public Input<string> PolicySetDefinitionName { get; set; } = null!;

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        [Input("policyType")]
        public InputUnion<string, Pulumi.AzureNextGen.Authorization.V20190101.PolicyType>? PolicyType { get; set; }

        public PolicySetDefinitionArgs()
        {
        }
    }
}
