// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.Latest.Outputs
{

    [OutputType]
    public sealed class MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputTableLevelResponse
    {
        /// <summary>
        /// Number of applied deletes
        /// </summary>
        public readonly int CdcDeleteCounter;
        /// <summary>
        /// Number of applied inserts
        /// </summary>
        public readonly int CdcInsertCounter;
        /// <summary>
        /// Number of applied updates
        /// </summary>
        public readonly int CdcUpdateCounter;
        /// <summary>
        /// Number of data errors occurred
        /// </summary>
        public readonly int DataErrorsCounter;
        /// <summary>
        /// Name of the database
        /// </summary>
        public readonly string DatabaseName;
        /// <summary>
        /// Full load end time
        /// </summary>
        public readonly string FullLoadEndedOn;
        /// <summary>
        /// Estimate to finish full load
        /// </summary>
        public readonly string FullLoadEstFinishTime;
        /// <summary>
        /// Full load start time
        /// </summary>
        public readonly string FullLoadStartedOn;
        /// <summary>
        /// Number of rows applied in full load
        /// </summary>
        public readonly int FullLoadTotalRows;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Last modified time on target
        /// </summary>
        public readonly string LastModifiedTime;
        /// <summary>
        /// Result type
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Current state of the table migration
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Name of the table
        /// </summary>
        public readonly string TableName;
        /// <summary>
        /// Total number of applied changes
        /// </summary>
        public readonly int TotalChangesApplied;

        [OutputConstructor]
        private MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutputTableLevelResponse(
            int cdcDeleteCounter,

            int cdcInsertCounter,

            int cdcUpdateCounter,

            int dataErrorsCounter,

            string databaseName,

            string fullLoadEndedOn,

            string fullLoadEstFinishTime,

            string fullLoadStartedOn,

            int fullLoadTotalRows,

            string id,

            string lastModifiedTime,

            string resultType,

            string state,

            string tableName,

            int totalChangesApplied)
        {
            CdcDeleteCounter = cdcDeleteCounter;
            CdcInsertCounter = cdcInsertCounter;
            CdcUpdateCounter = cdcUpdateCounter;
            DataErrorsCounter = dataErrorsCounter;
            DatabaseName = databaseName;
            FullLoadEndedOn = fullLoadEndedOn;
            FullLoadEstFinishTime = fullLoadEstFinishTime;
            FullLoadStartedOn = fullLoadStartedOn;
            FullLoadTotalRows = fullLoadTotalRows;
            Id = id;
            LastModifiedTime = lastModifiedTime;
            ResultType = resultType;
            State = state;
            TableName = tableName;
            TotalChangesApplied = totalChangesApplied;
        }
    }
}