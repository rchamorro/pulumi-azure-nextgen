// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20160201
{
    public static class GetResource
    {
        public static Task<GetResourceResult> InvokeAsync(GetResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourceResult>("azure-nextgen:resources/v20160201:getResource", args ?? new GetResourceArgs(), options.WithVersion());
    }


    public sealed class GetResourceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Resource identity.
        /// </summary>
        [Input("parentResourcePath", required: true)]
        public string ParentResourcePath { get; set; } = null!;

        /// <summary>
        /// The name of the resource group. The name is case insensitive.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Resource identity.
        /// </summary>
        [Input("resourceName", required: true)]
        public string ResourceName { get; set; } = null!;

        /// <summary>
        /// Resource identity.
        /// </summary>
        [Input("resourceProviderNamespace", required: true)]
        public string ResourceProviderNamespace { get; set; } = null!;

        /// <summary>
        /// Resource identity.
        /// </summary>
        [Input("resourceType", required: true)]
        public string ResourceType { get; set; } = null!;

        public GetResourceArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetResourceResult
    {
        /// <summary>
        /// The identity of the resource.
        /// </summary>
        public readonly Outputs.IdentityResponse? Identity;
        /// <summary>
        /// The kind of the resource.
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Id of the resource that manages this resource.
        /// </summary>
        public readonly string? ManagedBy;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The plan of the resource.
        /// </summary>
        public readonly Outputs.PlanResponse? Plan;
        /// <summary>
        /// The resource properties.
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// The sku of the resource.
        /// </summary>
        public readonly Outputs.SkuResponse? Sku;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetResourceResult(
            Outputs.IdentityResponse? identity,

            string? kind,

            string? location,

            string? managedBy,

            string name,

            Outputs.PlanResponse? plan,

            object properties,

            Outputs.SkuResponse? sku,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            Identity = identity;
            Kind = kind;
            Location = location;
            ManagedBy = managedBy;
            Name = name;
            Plan = plan;
            Properties = properties;
            Sku = sku;
            Tags = tags;
            Type = type;
        }
    }
}
