// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Management.V20170601Preview
{
    public static class GetPolicySetDefinitionAtManagementGroup
    {
        public static Task<GetPolicySetDefinitionAtManagementGroupResult> InvokeAsync(GetPolicySetDefinitionAtManagementGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicySetDefinitionAtManagementGroupResult>("azure-nextgen:management/v20170601preview:getPolicySetDefinitionAtManagementGroup", args ?? new GetPolicySetDefinitionAtManagementGroupArgs(), options.WithVersion());
    }


    public sealed class GetPolicySetDefinitionAtManagementGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The ID of the management group.
        /// </summary>
        [Input("managementGroupId", required: true)]
        public string ManagementGroupId { get; set; } = null!;

        /// <summary>
        /// The name of the policy set definition to get.
        /// </summary>
        [Input("policySetDefinitionName", required: true)]
        public string PolicySetDefinitionName { get; set; } = null!;

        public GetPolicySetDefinitionAtManagementGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicySetDefinitionAtManagementGroupResult
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
        private GetPolicySetDefinitionAtManagementGroupResult(
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
