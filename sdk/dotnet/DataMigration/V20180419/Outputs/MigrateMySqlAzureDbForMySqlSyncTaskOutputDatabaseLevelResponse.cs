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
    public sealed class MigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseLevelResponse
    {
        /// <summary>
        /// Number of applied changes
        /// </summary>
        public readonly double AppliedChanges;
        /// <summary>
        /// Number of cdc deletes
        /// </summary>
        public readonly double CdcDeleteCounter;
        /// <summary>
        /// Number of cdc inserts
        /// </summary>
        public readonly double CdcInsertCounter;
        /// <summary>
        /// Number of cdc updates
        /// </summary>
        public readonly double CdcUpdateCounter;
        /// <summary>
        /// Name of the database
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// Migration end time
        /// </summary>
        public readonly string EndedOn;
        /// <summary>
        /// Number of tables completed in full load
        /// </summary>
        public readonly double FullLoadCompletedTables;
        /// <summary>
        /// Number of tables errored in full load
        /// </summary>
        public readonly double FullLoadErroredTables;
        /// <summary>
        /// Number of tables loading in full load
        /// </summary>
        public readonly double FullLoadLoadingTables;
        /// <summary>
        /// Number of tables queued in full load
        /// </summary>
        public readonly double FullLoadQueuedTables;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Number of incoming changes
        /// </summary>
        public readonly double IncomingChanges;
        /// <summary>
        /// Indicates if initial load (full load) has been completed
        /// </summary>
        public readonly bool InitializationCompleted;
        /// <summary>
        /// CDC apply latency
        /// </summary>
        public readonly double Latency;
        /// <summary>
        /// Migration state that this database is in
        /// </summary>
        public readonly string MigrationState;
        /// <summary>
        /// Result type
        /// Expected value is 'DatabaseLevelOutput'.
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Migration start time
        /// </summary>
        public readonly string StartedOn;

        [OutputConstructor]
        private MigrateMySqlAzureDbForMySqlSyncTaskOutputDatabaseLevelResponse(
            double appliedChanges,

            double cdcDeleteCounter,

            double cdcInsertCounter,

            double cdcUpdateCounter,

            string databaseName,

            string endedOn,

            double fullLoadCompletedTables,

            double fullLoadErroredTables,

            double fullLoadLoadingTables,

            double fullLoadQueuedTables,

            string id,

            double incomingChanges,

            bool initializationCompleted,

            double latency,

            string migrationState,

            string resultType,

            string startedOn)
        {
            AppliedChanges = appliedChanges;
            CdcDeleteCounter = cdcDeleteCounter;
            CdcInsertCounter = cdcInsertCounter;
            CdcUpdateCounter = cdcUpdateCounter;
            DatabaseName = databaseName;
            EndedOn = endedOn;
            FullLoadCompletedTables = fullLoadCompletedTables;
            FullLoadErroredTables = fullLoadErroredTables;
            FullLoadLoadingTables = fullLoadLoadingTables;
            FullLoadQueuedTables = fullLoadQueuedTables;
            Id = id;
            IncomingChanges = incomingChanges;
            InitializationCompleted = initializationCompleted;
            Latency = latency;
            MigrationState = migrationState;
            ResultType = resultType;
            StartedOn = startedOn;
        }
    }
}
