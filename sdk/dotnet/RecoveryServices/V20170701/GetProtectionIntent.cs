// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20170701
{
    public static class GetProtectionIntent
    {
        public static Task<GetProtectionIntentResult> InvokeAsync(GetProtectionIntentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProtectionIntentResult>("azure-nextgen:recoveryservices/v20170701:getProtectionIntent", args ?? new GetProtectionIntentArgs(), options.WithVersion());
    }


    public sealed class GetProtectionIntentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Fabric name associated with the backed up item.
        /// </summary>
        [Input("fabricName", required: true)]
        public string FabricName { get; set; } = null!;

        /// <summary>
        /// Backed up item name whose details are to be fetched.
        /// </summary>
        [Input("intentObjectName", required: true)]
        public string IntentObjectName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group where the recovery services vault is present.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The name of the recovery services vault.
        /// </summary>
        [Input("vaultName", required: true)]
        public string VaultName { get; set; } = null!;

        public GetProtectionIntentArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProtectionIntentResult
    {
        /// <summary>
        /// Optional ETag.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// Resource Id represents the complete path to the resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Resource name associated with the resource.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// ProtectionIntentResource properties
        /// </summary>
        public readonly object Properties;
        /// <summary>
        /// Resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type represents the complete path of the form Namespace/ResourceType/ResourceType/...
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetProtectionIntentResult(
            string? eTag,

            string id,

            string? location,

            string name,

            object properties,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ETag = eTag;
            Id = id;
            Location = location;
            Name = name;
            Properties = properties;
            Tags = tags;
            Type = type;
        }
    }
}
