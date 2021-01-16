// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataBoxEdge.V20200901.Outputs
{

    [OutputType]
    public sealed class ResourceIdentityResponse
    {
        /// <summary>
        /// Service Principal Id backing the Msi
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// Home Tenant Id
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// Identity type
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ResourceIdentityResponse(
            string principalId,

            string tenantId,

            string? type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }
}
