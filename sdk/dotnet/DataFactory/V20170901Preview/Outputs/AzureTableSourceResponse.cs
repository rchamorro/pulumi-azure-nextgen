// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataFactory.V20170901Preview.Outputs
{

    [OutputType]
    public sealed class AzureTableSourceResponse
    {
        /// <summary>
        /// Azure Table source ignore table not found. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public readonly object? AzureTableSourceIgnoreTableNotFound;
        /// <summary>
        /// Azure Table source query. Type: string (or Expression with resultType string).
        /// </summary>
        public readonly object? AzureTableSourceQuery;
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
        /// Expected value is 'AzureTableSource'.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private AzureTableSourceResponse(
            object? azureTableSourceIgnoreTableNotFound,

            object? azureTableSourceQuery,

            object? sourceRetryCount,

            object? sourceRetryWait,

            string type)
        {
            AzureTableSourceIgnoreTableNotFound = azureTableSourceIgnoreTableNotFound;
            AzureTableSourceQuery = azureTableSourceQuery;
            SourceRetryCount = sourceRetryCount;
            SourceRetryWait = sourceRetryWait;
            Type = type;
        }
    }
}
