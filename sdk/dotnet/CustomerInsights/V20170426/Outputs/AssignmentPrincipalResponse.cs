// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.CustomerInsights.V20170426.Outputs
{

    [OutputType]
    public sealed class AssignmentPrincipalResponse
    {
        /// <summary>
        /// The principal id being assigned to.
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// Other metadata for the principal.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? PrincipalMetadata;
        /// <summary>
        /// The Type of the principal ID.
        /// </summary>
        public readonly string PrincipalType;

        [OutputConstructor]
        private AssignmentPrincipalResponse(
            string principalId,

            ImmutableDictionary<string, string>? principalMetadata,

            string principalType)
        {
            PrincipalId = principalId;
            PrincipalMetadata = principalMetadata;
            PrincipalType = principalType;
        }
    }
}