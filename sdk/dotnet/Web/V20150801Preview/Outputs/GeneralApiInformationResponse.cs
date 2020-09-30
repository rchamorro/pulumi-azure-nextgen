// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20150801Preview.Outputs
{

    [OutputType]
    public sealed class GeneralApiInformationResponse
    {
        /// <summary>
        /// DefaultConnectionNameTemplate
        /// </summary>
        public readonly string? ConnectionDisplayName;
        /// <summary>
        /// ConnectionPortalUrl
        /// </summary>
        public readonly object? ConnectionPortalUrl;
        /// <summary>
        /// Description
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Display Name
        /// </summary>
        public readonly string? DisplayName;
        /// <summary>
        /// Icon Url
        /// </summary>
        public readonly string? IconUrl;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Kind of resource
        /// </summary>
        public readonly string? Kind;
        /// <summary>
        /// Resource Location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource Name
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// a public accessible url of the Terms Of Use Url of this API
        /// </summary>
        public readonly string? TermsOfUseUrl;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private GeneralApiInformationResponse(
            string? connectionDisplayName,

            object? connectionPortalUrl,

            string? description,

            string? displayName,

            string? iconUrl,

            string? id,

            string? kind,

            string location,

            string? name,

            ImmutableDictionary<string, string>? tags,

            string? termsOfUseUrl,

            string? type)
        {
            ConnectionDisplayName = connectionDisplayName;
            ConnectionPortalUrl = connectionPortalUrl;
            Description = description;
            DisplayName = displayName;
            IconUrl = iconUrl;
            Id = id;
            Kind = kind;
            Location = location;
            Name = name;
            Tags = tags;
            TermsOfUseUrl = termsOfUseUrl;
            Type = type;
        }
    }
}
