// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Resources.V20160701.Outputs
{

    [OutputType]
    public sealed class ParametersLinkResponse
    {
        /// <summary>
        /// If included it must match the ContentVersion in the template.
        /// </summary>
        public readonly string? ContentVersion;
        /// <summary>
        /// URI referencing the template.
        /// </summary>
        public readonly string Uri;

        [OutputConstructor]
        private ParametersLinkResponse(
            string? contentVersion,

            string uri)
        {
            ContentVersion = contentVersion;
            Uri = uri;
        }
    }
}