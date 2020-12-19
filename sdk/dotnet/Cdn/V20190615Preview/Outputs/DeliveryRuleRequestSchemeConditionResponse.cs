// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20190615Preview.Outputs
{

    [OutputType]
    public sealed class DeliveryRuleRequestSchemeConditionResponse
    {
        /// <summary>
        /// The name of the condition for the delivery rule.
        /// Expected value is 'RequestScheme'.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the parameters for the condition.
        /// </summary>
        public readonly Outputs.RequestSchemeMatchConditionParametersResponse Parameters;

        [OutputConstructor]
        private DeliveryRuleRequestSchemeConditionResponse(
            string name,

            Outputs.RequestSchemeMatchConditionParametersResponse parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}
