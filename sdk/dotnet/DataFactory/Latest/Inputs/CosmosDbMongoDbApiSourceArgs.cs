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
    /// A copy activity source for a CosmosDB (MongoDB API) database.
    /// </summary>
    public sealed class CosmosDbMongoDbApiSourceArgs : Pulumi.ResourceArgs
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
        /// Specifies the number of documents to return in each batch of the response from MongoDB instance. In most cases, modifying the batch size will not affect the user or the application. This property's main purpose is to avoid hit the limitation of response size. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("batchSize")]
        public Input<object>? BatchSize { get; set; }

        /// <summary>
        /// Cursor methods for Mongodb query.
        /// </summary>
        [Input("cursorMethods")]
        public Input<Inputs.MongoDbCursorMethodsPropertiesArgs>? CursorMethods { get; set; }

        /// <summary>
        /// Specifies selection filter using query operators. To return all documents in a collection, omit this parameter or pass an empty document ({}). Type: string (or Expression with resultType string).
        /// </summary>
        [Input("filter")]
        public Input<object>? Filter { get; set; }

        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        [Input("maxConcurrentConnections")]
        public Input<object>? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
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
        /// Expected value is 'CosmosDbMongoDbApiSource'.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public CosmosDbMongoDbApiSourceArgs()
        {
        }
    }
}
