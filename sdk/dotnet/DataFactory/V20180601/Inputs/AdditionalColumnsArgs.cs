// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Inputs
{

    /// <summary>
    /// Specify the column name and value of additional columns.
    /// </summary>
    public sealed class AdditionalColumnsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Additional column name. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("name")]
        public Input<object>? Name { get; set; }

        /// <summary>
        /// Additional column value. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("value")]
        public Input<object>? Value { get; set; }

        public AdditionalColumnsArgs()
        {
        }
    }
}
