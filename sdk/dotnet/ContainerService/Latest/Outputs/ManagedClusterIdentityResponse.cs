// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.Latest.Outputs
{

    [OutputType]
    public sealed class ManagedClusterIdentityResponse
    {
        /// <summary>
        /// The principal id of the system assigned identity which is used by master components.
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// The tenant id of the system assigned identity which is used by master components.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The type of identity used for the managed cluster. Type 'SystemAssigned' will use an implicitly created identity in master components and an auto-created user assigned identity in MC_ resource group in agent nodes. Type 'None' will not use MSI for the managed cluster, service principal will be used instead.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// The user identity associated with the managed cluster. This identity will be used in control plane and only one user assigned identity is allowed. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.ManagedClusterIdentityResponseUserAssignedIdentities>? UserAssignedIdentities;

        [OutputConstructor]
        private ManagedClusterIdentityResponse(
            string principalId,

            string tenantId,

            string? type,

            ImmutableDictionary<string, Outputs.ManagedClusterIdentityResponseUserAssignedIdentities>? userAssignedIdentities)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
        }
    }
}