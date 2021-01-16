// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20180601.Outputs
{

    [OutputType]
    public sealed class ExcelSourceResponse
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
        /// Source retry count. Type: integer (or Expression with resultType integer).
        /// </summary>
        public readonly object? SourceRetryCount;
        /// <summary>
        /// Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        public readonly object? SourceRetryWait;
        /// <summary>
        /// Excel store settings.
        /// </summary>
        public readonly object? StoreSettings;
        /// <summary>
        /// Copy source type.
        /// Expected value is 'ExcelSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ExcelSourceResponse(
            ImmutableArray<Outputs.AdditionalColumnsResponse> additionalColumns,

            object? maxConcurrentConnections,

            object? sourceRetryCount,

            object? sourceRetryWait,

            object? storeSettings,

            string type)
        {
            AdditionalColumns = additionalColumns;
            MaxConcurrentConnections = maxConcurrentConnections;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            StoreSettings = storeSettings;
            Type = type;
        }
    }
}
