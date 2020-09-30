// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20160601.Outputs
{

    [OutputType]
    public sealed class ContentLinkResponse
    {
        /// <summary>
        /// The content hash.
        /// </summary>
        public readonly Outputs.ContentHashResponse? ContentHash;
        /// <summary>
        /// The content size.
        /// </summary>
        public readonly int? ContentSize;
        /// <summary>
        /// The content version.
        /// </summary>
        public readonly string? ContentVersion;
        /// <summary>
        /// The metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// The content link URI.
        /// </summary>
        public readonly string? Uri;

        [OutputConstructor]
        private ContentLinkResponse(
            Outputs.ContentHashResponse? contentHash,

            int? contentSize,

            string? contentVersion,

            object? metadata,

            string? uri)
        {
            ContentHash = contentHash;
            ContentSize = contentSize;
            ContentVersion = contentVersion;
            Metadata = metadata;
            Uri = uri;
        }
    }
}
