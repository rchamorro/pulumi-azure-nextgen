// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.StoragePool.V20200315Preview.Outputs
{

    [OutputType]
    public sealed class AttributesResponse
    {
        /// <summary>
        /// Indicates whether or not authentication is enabled on the ACL.
        /// </summary>
        public readonly bool Authentication;
        /// <summary>
        /// Indicates whether or not write protect is enabled on the luns.
        /// </summary>
        public readonly bool ProdModeWriteProtect;

        [OutputConstructor]
        private AttributesResponse(
            bool authentication,

            bool prodModeWriteProtect)
        {
            Authentication = authentication;
            ProdModeWriteProtect = prodModeWriteProtect;
        }
    }
}