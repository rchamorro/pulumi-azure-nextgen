// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.Cdn.Latest.Inputs
{

    /// <summary>
    /// Defines the HttpVersion condition for the delivery rule.
    /// </summary>
    public sealed class DeliveryRuleHttpVersionConditionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the condition for the delivery rule.
        /// Expected value is 'HttpVersion'.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Defines the parameters for the condition.
        /// </summary>
        [Input("parameters", required: true)]
        public Input<Inputs.HttpVersionMatchConditionParametersArgs> Parameters { get; set; } = null!;

        public DeliveryRuleHttpVersionConditionArgs()
        {
        }
    }
}
