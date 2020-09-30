// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.Latest
{
    public static class GetPolicyAssignment
    {
        public static Task<GetPolicyAssignmentResult> InvokeAsync(GetPolicyAssignmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPolicyAssignmentResult>("azure-nextgen:authorization/latest:getPolicyAssignment", args ?? new GetPolicyAssignmentArgs(), options.WithVersion());
    }


    public sealed class GetPolicyAssignmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the policy assignment to get.
        /// </summary>
        [Input("policyAssignmentName", required: true)]
        public string PolicyAssignmentName { get; set; } = null!;

        /// <summary>
        /// The scope of the policy assignment. Valid scopes are: management group (format: '/providers/Microsoft.Management/managementGroups/{managementGroup}'), subscription (format: '/subscriptions/{subscriptionId}'), resource group (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}', or resource (format: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </summary>
        [Input("scope", required: true)]
        public string Scope { get; set; } = null!;

        public GetPolicyAssignmentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPolicyAssignmentResult
    {
        /// <summary>
        /// This message will be part of response in case of policy violation.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The display name of the policy assignment.
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// The policy assignment enforcement mode. Possible values are Default and DoNotEnforce.
        /// </summary>
        public readonly string? EnforcementMode;
        /// <summary>
        /// The managed identity associated with the policy assignment.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// The location of the policy assignment. Only required when utilizing managed identity.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The policy assignment metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The name of the policy assignment.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The policy's excluded scopes.
        /// </summary>
        public readonly ImmutableArray<string> NotScopes;
        /// <summary>
        /// The parameter values for the assigned policy rule. The keys are the parameter names.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ParameterValuesValueResponse>? Parameters;
        /// <summary>
        /// The ID of the policy definition or policy set definition being assigned.
        /// </summary>
        public readonly string? PolicyDefinitionId;
        /// <summary>
        /// The scope for the policy assignment.
        /// </summary>
        public readonly string? Scope;
        /// <summary>
        /// The policy sku. This property is optional, obsolete, and will be ignored.
        /// </summary>
        public readonly Outputs.PolicySkuResponse? Sku;
        /// <summary>
        /// The type of the policy assignment.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetPolicyAssignmentResult(
            string? description,

            string? displayName,

            string? enforcementMode,

            Outputs.IdentityResponse? identity,

            string? location,

            object? metadata,

            string name,

            ImmutableArray<string> notScopes,

            ImmutableDictionary<string, Outputs.ParameterValuesValueResponse>? parameters,

            string? policyDefinitionId,

            string? scope,

            Outputs.PolicySkuResponse? sku,

            string type)
        {
            Description = description;
            DisplayName = displayName;
            EnforcementMode = enforcementMode;
            Identity = identity;
            Location = location;
            Metadata = metadata;
            Name = name;
            NotScopes = notScopes;
            Parameters = parameters;
            PolicyDefinitionId = policyDefinitionId;
            Scope = scope;
            Sku = sku;
            Type = type;
        }
    }
}
