// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180315Preview.Outputs
{

    [OutputType]
    public sealed class MigrateSqlServerSqlMITaskOutputMigrationLevelResponse
    {
        /// <summary>
        /// Selected databases as a map from database name to database id
        /// </summary>
        public readonly ImmutableDictionary<string, string> Databases;
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
        /// Result type
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
        /// Current state of migration
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Current status of migration
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Target server brand version
        /// </summary>
        public readonly string TargetServerBrandVersion;
        /// <summary>
        /// Target server version
        /// </summary>
        public readonly string TargetServerVersion;

        [OutputConstructor]
        private MigrateSqlServerSqlMITaskOutputMigrationLevelResponse(
            ImmutableDictionary<string, string> databases,

            string endedOn,

            ImmutableArray<Outputs.ReportableExceptionResponse> exceptionsAndWarnings,

            string id,

            string message,

            string resultType,

            string sourceServerBrandVersion,

            string sourceServerVersion,

            string startedOn,

            string state,

            string status,

            string targetServerBrandVersion,

            string targetServerVersion)
        {
            Databases = databases;
            EndedOn = endedOn;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            Id = id;
            Message = message;
            ResultType = resultType;
            SourceServerBrandVersion = sourceServerBrandVersion;
            SourceServerVersion = sourceServerVersion;
            StartedOn = startedOn;
            State = state;
            Status = status;
            TargetServerBrandVersion = targetServerBrandVersion;
            TargetServerVersion = targetServerVersion;
        }
    }
}
