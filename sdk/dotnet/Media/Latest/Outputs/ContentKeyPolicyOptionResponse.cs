// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Media.Latest.Outputs
{

    [OutputType]
    public sealed class ContentKeyPolicyOptionResponse
    {
        /// <summary>
        /// The key delivery configuration.
        /// </summary>
        public readonly object Configuration;
        /// <summary>
        /// The Policy Option description.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The legacy Policy Option ID.
        /// </summary>
        public readonly string PolicyOptionId;
        /// <summary>
        /// The requirements that must be met to deliver keys with this configuration
        /// </summary>
        public readonly object Restriction;

        [OutputConstructor]
        private ContentKeyPolicyOptionResponse(
            object configuration,

            string? name,

            string policyOptionId,

            object restriction)
        {
            Configuration = configuration;
            Name = name;
            PolicyOptionId = policyOptionId;
            Restriction = restriction;
        }
    }
}
