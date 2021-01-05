// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20150201Preview.Outputs
{

    [OutputType]
    public sealed class ContentLinkResponse
    {
        /// <summary>
        /// Gets or sets the content hash.
        /// </summary>
        public readonly Outputs.ContentHashResponse? ContentHash;
        /// <summary>
        /// Gets or sets the content size.
        /// </summary>
        public readonly double? ContentSize;
        /// <summary>
        /// Gets or sets the content version.
        /// </summary>
        public readonly string? ContentVersion;
        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        public readonly object? Metadata;
        /// <summary>
        /// Gets or sets the content link URI.
        /// </summary>
        public readonly string? Uri;

        [OutputConstructor]
        private ContentLinkResponse(
            Outputs.ContentHashResponse? contentHash,

            double? contentSize,

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
