// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20201101.Outputs
{

    [OutputType]
    public sealed class MatchConditionResponse
    {
        /// <summary>
        /// List of possible match values.
        /// </summary>
        public readonly ImmutableArray<string> MatchValue;
        /// <summary>
        /// Request variable to compare with.
        /// </summary>
        public readonly string MatchVariable;
        /// <summary>
        /// Describes if the result of this condition should be negated.
        /// </summary>
        public readonly bool? NegateCondition;
        /// <summary>
        /// Comparison type to use for matching with the variable value.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// Match against a specific key from the QueryString, PostArgs, RequestHeader or Cookies variables. Default is null.
        /// </summary>
        public readonly string? Selector;
        /// <summary>
        /// List of transforms.
        /// </summary>
        public readonly ImmutableArray<string> Transforms;

        [OutputConstructor]
        private MatchConditionResponse(
            ImmutableArray<string> matchValue,

            string matchVariable,

            bool? negateCondition,

            string @operator,

            string? selector,

            ImmutableArray<string> transforms)
        {
            MatchValue = matchValue;
            MatchVariable = matchVariable;
            NegateCondition = negateCondition;
            Operator = @operator;
            Selector = selector;
            Transforms = transforms;
        }
    }
}
