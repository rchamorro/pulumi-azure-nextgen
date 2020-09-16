// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.V20200331.Outputs
{

    [OutputType]
    public sealed class HttpVersionMatchConditionParametersResponse
    {
        /// <summary>
        /// The match value for the condition of the delivery rule
        /// </summary>
        public readonly ImmutableArray<string> MatchValues;
        /// <summary>
        /// Describes if this is negate condition or not
        /// </summary>
        public readonly bool? NegateCondition;
        public readonly string OdataType;
        /// <summary>
        /// Describes operator to be matched
        /// </summary>
        public readonly string Operator;

        [OutputConstructor]
        private HttpVersionMatchConditionParametersResponse(
            ImmutableArray<string> matchValues,

            bool? negateCondition,

            string odataType,

            string @operator)
        {
            MatchValues = matchValues;
            NegateCondition = negateCondition;
            OdataType = odataType;
            Operator = @operator;
        }
    }
}