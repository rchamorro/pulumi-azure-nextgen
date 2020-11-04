// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Outputs
{

    [OutputType]
    public sealed class O365BreakOutCategoryPoliciesResponse
    {
        /// <summary>
        /// Flag to control allow category.
        /// </summary>
        public readonly bool? Allow;
        /// <summary>
        /// Flag to control default category.
        /// </summary>
        public readonly bool? Default;
        /// <summary>
        /// Flag to control optimize category.
        /// </summary>
        public readonly bool? Optimize;

        [OutputConstructor]
        private O365BreakOutCategoryPoliciesResponse(
            bool? allow,

            bool? @default,

            bool? optimize)
        {
            Allow = allow;
            Default = @default;
            Optimize = optimize;
        }
    }
}
