// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Authorization.V20190101.Outputs
{

    [OutputType]
    public sealed class PolicyDefinitionReferenceResponse
    {
        /// <summary>
        /// Required if a parameter is used in policy rule.
        /// </summary>
        public readonly object? Parameters;
        /// <summary>
        /// The ID of the policy definition or policy set definition.
        /// </summary>
        public readonly string? PolicyDefinitionId;

        [OutputConstructor]
        private PolicyDefinitionReferenceResponse(
            object? parameters,

            string? policyDefinitionId)
        {
            Parameters = parameters;
            PolicyDefinitionId = policyDefinitionId;
        }
    }
}
