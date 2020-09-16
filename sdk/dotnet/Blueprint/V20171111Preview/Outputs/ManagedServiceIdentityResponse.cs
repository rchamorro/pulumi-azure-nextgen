// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Blueprint.V20171111Preview.Outputs
{

    [OutputType]
    public sealed class ManagedServiceIdentityResponse
    {
        /// <summary>
        /// Azure Active Directory principal ID associated with this Identity.
        /// </summary>
        public readonly string? PrincipalId;
        /// <summary>
        /// ID of the Azure Active Directory.
        /// </summary>
        public readonly string? TenantId;
        /// <summary>
        /// Type of the Managed Service Identity.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ManagedServiceIdentityResponse(
            string? principalId,

            string? tenantId,

            string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }
}