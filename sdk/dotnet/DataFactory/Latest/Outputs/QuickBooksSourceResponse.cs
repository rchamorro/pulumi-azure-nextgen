// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.Latest.Outputs
{

    [OutputType]
    public sealed class QuickBooksSourceResponse
    {
        /// <summary>
        /// Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects).
        /// </summary>
        public readonly ImmutableArray<Outputs.AdditionalColumnsResponse> AdditionalColumns;
        /// <summary>
        /// The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? MaxConcurrentConnections;
        /// <summary>
        /// A query to retrieve data from source. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? Query;
        /// <summary>
        /// Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? QueryTimeout;
        /// <summary>
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SourceRetryCount;
        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SourceRetryWait;
        /// <summary>
        /// Copy source type.
        /// Expected value is 'TabularSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private QuickBooksSourceResponse(
            ImmutableArray<Outputs.AdditionalColumnsResponse> additionalColumns,

            object? maxConcurrentConnections,

            object? query,

            object? queryTimeout,

            object? sourceRetryCount,

            object? sourceRetryWait,

            string type)
        {
            AdditionalColumns = additionalColumns;
            MaxConcurrentConnections = maxConcurrentConnections;
            Query = query;
            QueryTimeout = queryTimeout;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            Type = type;
        }
    }
}
