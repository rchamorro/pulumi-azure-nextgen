// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.ServiceBus.V20170401.Inputs
{

    /// <summary>
    /// Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression.
    /// </summary>
    public sealed class ActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// This property is reserved for future use. An integer value showing the compatibility level, currently hard-coded to 20.
        /// </summary>
        [Input("compatibilityLevel")]
        public Input<int>? CompatibilityLevel { get; set; }

        /// <summary>
        /// Value that indicates whether the rule action requires preprocessing.
        /// </summary>
        [Input("requiresPreprocessing")]
        public Input<bool>? RequiresPreprocessing { get; set; }

        /// <summary>
        /// SQL expression. e.g. MyProperty='ABC'
        /// </summary>
        [Input("sqlExpression")]
        public Input<string>? SqlExpression { get; set; }

        public ActionArgs()
        {
            RequiresPreprocessing = true;
        }
    }
}
