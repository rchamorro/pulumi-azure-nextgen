// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.KeyVault.V20200401Preview.Outputs
{

    [OutputType]
    public sealed class ManagedHsmPropertiesResponse
    {
        /// <summary>
        /// The create mode to indicate whether the resource is being created or is being recovered from a deleted resource.
        /// </summary>
        public readonly string? CreateMode;
        /// <summary>
        /// Property specifying whether protection against purge is enabled for this managed HSM pool. Setting this property to true activates protection against purge for this managed HSM pool and its content - only the Managed HSM service may initiate a hard, irrecoverable deletion. The setting is effective only if soft delete is also enabled. Enabling this functionality is irreversible.
        /// </summary>
        public readonly bool? EnablePurgeProtection;
        /// <summary>
        /// Property to specify whether the 'soft delete' functionality is enabled for this managed HSM pool. If it's not set to any value(true or false) when creating new managed HSM pool, it will be set to true by default. Once set to true, it cannot be reverted to false.
        /// </summary>
        public readonly bool? EnableSoftDelete;
        /// <summary>
        /// The URI of the managed hsm pool for performing operations on keys.
        /// </summary>
        public readonly string HsmUri;
        /// <summary>
        /// Array of initial administrators object ids for this managed hsm pool.
        /// </summary>
        public readonly ImmutableArray<string> InitialAdminObjectIds;
        /// <summary>
        /// Provisioning state.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// softDelete data retention days. It accepts &gt;=7 and &lt;=90.
        /// </summary>
        public readonly int? SoftDeleteRetentionInDays;
        /// <summary>
        /// Resource Status Message.
        /// </summary>
        public readonly string StatusMessage;
        /// <summary>
        /// The Azure Active Directory tenant ID that should be used for authenticating requests to the managed HSM pool.
        /// </summary>
        public readonly string? TenantId;

        [OutputConstructor]
        private ManagedHsmPropertiesResponse(
            string? createMode,

            bool? enablePurgeProtection,

            bool? enableSoftDelete,

            string hsmUri,

            ImmutableArray<string> initialAdminObjectIds,

            string provisioningState,

            int? softDeleteRetentionInDays,

            string statusMessage,

            string? tenantId)
        {
            CreateMode = createMode;
            EnablePurgeProtection = enablePurgeProtection;
            EnableSoftDelete = enableSoftDelete;
            HsmUri = hsmUri;
            InitialAdminObjectIds = initialAdminObjectIds;
            ProvisioningState = provisioningState;
            SoftDeleteRetentionInDays = softDeleteRetentionInDays;
            StatusMessage = statusMessage;
            TenantId = tenantId;
        }
    }
}
