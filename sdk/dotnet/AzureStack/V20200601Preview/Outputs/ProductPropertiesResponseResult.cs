// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AzureStack.V20200601Preview.Outputs
{

    [OutputType]
    public sealed class ProductPropertiesResponseResult
    {
        /// <summary>
        /// The version.
        /// </summary>
        public readonly string? Version;

        [OutputConstructor]
        private ProductPropertiesResponseResult(string? version)
        {
            Version = version;
        }
    }
}
