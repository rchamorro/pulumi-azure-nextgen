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
    public sealed class TeradataSourceResponse
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
        /// The partition mechanism that will be used for teradata read in parallel. Possible values include: "None", "Hash", "DynamicRange".
        /// </summary>
        public readonly object? PartitionOption;
        /// <summary>
        /// The settings that will be leveraged for teradata source partitioning.
        /// </summary>
        public readonly Outputs.TeradataPartitionSettingsResponse? PartitionSettings;
        /// <summary>
        /// Teradata query. Type: string (or Expression with resultType string).
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
        private TeradataSourceResponse(
            ImmutableArray<Outputs.AdditionalColumnsResponse> additionalColumns,

            object? maxConcurrentConnections,

            object? partitionOption,

            Outputs.TeradataPartitionSettingsResponse? partitionSettings,

            object? query,

            object? queryTimeout,

            object? sourceRetryCount,

            object? sourceRetryWait,

            string type)
        {
            AdditionalColumns = additionalColumns;
            MaxConcurrentConnections = maxConcurrentConnections;
            PartitionOption = partitionOption;
            PartitionSettings = partitionSettings;
            Query = query;
            QueryTimeout = queryTimeout;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            Type = type;
        }
    }
}
