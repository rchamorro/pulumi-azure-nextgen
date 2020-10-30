// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Marketplace.Latest.Outputs
{

    [OutputType]
    public sealed class IconResponse
    {
        /// <summary>
        /// Icon size
        /// </summary>
        public readonly string? IconKind;
        /// <summary>
        /// Icon uri
        /// </summary>
        public readonly string? Uri;

        [OutputConstructor]
        private IconResponse(
            string? iconKind,

            string? uri)
        {
            IconKind = iconKind;
            Uri = uri;
        }
    }
}