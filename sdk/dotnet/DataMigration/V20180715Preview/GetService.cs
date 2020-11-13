// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview
{
    public static class GetService
    {
        public static Task<GetServiceResult> InvokeAsync(GetServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetServiceResult>("azure-nextgen:datamigration/v20180715preview:getService", args ?? new GetServiceArgs(), options.WithVersion());
    }


    public sealed class GetServiceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the resource group
        /// </summary>
        [Input("groupName", required: true)]
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the service
        /// </summary>
        [Input("serviceName", required: true)]
        public string ServiceName { get; set; } = null!;

        public GetServiceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetServiceResult
    {
        /// <summary>
        /// HTTP strong entity tag value. Ignored if submitted
        /// </summary>
        public readonly string? Etag;
        /// <summary>
        /// The resource kind. Only 'vm' (the default) is supported.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The resource's provisioning state
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// The public key of the service, used to encrypt secrets sent to the service
        /// </summary>
        public readonly string? PublicKey;
        /// <summary>
        /// Service SKU
        /// </summary>
        public readonly Outputs.ServiceSkuResponse? Sku;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The ID of the Microsoft.Network/networkInterfaces resource which the service have
        /// </summary>
        public readonly string? VirtualNicId;
        /// <summary>
        /// The ID of the Microsoft.Network/virtualNetworks/subnets resource to which the service should be joined
        /// </summary>
        public readonly string VirtualSubnetId;

        [OutputConstructor]
        private GetServiceResult(
            string? etag,

            string? kind,

            string location,

            string name,

            string provisioningState,

            string? publicKey,

            Outputs.ServiceSkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type,

            string? virtualNicId,

            string virtualSubnetId)
        {
            Etag = etag;
            Kind = kind;
            Location = location;
            Name = name;
            ProvisioningState = provisioningState;
            PublicKey = publicKey;
            Sku = sku;
            Tags = tags;
            Type = type;
            VirtualNicId = virtualNicId;
            VirtualSubnetId = virtualSubnetId;
        }
    }
}
