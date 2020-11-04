// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701
{
    public static class GetSecurityPartnerProvider
    {
        public static Task<GetSecurityPartnerProviderResult> InvokeAsync(GetSecurityPartnerProviderArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSecurityPartnerProviderResult>("azure-nextgen:network/v20200701:getSecurityPartnerProvider", args ?? new GetSecurityPartnerProviderArgs(), options.WithVersion());
    }


    public sealed class GetSecurityPartnerProviderArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the Security Partner Provider.
        /// </summary>
        [Input("securityPartnerProviderName", required: true)]
        public string SecurityPartnerProviderName { get; set; } = null!;

        public GetSecurityPartnerProviderArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSecurityPartnerProviderResult
    {
        /// <summary>
        /// The connection status with the Security Partner Provider.
        /// </summary>
        public readonly string ConnectionStatus;
        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        public readonly string Etag;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The provisioning state of the Security Partner Provider resource.
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The security provider name.
        /// </summary>
        public readonly string? SecurityProviderName;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The virtualHub to which the Security Partner Provider belongs.
        /// </summary>
        public readonly Outputs.SubResourceResponse? VirtualHub;

        [OutputConstructor]
        private GetSecurityPartnerProviderResult(
            string connectionStatus,

            string etag,

            string? location,

            string name,

            string provisioningState,

            string? securityProviderName,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.SubResourceResponse? virtualHub)
        {
            ConnectionStatus = connectionStatus;
            Etag = etag;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            SecurityProviderName = securityProviderName;
            Tags = tags;
            Type = type;
            VirtualHub = virtualHub;
        }
    }
}
