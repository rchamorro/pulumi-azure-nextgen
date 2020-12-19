// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200415.Outputs
{

    [OutputType]
    public sealed class DeliveryRuleRequestHeaderActionResponse
    {
        /// <summary>
        /// The name of the action for the delivery rule.
        /// Expected value is 'ModifyRequestHeader'.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Defines the parameters for the action.
        /// </summary>
        public readonly Outputs.HeaderActionParametersResponse Parameters;

        [OutputConstructor]
        private DeliveryRuleRequestHeaderActionResponse(
            string name,

            Outputs.HeaderActionParametersResponse parameters)
        {
            Name = name;
            Parameters = parameters;
        }
    }
}
