// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20170601Preview
{
    public static class GetPolicySetDefinition
    {
        public static Task<GetPolicySetDefinitionResult> InvokeAsync(GetPolicySetDefinitionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicySetDefinitionResult>("azure-nextgen:authorization/v20170601preview:getPolicySetDefinition", args ?? new GetPolicySetDefinitionArgs(), options.WithVersion());
    }


    public sealed class GetPolicySetDefinitionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the policy set definition to get.
        /// </summary>
        [Input("policySetDefinitionName", required: true)]
        public string PolicySetDefinitionName { get; set; } = null!;

        public GetPolicySetDefinitionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicySetDefinitionResult
    {
        /// <summary>
        /// The policy set definition description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The policy set definition metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The name of the policy set definition.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The policy set definition parameters that can be used in policy definition references.
        /// </summary>
        public readonly object? Parameters;
        /// <summary>
        /// An array of policy definition references.
        /// </summary>
        public readonly ImmutableArray<Outputs.PolicyDefinitionReferenceResponse> PolicyDefinitions;
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
        /// </summary>
        public readonly string? PolicyType;
        /// <summary>
        /// The type of the resource (Microsoft.Authorization/policySetDefinitions).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPolicySetDefinitionResult(
            string? description,

            string? displayName,

            object? metadata,

            string name,

            object? parameters,

            ImmutableArray<Outputs.PolicyDefinitionReferenceResponse> policyDefinitions,

            string? policyType,

            string type)
        {
            Description = description;
            DisplayName = displayName;
            Metadata = metadata;
            Name = name;
            Parameters = parameters;
            PolicyDefinitions = policyDefinitions;
            PolicyType = policyType;
            Type = type;
        }
    }
}
