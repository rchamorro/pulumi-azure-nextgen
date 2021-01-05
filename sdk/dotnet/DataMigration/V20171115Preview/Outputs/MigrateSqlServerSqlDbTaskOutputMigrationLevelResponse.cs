// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20171115Preview.Outputs
{

    [OutputType]
    public sealed class MigrateSqlServerSqlDbTaskOutputMigrationLevelResponse
    {
        /// <summary>
        /// Summary of database results in the migration
        /// </summary>
        public readonly ImmutableDictionary<string, Outputs.DatabaseSummaryResultResponse> DatabaseSummary;
        /// <summary>
        /// Selected databases as a map from database name to database id
        /// </summary>
        public readonly ImmutableDictionary<string, string> Databases;
        /// <summary>
        /// Duration of task execution in seconds.
        /// </summary>
        public readonly double DurationInSeconds;
        /// <summary>
        /// Migration end time
        /// </summary>
        public readonly string EndedOn;
        /// <summary>
        /// Migration exceptions and warnings.
        /// </summary>
        public readonly ImmutableArray<Outputs.ReportableExceptionResponse> ExceptionsAndWarnings;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Migration progress message
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Migration Report Result, provides unique url for downloading your migration report.
        /// </summary>
        public readonly Outputs.MigrationReportResultResponse? MigrationReportResult;
        /// <summary>
        /// Result type
        /// Expected value is 'MigrationLevelOutput'.
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Source server brand version
        /// </summary>
        public readonly string SourceServerBrandVersion;
        /// <summary>
        /// Source server version
        /// </summary>
        public readonly string SourceServerVersion;
        /// <summary>
        /// Migration start time
        /// </summary>
        public readonly string StartedOn;
        /// <summary>
        /// Current status of migration
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Migration status message
        /// </summary>
        public readonly string StatusMessage;
        /// <summary>
        /// Target server brand version
        /// </summary>
        public readonly string TargetServerBrandVersion;
        /// <summary>
        /// Target server version
        /// </summary>
        public readonly string TargetServerVersion;

        [OutputConstructor]
        private MigrateSqlServerSqlDbTaskOutputMigrationLevelResponse(
            ImmutableDictionary<string, Outputs.DatabaseSummaryResultResponse> databaseSummary,

            ImmutableDictionary<string, string> databases,

            double durationInSeconds,

            string endedOn,

            ImmutableArray<Outputs.ReportableExceptionResponse> exceptionsAndWarnings,

            string id,

            string message,

            Outputs.MigrationReportResultResponse? migrationReportResult,

            string resultType,

            string sourceServerBrandVersion,

            string sourceServerVersion,

            string startedOn,

            string status,

            string statusMessage,

            string targetServerBrandVersion,

            string targetServerVersion)
        {
            DatabaseSummary = databaseSummary;
            Databases = databases;
            DurationInSeconds = durationInSeconds;
            EndedOn = endedOn;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            Id = id;
            Message = message;
            MigrationReportResult = migrationReportResult;
            ResultType = resultType;
            SourceServerBrandVersion = sourceServerBrandVersion;
            SourceServerVersion = sourceServerVersion;
            StartedOn = startedOn;
            Status = status;
            StatusMessage = statusMessage;
            TargetServerBrandVersion = targetServerBrandVersion;
            TargetServerVersion = targetServerVersion;
        }
    }
}
