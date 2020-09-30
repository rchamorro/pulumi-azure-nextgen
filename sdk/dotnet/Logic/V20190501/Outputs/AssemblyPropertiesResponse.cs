// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20190501.Outputs
{

    [OutputType]
    public sealed class AssemblyPropertiesResponse
    {
        /// <summary>
        /// The assembly culture.
        /// </summary>
        public readonly string? AssemblyCulture;
        /// <summary>
        /// The assembly name.
        /// </summary>
        public readonly string AssemblyName;
        /// <summary>
        /// The assembly public key token.
        /// </summary>
        public readonly string? AssemblyPublicKeyToken;
        /// <summary>
        /// The assembly version.
        /// </summary>
        public readonly string? AssemblyVersion;
        /// <summary>
        /// The artifact changed time.
        /// </summary>
        public readonly string? ChangedTime;
        public readonly object? Content;
        /// <summary>
        /// The content link.
        /// </summary>
        public readonly Outputs.ContentLinkResponse? ContentLink;
        /// <summary>
        /// The content type.
        /// </summary>
        public readonly string? ContentType;
        /// <summary>
        /// The artifact creation time.
        /// </summary>
        public readonly string? CreatedTime;
        public readonly object? Metadata;

        [OutputConstructor]
        private AssemblyPropertiesResponse(
            string? assemblyCulture,

            string assemblyName,

            string? assemblyPublicKeyToken,

            string? assemblyVersion,

            string? changedTime,

            object? content,

            Outputs.ContentLinkResponse? contentLink,

            string? contentType,

            string? createdTime,

            object? metadata)
        {
            AssemblyCulture = assemblyCulture;
            AssemblyName = assemblyName;
            AssemblyPublicKeyToken = assemblyPublicKeyToken;
            AssemblyVersion = assemblyVersion;
            ChangedTime = changedTime;
            Content = content;
            ContentLink = contentLink;
            ContentType = contentType;
            CreatedTime = createdTime;
            Metadata = metadata;
        }
    }
}
