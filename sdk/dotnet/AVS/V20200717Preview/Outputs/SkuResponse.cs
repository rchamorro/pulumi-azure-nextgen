// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.AVS.V20200717Preview.Outputs
{

    [OutputType]
    public sealed class SkuResponse
    {
        /// <summary>
        /// The name of the SKU.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private SkuResponse(string name)
        {
            Name = name;
        }
    }
}
