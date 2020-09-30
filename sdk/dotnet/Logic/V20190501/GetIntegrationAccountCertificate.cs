// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20190501
{
    public static class GetIntegrationAccountCertificate
    {
        public static Task<GetIntegrationAccountCertificateResult> InvokeAsync(GetIntegrationAccountCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetIntegrationAccountCertificateResult>("azure-nextgen:logic/v20190501:getIntegrationAccountCertificate", args ?? new GetIntegrationAccountCertificateArgs(), options.WithVersion());
    }


    public sealed class GetIntegrationAccountCertificateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The integration account certificate name.
        /// </summary>
        [Input("certificateName", required: true)]
        public string CertificateName { get; set; } = null!;

        /// <summary>
        /// The integration account name.
        /// </summary>
        [Input("integrationAccountName", required: true)]
        public string IntegrationAccountName { get; set; } = null!;

        /// <summary>
        /// The resource group name.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetIntegrationAccountCertificateArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetIntegrationAccountCertificateResult
    {
        /// <summary>
        /// The changed time.
        /// </summary>
        public readonly string ChangedTime;
        /// <summary>
        /// The created time.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// The key details in the key vault.
        /// </summary>
        public readonly Outputs.KeyVaultKeyReferenceResponse? Key;
        /// <summary>
        /// The resource location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// The metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// Gets the resource name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The public certificate.
        /// </summary>
        public readonly string? PublicCertificate;
        /// <summary>
        /// The resource tags.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Gets the resource type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetIntegrationAccountCertificateResult(
            string changedTime,

            string createdTime,

            Outputs.KeyVaultKeyReferenceResponse? key,

            string? location,

            object? metadata,

            string name,

            string? publicCertificate,

            ImmutableDictionary<string, string>? tags,

            string type)
        {
            ChangedTime = changedTime;
            CreatedTime = createdTime;
            Key = key;
            Location = location;
            Metadata = metadata;
            Name = name;
            PublicCertificate = publicCertificate;
            Tags = tags;
            Type = type;
        }
    }
}
