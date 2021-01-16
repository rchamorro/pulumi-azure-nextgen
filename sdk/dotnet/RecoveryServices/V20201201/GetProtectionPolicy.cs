// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.RecoveryServices.V20201201
{
    public static class GetProtectionPolicy
    {
        public static Task<GetProtectionPolicyResult> InvokeAsync(GetProtectionPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProtectionPolicyResult>("azure-nextgen:recoveryservices/v20201201:getProtectionPolicy", args ?? new GetProtectionPolicyArgs(), options.WithVersion());
    }


    public sealed class GetProtectionPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Backup policy information to be fetched.
        /// </summary>
        [Input("policyName", required: true)]
        public string PolicyName { get; set; } = null!;

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

        public GetProtectionPolicyArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProtectionPolicyResult
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
        /// ProtectionPolicyResource properties
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
        private GetProtectionPolicyResult(
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
