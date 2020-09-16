// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Web.V20200601.Outputs
{

    [OutputType]
    public sealed class ExperimentsResponse
    {
        /// <summary>
        /// List of ramp-up rules.
        /// </summary>
        public readonly ImmutableArray<Outputs.RampUpRuleResponse> RampUpRules;

        [OutputConstructor]
        private ExperimentsResponse(ImmutableArray<Outputs.RampUpRuleResponse> rampUpRules)
        {
            RampUpRules = rampUpRules;
        }
    }
}