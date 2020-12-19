// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ContainerService.V20191027Preview.Inputs
{

    /// <summary>
    /// Defines the Identity provider for MS AAD.
    /// </summary>
    public sealed class OpenShiftManagedClusterAADIdentityProviderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The clientId password associated with the provider.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The groupId to be granted cluster admin role.
        /// </summary>
        [Input("customerAdminGroupId")]
        public Input<string>? CustomerAdminGroupId { get; set; }

        /// <summary>
        /// The kind of the provider.
        /// Expected value is 'AADIdentityProvider'.
        /// </summary>
        [Input("kind", required: true)]
        public Input<string> Kind { get; set; } = null!;

        /// <summary>
        /// The secret password associated with the provider.
        /// </summary>
        [Input("secret")]
        public Input<string>? Secret { get; set; }

        /// <summary>
        /// The tenantId associated with the provider.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        public OpenShiftManagedClusterAADIdentityProviderArgs()
        {
        }
    }
}
