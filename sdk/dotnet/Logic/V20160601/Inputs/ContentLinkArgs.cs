// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Logic.V20160601.Inputs
{

    /// <summary>
    /// The content link.
    /// </summary>
    public sealed class ContentLinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The content hash.
        /// </summary>
        [Input("contentHash")]
        public Input<Inputs.ContentHashArgs>? ContentHash { get; set; }

        /// <summary>
        /// The content size.
        /// </summary>
        [Input("contentSize")]
        public Input<double>? ContentSize { get; set; }

        /// <summary>
        /// The content version.
        /// </summary>
        [Input("contentVersion")]
        public Input<string>? ContentVersion { get; set; }

        /// <summary>
        /// The metadata.
        /// </summary>
        [Input("metadata")]
        public Input<object>? Metadata { get; set; }

        /// <summary>
        /// The content link URI.
        /// </summary>
        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public ContentLinkArgs()
        {
        }
    }
}
