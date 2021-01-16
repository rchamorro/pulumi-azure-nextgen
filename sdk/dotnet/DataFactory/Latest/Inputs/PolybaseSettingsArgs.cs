// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Inputs
{

    /// <summary>
    /// PolyBase settings.
    /// </summary>
    public sealed class PolybaseSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Determines the number of rows to attempt to retrieve before the PolyBase recalculates the percentage of rejected rows. Type: integer (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [Input("rejectSampleValue")]
        public Input<object>? RejectSampleValue { get; set; }

        /// <summary>
        /// Reject type.
        /// </summary>
        [Input("rejectType")]
        public InputUnion<string, Pulumi.AzureNextGen.DataFactory.Latest.PolybaseSettingsRejectType>? RejectType { get; set; }

        /// <summary>
        /// Specifies the value or the percentage of rows that can be rejected before the query fails. Type: number (or Expression with resultType number), minimum: 0.
        /// </summary>
        [Input("rejectValue")]
        public Input<object>? RejectValue { get; set; }

        /// <summary>
        /// Specifies how to handle missing values in delimited text files when PolyBase retrieves data from the text file. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [Input("useTypeDefault")]
        public Input<object>? UseTypeDefault { get; set; }

        public PolybaseSettingsArgs()
        {
        }
    }
}
