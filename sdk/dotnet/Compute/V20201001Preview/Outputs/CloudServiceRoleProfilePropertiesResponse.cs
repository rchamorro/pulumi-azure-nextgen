// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Compute.V20201001Preview.Outputs
{

    [OutputType]
    public sealed class CloudServiceRoleProfilePropertiesResponse
    {
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Describes the cloud service role sku.
        /// </summary>
        public readonly Outputs.CloudServiceRoleSkuResponse? Sku;

        [OutputConstructor]
        private CloudServiceRoleProfilePropertiesResponse(
            string? name,

            Outputs.CloudServiceRoleSkuResponse? sku)
        {
            Name = name;
            Sku = sku;
        }
    }
}