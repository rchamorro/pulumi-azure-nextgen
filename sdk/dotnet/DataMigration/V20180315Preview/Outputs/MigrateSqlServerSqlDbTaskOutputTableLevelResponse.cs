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
    public sealed class MigrateSqlServerSqlDbTaskOutputTableLevelResponse
    {
        /// <summary>
        /// Migration end time
        /// </summary>
        public readonly string EndedOn;
        /// <summary>
        /// Wildcard string prefix to use for querying all errors of the item
        /// </summary>
        public readonly string ErrorPrefix;
        /// <summary>
        /// Result identifier
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Number of successfully completed items
        /// </summary>
        public readonly double ItemsCompletedCount;
        /// <summary>
        /// Number of items
        /// </summary>
        public readonly double ItemsCount;
        /// <summary>
        /// Name of the item
        /// </summary>
        public readonly string ObjectName;
        /// <summary>
        /// Wildcard string prefix to use for querying all sub-tem results of the item
        /// </summary>
        public readonly string ResultPrefix;
        /// <summary>
        /// Result type
        /// Expected value is 'TableLevelOutput'.
        /// </summary>
        public readonly string ResultType;
        /// <summary>
        /// Migration start time
        /// </summary>
        public readonly string StartedOn;
        /// <summary>
        /// Current state of migration
        /// </summary>
        public readonly string State;
        /// <summary>
        /// Status message
        /// </summary>
        public readonly string StatusMessage;

        [OutputConstructor]
        private MigrateSqlServerSqlDbTaskOutputTableLevelResponse(
            string endedOn,

            string errorPrefix,

            string id,

            double itemsCompletedCount,

            double itemsCount,

            string objectName,

            string resultPrefix,

            string resultType,

            string startedOn,

            string state,

            string statusMessage)
        {
            EndedOn = endedOn;
            ErrorPrefix = errorPrefix;
            Id = id;
            ItemsCompletedCount = itemsCompletedCount;
            ItemsCount = itemsCount;
            ObjectName = objectName;
            ResultPrefix = resultPrefix;
            ResultType = resultType;
            StartedOn = startedOn;
            State = state;
            StatusMessage = statusMessage;
        }
    }
}
