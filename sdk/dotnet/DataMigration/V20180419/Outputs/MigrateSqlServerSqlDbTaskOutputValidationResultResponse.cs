// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180419.Outputs
{

    [OutputType]
    public sealed class MigrateSqlServerSqlDbTaskOutputValidationResultResponse
    {
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Migration Identifier
        /// </summary>
        public readonly string MigrationId;
        /// <summary>
        /// Result type
        /// Expected value is 'MigrationValidationOutput'.
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Current status of validation at the migration level. Status from the database validation result status will be aggregated here.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Validation summary results for each database
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.MigrationValidationDatabaseSummaryResultResponse>? SummaryResults;

        [OutputConstructor]
        private MigrateSqlServerSqlDbTaskOutputValidationResultResponse(
            string id,

            string migrationId,

            string resultType,

            string status,

            ImmutableDictionary<string, Outputs.MigrationValidationDatabaseSummaryResultResponse>? summaryResults)
        {
            Id = id;
            MigrationId = migrationId;
            ResultType = resultType;
            Status = status;
            SummaryResults = summaryResults;
        }
    }
}
