// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class ManagedServiceIdentityResponseUserAssignedIdentities
    {
        /// <summary>
        /// The client id of user assigned identity.
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// The principal id of user assigned identity.
        /// </summary>
        public readonly string PrincipalId;

        [OutputConstructor]
        private ManagedServiceIdentityResponseUserAssignedIdentities(
            string clientId,

            string principalId)
        {
            ClientId = clientId;
            PrincipalId = principalId;
        }
    }
}
