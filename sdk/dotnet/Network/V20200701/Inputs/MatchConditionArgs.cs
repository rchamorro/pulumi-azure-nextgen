// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Network.V20200701.Inputs
{

    /// <summary>
    /// Define match conditions.
    /// </summary>
    public sealed class MatchConditionArgs : Pulumi.ResourceArgs
    {
        [Input("matchValues", required: true)]
        private InputList<string>? _matchValues;

        /// <summary>
        /// Match value.
        /// </summary>
        public InputList<string> MatchValues
        {
            get => _matchValues ?? (_matchValues = new InputList<string>());
            set => _matchValues = value;
        }

        [Input("matchVariables", required: true)]
        private InputList<Inputs.MatchVariableArgs>? _matchVariables;

        /// <summary>
        /// List of match variables.
        /// </summary>
        public InputList<Inputs.MatchVariableArgs> MatchVariables
        {
            get => _matchVariables ?? (_matchVariables = new InputList<Inputs.MatchVariableArgs>());
            set => _matchVariables = value;
        }

        /// <summary>
        /// Whether this is negate condition or not.
        /// </summary>
        [Input("negationConditon")]
        public Input<bool>? NegationConditon { get; set; }

        /// <summary>
        /// The operator to be matched.
        /// </summary>
        [Input("operator", required: true)]
        public Input<string> Operator { get; set; } = null!;

        [Input("transforms")]
        private InputList<string>? _transforms;

        /// <summary>
        /// List of transforms.
        /// </summary>
        public InputList<string> Transforms
        {
            get => _transforms ?? (_transforms = new InputList<string>());
            set => _transforms = value;
        }

        public MatchConditionArgs()
        {
        }
    }
}
