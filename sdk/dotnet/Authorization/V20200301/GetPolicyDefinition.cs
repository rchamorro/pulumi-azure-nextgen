// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20200301
{
    public static class GetPolicyDefinition
    {
        public static Task<GetPolicyDefinitionResult> InvokeAsync(GetPolicyDefinitionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicyDefinitionResult>("azure-nextgen:authorization/v20200301:getPolicyDefinition", args ?? new GetPolicyDefinitionArgs(), options.WithVersion());
    }


    public sealed class GetPolicyDefinitionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the policy definition to get.
        /// </summary>
        [Input("policyDefinitionName", required: true)]
        public string PolicyDefinitionName { get; set; } = null!;

        public GetPolicyDefinitionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicyDefinitionResult
    {
        /// <summary>
        /// The policy definition description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The display name of the policy definition.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        public readonly string? Mode;
        /// <summary>
        /// The name of the policy definition.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterDefinitionsValueResponse>? Parameters;
        /// <summary>
        /// The policy rule.
        /// </summary>
        public readonly object? PolicyRule;
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        public readonly string? PolicyType;
        /// <summary>
        /// The type of the resource (Microsoft.Authorization/policyDefinitions).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPolicyDefinitionResult(
            string? description,

            string? displayName,

            object? metadata,

            string? mode,

            string name,

            ImmutableDictionary<string, Outputs.ParameterDefinitionsValueResponse>? parameters,

            object? policyRule,

            string? policyType,

            string type)
        {
            Description = description;
            DisplayName = displayName;
            Metadata = metadata;
            Mode = mode;
            Name = name;
            Parameters = parameters;
            PolicyRule = policyRule;
            PolicyType = policyType;
            Type = type;
        }
    }
}
