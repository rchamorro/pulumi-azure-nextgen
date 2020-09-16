// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DBForPostgreSql.V20200214PrivatePreview.Outputs
{

    [OutputType]
    public sealed class SkuResponse
    {
        /// <summary>
        /// The name of the sku, typically, tier + family + cores, e.g. Standard_D4s_v3.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The tier of the particular SKU, e.g. Burstable.
        /// </summary>
        public readonly string Tier;

        [OutputConstructor]
        private SkuResponse(
            string name,

            string tier)
        {
            Name = name;
            Tier = tier;
        }
    }
}