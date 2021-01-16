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
    /// A copy activity source for Microsoft Access.
    /// </summary>
    public sealed class MicrosoftAccessSourceArgs : Pulumi.ResourceArgs
    {
        [Input("additionalColumns")]
        private InputList<Inputs.AdditionalColumnsArgs>? _additionalColumns;

        /// <summary>
        /// Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects).
        /// </summary>
        public InputList<Inputs.AdditionalColumnsArgs> AdditionalColumns
        {
            get => _additionalColumns ?? (_additionalColumns = new InputList<Inputs.AdditionalColumnsArgs>());
            set => _additionalColumns = value;
        }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Database query. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("query")]
        public Input<object>? Query { get; set; }

        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("sourceRetryCount")]
        public Input<object>? SourceRetryCount { get; set; }

        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [Input("sourceRetryWait")]
        public Input<object>? SourceRetryWait { get; set; }

        /// <summary>
        /// Copy source type.
        /// Expected value is 'MicrosoftAccessSource'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public MicrosoftAccessSourceArgs()
        {
        }
    }
}
