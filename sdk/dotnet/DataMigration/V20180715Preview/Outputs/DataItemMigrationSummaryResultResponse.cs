// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNextGen.DataMigration.V20180715Preview.Outputs
{

    [OutputType]
    public sealed class DataItemMigrationSummaryResultResponse
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
        /// Number of successfully completed items
        /// </summary>
        public readonly int ItemsCompletedCount;
        /// <summary>
        /// Number of items
        /// </summary>
        public readonly int ItemsCount;
        /// <summary>
        /// Name of the item
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Wildcard string prefix to use for querying all sub-tem results of the item
        /// </summary>
        public readonly string ResultPrefix;
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
        private DataItemMigrationSummaryResultResponse(
            string endedOn,

            string errorPrefix,

            int itemsCompletedCount,

            int itemsCount,

            string name,

            string resultPrefix,

            string startedOn,

            string state,

            string statusMessage)
        {
            EndedOn = endedOn;
            ErrorPrefix = errorPrefix;
            ItemsCompletedCount = itemsCompletedCount;
            ItemsCount = itemsCount;
            Name = name;
            ResultPrefix = resultPrefix;
            StartedOn = startedOn;
            State = state;
            StatusMessage = statusMessage;
        }
    }
}
