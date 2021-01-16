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
    /// A copy activity Azure Data Explorer (Kusto) source.
    /// </summary>
    public sealed class AzureDataExplorerSourceArgs : Pulumi.ResourceArgs
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
        /// The name of the Boolean option that controls whether truncation is applied to result-sets that go beyond a certain row-count limit.
        /// </summary>
        [Input("noTruncation")]
        public Input<object>? NoTruncation { get; set; }

        /// <summary>
        /// Database query. Should be a Kusto Query Language (KQL) query. Type: string (or Expression with resultType string).
        /// </summary>
        [Input("query", required: true)]
        public Input<object> Query { get; set; } = null!;

        /// <summary>
        /// Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9]))..
        /// </summary>
        [Input("queryTimeout")]
        public Input<object>? QueryTimeout { get; set; }

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
        /// Expected value is 'AzureDataExplorerSource'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AzureDataExplorerSourceArgs()
        {
        }
    }
}
